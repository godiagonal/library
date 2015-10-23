using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace Library
{
    public partial class LibraryForm : MetroFramework.Forms.MetroForm
    {
        BookService _bookService;
        AuthorService _authorService;
        MemberService _memberService;
        LoanService _loanService;
        BookCopyService _bookCopyService;
        Book _selectedBook;
        Member _selectedMember;
        BookCopy _selectedBookCopy;

        public LibraryForm()
        {
            InitializeComponent();

            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookCopyService = new BookCopyService(repoFactory);
            _bookService = new BookService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _memberService = new MemberService(repoFactory);
            _loanService = new LoanService(repoFactory);

            _bookService.Updated += _bookService_Updated;
            _bookCopyService.Updated += _bookService_Updated;
            _loanService.Updated += _bookService_Updated;

            UpdateBooks(_bookService.All());
            UpdateMembers(_memberService.All());
            
        }

        private void grd_Books_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_Books.SelectedRows.Count > 0)
            {
                _selectedBook = GetSelectedBook();

                lbl_BookTitle.Text = _selectedBook.Title;
                lbl_BookId.Text = _selectedBook.Id.ToString();
                lbl_BookISBN.Text = _selectedBook.ISBN;
                txt_BookDescription.Text = _selectedBook.Description;

                UpdateBookCopies(_selectedBook.BookCopies);

                pnl_SelectedBook.Visible = true;
            }
            else
            {
                _selectedBook = null;
                pnl_SelectedBook.Visible = false;
            }

            txt_BookSearch.Focus();
        }

        private Book GetSelectedBook()
        {
            DataGridViewRow row = grd_Books.SelectedRows[0];
            return _bookService.Find((int)row.Cells[0].Value);
        }

        private void SetSelectedBook(Book book)
        {
            foreach (DataGridViewRow row in grd_Books.Rows)
            {
                if ((int)row.Cells[0].Value == book.Id)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void UpdateBooks(IEnumerable<Book> books)
        {
            Book prevSelectedBook = null;

            // Save selected book before clearing the list
            if (grd_Books.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grd_Books.SelectedRows[0];
                Book book = _bookService.Find((int)row.Cells[0].Value);
                prevSelectedBook = book;
            }

            grd_Books.Rows.Clear();

            foreach (Book book in books)
            {
                Bitmap availableIcon;

                if (book.Available)
                    availableIcon = new Bitmap(global::Library.Properties.Resources.icon_check, 20, 20);
                else
                    availableIcon = new Bitmap(global::Library.Properties.Resources.icon_cross, 18, 18);

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                id.Value = book.Id;

                DataGridViewTextBoxCell title = new DataGridViewTextBoxCell();
                title.Value = book.Title;

                DataGridViewTextBoxCell author = new DataGridViewTextBoxCell();
                author.Value = book.Author == null ? "" : book.Author.Name;

                DataGridViewImageCell available = new DataGridViewImageCell();
                available.Value = availableIcon;

                row.Cells.AddRange(new DataGridViewCell[] { id, title, author, available });

                grd_Books.Rows.Add(row);
            }

            // Set selected index to previously selected book
            if (prevSelectedBook != null)
            {
                SetSelectedBook(prevSelectedBook);
            }
        }

        private void UpdateBookCopies(IEnumerable<BookCopy> bookCopies)
        {
            grd_BookCopies.Rows.Clear();

            foreach (BookCopy bookCopy in bookCopies)
            {
                Bitmap availableIcon;

                if (bookCopy.CurrentLoan == null)
                    availableIcon = new Bitmap(global::Library.Properties.Resources.icon_check, 20, 20);
                else
                    availableIcon = new Bitmap(global::Library.Properties.Resources.icon_cross, 18, 18);

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                id.Value = bookCopy.Id;

                DataGridViewImageCell available = new DataGridViewImageCell();
                available.Value = availableIcon;

                DataGridViewTextBoxCell member = new DataGridViewTextBoxCell();
                member.Value = bookCopy.CurrentLoan == null ? "" : bookCopy.CurrentLoan.Member.Name;

                DataGridViewTextBoxCell dueDate = new DataGridViewTextBoxCell();
                dueDate.Value = bookCopy.CurrentLoan == null ? "" : bookCopy.CurrentLoan.DueDate.ToShortDateString();

                // ******* Funkar fortfarande inte när man markerar raden *****
                // Mark as red if due date has passed and the book is not returned
                if (dueDate.Value.ToString().Length > 0 && bookCopy.CurrentLoan.DueDate < DateTime.Now)
                    dueDate.Style.ForeColor = Color.Red;

                row.Cells.AddRange(new DataGridViewCell[] { id, available, member, dueDate });

                grd_BookCopies.Rows.Add(row);
            }
        }

        private void cbx_AvailableOnly_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<Book> books = _bookService.Search(txt_BookSearch.Text, cbx_AvailableOnly.Checked);
            UpdateBooks(books);
        }

        private void txt_BookSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Book> books = _bookService.Search(txt_BookSearch.Text, cbx_AvailableOnly.Checked);
            UpdateBooks(books);
        }

        private void _bookService_Updated(object sender, EventArgs e)
        {
            IEnumerable<Book> books = _bookService.Search(txt_BookSearch.Text, cbx_AvailableOnly.Checked);
            UpdateBooks(books);
        }

        private void btn_NewBook_Click(object sender, EventArgs e)
        {
            var form = new NewBookForm(_bookService, _authorService);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                MetroMessageBox.Show(this, string.Format("{0} was successfully added to the list of books", form.NewBookTitle), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btn_AddCopy_Click(object sender, EventArgs e)
        {
            if(_selectedBook != null)
            {
                _bookCopyService.Add(_selectedBook);  
            }
        }

        private void grd_BookCopies_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_BookCopies.SelectedRows.Count > 0)
            {
                _selectedBookCopy = GetSelectedBookCopy();

                // Book on loan
                if (_selectedBookCopy != null && _selectedBookCopy.CurrentLoan != null)
                {
                    btn_BooksMakeLoan.Enabled = false;
                    btn_BooksReturnLoan.Enabled = true;
                }

                // Book available
                else if (_selectedBookCopy != null)
                {
                    btn_BooksMakeLoan.Enabled = true;
                    btn_BooksReturnLoan.Enabled = false;
                }

                // No book
                else
                {
                    btn_BooksMakeLoan.Enabled = false;
                    btn_BooksReturnLoan.Enabled = false;
                }
            }
            else
            {
                _selectedBookCopy = null;

                btn_BooksMakeLoan.Enabled = false;
                btn_BooksReturnLoan.Enabled = false;
            }
        }

        private BookCopy GetSelectedBookCopy()
        {
            DataGridViewRow row = grd_BookCopies.SelectedRows[0];
            return _bookCopyService.Find((int)row.Cells[0].Value);
        }

        private void btn_BooksMakeLoan_Click(object sender, EventArgs e)
        {
            if (_selectedBookCopy != null)
            {
                //var form = new NewLoanForm(_bookService, _bookCopyService, _memberService, _loanService, _selectedBookCopy);

                //if (form.ShowDialog(this) == DialogResult.OK)
                //{
                //    MetroMessageBox.Show(this, String.Format("A loan of {0} was successfully made for {1}", form.BookTitle, form.MemberName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //}
            }
        }

        private void btn_BooksReturnLoan_Click(object sender, EventArgs e)
        {
            if (_selectedBookCopy != null)
            {

            }
        }

        private void UpdateMembers(IEnumerable<Member> members)
        {
            Member prevSelectedMember = null;

            // Save selected book before clearing the list
            if (grd_Members.SelectedRows.Count > 0)
            {
                DataGridViewRow row = grd_Members.SelectedRows[0];
                Member member = _memberService.Find((int)row.Cells[0].Value);
                prevSelectedMember = member;
            }

            grd_Members.Rows.Clear();
            foreach (Member member in members)
            {
                grd_Members.Rows.Add(
                member.Id,
                member.Name,
                member.PersonalNumber,
                member.Loans.Where(l => l.TimeOfReturn == null).Count()
                );
            }

            // Set selected index to previously selected book
            if (prevSelectedMember != null)
            {
                SetSelectedMember(prevSelectedMember);
            }
        }

        private void txt_MemberSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Member> members = _memberService.Search(txt_MemberSearch.Text, cbx_MembersWithActiveLoans.Checked);
            UpdateMembers(members);
        }

        private void SetSelectedMember(Member member)
        {
            foreach (DataGridViewRow row in grd_Members.Rows)
            {
                if ((int)row.Cells[0].Value == member.Id)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void grd_Members_SelectionChanged(object sender, EventArgs e)
        {
            if (grd_Members.SelectedRows.Count > 0)
            {
                _selectedMember = GetSelectedMember();

                lbl_MemberName.Text = _selectedMember.Name;
                lbl_MemberID.Text = _selectedMember.Id.ToString();
                lbl_pNr.Text = _selectedMember.PersonalNumber;

                UpdateMemberLoans(_loanService.ListMemberLoans(_selectedMember, cbx_Members_ShowReturnedLoans.Checked));

                pnl_SelectedMember.Visible = true;
            }
            else
            {
                _selectedMember = null;
                pnl_SelectedMember.Visible = false;
            }

            txt_MemberSearch.Focus();
        }

        private Member GetSelectedMember()
        {
            DataGridViewRow row = grd_Members.SelectedRows[0];
            return _memberService.Find((int)row.Cells[0].Value);
        }

        private void UpdateMemberLoans(IEnumerable<Loan> loans)
        {
            grd_Members_Loans.Rows.Clear();
            foreach (Loan loan in loans)
            {
                grd_Members_Loans.Rows.Add(
                loan.Id,
                loan.BookCopy.Book.Title,
                loan.BookCopy.Book.Author,
                loan.DueDate.ToShortDateString(),
                loan.TimeOfReturn);
            }
        }

        private void cbx_MembersWithActiveLoans_CheckedChanged(object sender, EventArgs e)
        {
            IEnumerable<Member> members = _memberService.Search(txt_MemberSearch.Text, cbx_MembersWithActiveLoans.Checked);
            UpdateMembers(members);
        }

        private void cbx_Members_ShowReturnedLoans_CheckedChanged(object sender, EventArgs e)
        {
            Member member = _memberService.Find(Convert.ToInt32(lbl_MemberID.Text));
            UpdateMemberLoans(_loanService.ListMemberLoans(member, cbx_Members_ShowReturnedLoans.Checked));
        }
    }
}
