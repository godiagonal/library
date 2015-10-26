// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

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
    /// <summary>
    /// Main form for library app
    /// </summary>
    public partial class LibraryForm : MetroFramework.Forms.MetroForm
    {
        BookService _bookService;
        AuthorService _authorService;
        MemberService _memberService;
        LoanService _loanService;
        BookCopyService _bookCopyService;

        // Keeps track of selected objects in lists/gridviews
        Book _selectedBook;
        BookCopy _selectedBookCopy;
        Member _selectedMember;
        Loan _selectedLoan;
        Loan _selectedMemberLoan;

        public LibraryForm()
        {
            InitializeComponent();

            // Start on "Books" tab
            tbc_Main.SelectedIndex = 0;

            // Init services
            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookCopyService = new BookCopyService(repoFactory);
            _bookService = new BookService(repoFactory);
            _authorService = new AuthorService(repoFactory);
            _memberService = new MemberService(repoFactory);
            _loanService = new LoanService(repoFactory);

            // Subscribe to events
            _bookService.Updated += _bookService_Updated;
            _bookCopyService.Updated += _bookService_Updated;
            _memberService.Updated += _memberService_Updated;
            _loanService.Updated += _bookService_Updated;
            _loanService.Updated += _memberService_Updated;
            _loanService.Updated += _loanService_Updated;

            // Fill the three main gridviews on startup
            UpdateMembers(_memberService.All());
            UpdateLoans(_loanService.Search(null, false));
            UpdateBooks(_bookService.All());
        }


//--------------------------------------BOOKS TAB START--------------------------------------------------------------//


        /// <summary>
        /// Update books gridview
        /// </summary>
        /// <param name="books"></param>
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

                if (book.AvailableBookCopies.Count() > 0)
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

        /// <summary>
        /// Update book copies gridview
        /// </summary>
        /// <param name="bookCopies">List of book copies</param>
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

                // Mark as red if due date has passed and the book is not returned
                if (bookCopy.CurrentLoan != null)
                    MarkIfPassedDueDate(dueDate, bookCopy.CurrentLoan.DueDate);

                row.Cells.AddRange(new DataGridViewCell[] { id, available, member, dueDate });

                grd_BookCopies.Rows.Add(row);
            }
        }

        /// <summary>
        /// Mark due date cell text with red color if the due date has already passed and the book is not returned
        /// </summary>
        /// <param name="cell">Cell containing due date</param>
        /// <param name="dueDate">The due date datetime object</param>
        private void MarkIfPassedDueDate(DataGridViewTextBoxCell cell, DateTime dueDate)
        {
            if (cell.Value.ToString().Length > 0 && dueDate < DateTime.Now)
            {
                cell.Style.ForeColor = Color.Red;
                cell.Style.SelectionForeColor = Color.Red;
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
            // Enable/disable buttons depending on selected row
            if (grd_BookCopies.SelectedRows.Count > 0)
            {
                _selectedBookCopy = GetSelectedBookCopy();

                // Book on loan
                if (_selectedBookCopy != null && _selectedBookCopy.CurrentLoan != null)
                {
                    btn_Books_MakeLoan.Enabled = false;
                    btn_Books_ReturnLoan.Enabled = true;
                }

                // Book available
                else if (_selectedBookCopy != null)
                {
                    btn_Books_MakeLoan.Enabled = true;
                    btn_Books_ReturnLoan.Enabled = false;
                }

                // No book
                else
                {
                    btn_Books_MakeLoan.Enabled = false;
                    btn_Books_ReturnLoan.Enabled = false;
                }
            }
            else
            {
                _selectedBookCopy = null;

                btn_Books_MakeLoan.Enabled = false;
                btn_Books_ReturnLoan.Enabled = false;
            }
        }

        private BookCopy GetSelectedBookCopy()
        {
            DataGridViewRow row = grd_BookCopies.SelectedRows[0];
            return _bookCopyService.Find((int)row.Cells[0].Value);
        }

        private void btn_Books_MakeLoan_Click(object sender, EventArgs e)
        {
            if (_selectedBookCopy != null)
            {
                var form = new NewLoanForm(_bookService, _bookCopyService, _memberService, _loanService, _selectedBookCopy);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MetroMessageBox.Show(this, String.Format("A loan of {0} was successfully made for {1}", form.BookTitle, form.MemberName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btn_Books_ReturnLoan_Click(object sender, EventArgs e)
        {
            if (_selectedBookCopy != null)
            {
                try
                {
                    double fee;
                    string bookTitle = _selectedBookCopy.Book.Title;
                    string memberName = _selectedBookCopy.CurrentLoan.Member.Name;

                    _loanService.Return(_selectedBookCopy.CurrentLoan, out fee);

                    if (fee > 0)
                        MetroMessageBox.Show(this, String.Format("{0} was returned past its due date and {1} has to pay a {2} SEK fee", bookTitle, memberName, fee.ToString()), "Fee required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MetroMessageBox.Show(this, String.Format("{0} was successfully returned", bookTitle), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (InvalidOperationException error)
                {
                    MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


//--------------------------------------BOOKS TAB END------------------------------------------------------------------//



//--------------------------------------MEMBERS TAB START--------------------------------------------------------------//


        /// <summary>
        /// Update members gridview
        /// </summary>
        /// <param name="members">List of members</param>
        private void UpdateMembers(IEnumerable<Member> members)
        {
            Member prevSelectedMember = null;

            // Save previously selected member
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
                    member.ActiveLoans.Count()
                );
            }

            // Set selected index to previously selected member
            if (prevSelectedMember != null)
            {
                SetSelectedMember(prevSelectedMember);
            }
        }

        private Member GetSelectedMember()
        {
            DataGridViewRow row = grd_Members.SelectedRows[0];
            return _memberService.Find((int)row.Cells[0].Value);
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

                UpdateMemberLoans(_loanService.Search(_selectedMember, cbx_Members_ShowReturnedLoans.Checked));

                pnl_SelectedMember.Visible = true;
            }
            else
            {
                _selectedMember = null;
                pnl_SelectedMember.Visible = false;
            }

            txt_MemberSearch.Focus();
        }

        private void txt_MemberSearch_TextChanged(object sender, EventArgs e)
        {
            IEnumerable<Member> members = _memberService.Search(txt_MemberSearch.Text, cbx_MembersWithActiveLoans.Checked);
            UpdateMembers(members);
        }

        private Loan GetSelectedMemberLoan()
        {
            DataGridViewRow row = grd_Members_Loans.SelectedRows[0];
            return _loanService.Find((int)row.Cells[0].Value);
        }

        private void grd_Members_Loans_SelectionChanged(object sender, EventArgs e)
        {
            // Enable/disable buttons depending on selected row
            if (grd_Members_Loans.SelectedRows.Count > 0)
            {
                _selectedMemberLoan = GetSelectedMemberLoan();

                // The selected loan is active and not returned yet - enable return button
                if (_selectedMemberLoan != null && _selectedMemberLoan.TimeOfReturn == null)
                    btn_Members_ReturnLoan.Enabled = true;

                // The selected loan is returned - disable return button
                else if (_selectedMemberLoan != null && _selectedMemberLoan.TimeOfReturn != null)
                    btn_Members_ReturnLoan.Enabled = false;

                // No loan selected
                else
                    btn_Members_ReturnLoan.Enabled = false;
            }
            else
            {
                _selectedMemberLoan = null;

                btn_Members_ReturnLoan.Enabled = false;
            }
        }

        /// <summary>
        /// Update member loans gridview
        /// </summary>
        /// <param name="loans">List of member loans</param>
        private void UpdateMemberLoans(IEnumerable<Loan> loans)
        {
            grd_Members_Loans.Rows.Clear();

            foreach (Loan loan in loans)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                id.Value = loan.Id;

                DataGridViewTextBoxCell title = new DataGridViewTextBoxCell();
                title.Value = loan.BookCopy.Book.Title;

                DataGridViewTextBoxCell author = new DataGridViewTextBoxCell();
                author.Value = loan.BookCopy.Book.Author.Name;

                DataGridViewTextBoxCell dueDate = new DataGridViewTextBoxCell();
                dueDate.Value = loan.DueDate.ToShortDateString();

                // Mark as red if due date has passed and the book is not returned
                if (!loan.TimeOfReturn.HasValue)
                    MarkIfPassedDueDate(dueDate, loan.DueDate);

                DataGridViewTextBoxCell timeOfReturn = new DataGridViewTextBoxCell();
                timeOfReturn.Value = loan.TimeOfReturn.HasValue ? loan.TimeOfReturn.Value.ToShortDateString() : "";

                row.Cells.AddRange(new DataGridViewCell[] { id, title, author, dueDate, timeOfReturn });

                grd_Members_Loans.Rows.Add(row);
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
            UpdateMemberLoans(_loanService.Search(member, cbx_Members_ShowReturnedLoans.Checked));
        }

        private void btn_NewMember_Click(object sender, EventArgs e)
        {
            var form = new NewMemberForm(_memberService);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                string memberName = form.NewMemberName;
                MetroMessageBox.Show(this, String.Format("{0} was successfully added to the list of members", form.NewMemberName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btn_Members_MakeLoan_Click(object sender, EventArgs e)
        {
            if (_selectedMember != null)
            {
                var form = new NewLoanForm(_bookService, _bookCopyService, _memberService, _loanService, _selectedMember);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    MetroMessageBox.Show(this, String.Format("A loan of {0} was successfully made for {1}", form.BookTitle, form.MemberName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void btn_Members_ReturnLoan_Click(object sender, EventArgs e)
        {
            if (_selectedMemberLoan != null)
            {
                try
                {
                    double fee;
                    string bookTitle = _selectedMemberLoan.BookCopy.Book.Title;
                    string memberName = _selectedMemberLoan.Member.Name;

                    _loanService.Return(_selectedMemberLoan, out fee);

                    if (fee > 0)
                        MetroMessageBox.Show(this, String.Format("{0} was returned past its due date and {1} has to pay a {2} SEK fee", bookTitle, memberName, fee.ToString()), "Fee required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MetroMessageBox.Show(this, String.Format("{0} was successfully returned", bookTitle), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (InvalidOperationException error)
                {
                    MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _memberService_Updated(object sender, EventArgs e)
        {
            IEnumerable<Member> members = _memberService.Search(txt_MemberSearch.Text, cbx_MembersWithActiveLoans.Checked);
            UpdateMembers(members);
        }


//-------------------------------------------MEMBERS TAB END-----------------------------------------------------//


//-------------------------------------------LOANS TAB START-----------------------------------------------------//

        
        /// <summary>
        /// Update loans gridview
        /// </summary>
        /// <param name="loans">List of loans</param>
        private void UpdateLoans(IEnumerable<Loan> loans)
        {
            grd_Loans.Rows.Clear();

            foreach (Loan loan in loans)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                id.Value = loan.Id;

                DataGridViewTextBoxCell copyId = new DataGridViewTextBoxCell();
                copyId.Value = loan.BookCopy.Id;

                DataGridViewTextBoxCell member = new DataGridViewTextBoxCell();
                member.Value = loan.Member.Name;

                DataGridViewTextBoxCell title = new DataGridViewTextBoxCell();
                title.Value = loan.BookCopy.Book.Title;

                DataGridViewTextBoxCell author = new DataGridViewTextBoxCell();
                author.Value = loan.BookCopy.Book.Author.Name;

                DataGridViewTextBoxCell dueDate = new DataGridViewTextBoxCell();
                dueDate.Value = loan.DueDate.ToShortDateString();

                // Mark as red if due date has passed and the book is not returned
                if (!loan.TimeOfReturn.HasValue)
                    MarkIfPassedDueDate(dueDate, loan.DueDate);

                DataGridViewTextBoxCell timeOfReturn = new DataGridViewTextBoxCell();
                timeOfReturn.Value = loan.TimeOfReturn.HasValue ? loan.TimeOfReturn.Value.ToShortDateString() : "";

                row.Cells.AddRange(new DataGridViewCell[] { id, copyId, member, title, author, dueDate, timeOfReturn });

                grd_Loans.Rows.Add(row);
            }
        }

        private void btn_Loans_MakeLoan_Click(object sender, EventArgs e)
        {
            var form = new NewLoanForm(_bookService, _bookCopyService, _memberService, _loanService);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                MetroMessageBox.Show(this, String.Format("A loan of {0} was successfully made for {1}", form.BookTitle, form.MemberName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btn_Loans_ReturnLoan_Click(object sender, EventArgs e)
        {
            if (_selectedLoan != null)
            {
                try
                {
                    double fee;
                    string bookTitle = _selectedLoan.BookCopy.Book.Title;
                    string memberName = _selectedLoan.Member.Name;

                    _loanService.Return(_selectedLoan, out fee);

                    if (fee > 0)
                        MetroMessageBox.Show(this, String.Format("{0} was returned past its due date and {1} has to pay a {2} SEK fee", bookTitle, memberName, fee.ToString()), "Fee required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MetroMessageBox.Show(this, String.Format("{0} was successfully returned", bookTitle), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                catch (InvalidOperationException error)
                {
                    MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbx_Loans_ShowReturnedLoans_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLoans(_loanService.Search(null, cbx_Loans_ShowReturnedLoans.Checked));
        }

        private void _loanService_Updated(object sender, EventArgs e)
        {
            UpdateLoans(_loanService.Search(null, cbx_Loans_ShowReturnedLoans.Checked));
        }

        private void grd_Loans_SelectionChanged(object sender, EventArgs e)
        {
            // Enable/disable buttons depending on selected row
            if (grd_Loans.SelectedRows.Count > 0)
            {
                _selectedLoan = GetSelectedLoan();

                // The selected loan is active and not returned yet - enable return button
                if (_selectedLoan != null && _selectedLoan.TimeOfReturn == null)
                    btn_Loans_ReturnLoan.Enabled = true;

                // The selected loan is returned - disable return button
                else if (_selectedLoan != null && _selectedLoan.TimeOfReturn != null)
                    btn_Loans_ReturnLoan.Enabled = false;

                // No loan selected
                else
                    btn_Loans_ReturnLoan.Enabled = false;
            }
            else
            {
                _selectedLoan = null;

                btn_Loans_ReturnLoan.Enabled = false;
            }
        }

        private Loan GetSelectedLoan()
        {
            DataGridViewRow row = grd_Loans.SelectedRows[0];
            return _loanService.Find((int)row.Cells[0].Value);
        }
    }
}
