using Library.Helpers;
using Library.Models;
using Library.Services;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class NewLoanForm : MetroFramework.Forms.MetroForm
    {
        BookService _bookService;
        BookCopyService _bookCopyService;
        MemberService _memberService;
        LoanService _loanService;

        public string BookTitle { get; private set; }
        public string MemberName { get; private set; }

        public NewLoanForm(BookService bookService, BookCopyService bookCopyService, MemberService memberService, LoanService loanService)
        {
            // Borde lägga till prevSelectedBook osv för att hantera återval efter uppdatering av listor!!!!
            InitializeComponent();

            _bookService = bookService;
            _bookCopyService = bookCopyService;
            _memberService = memberService;
            _loanService = loanService;

            _bookService.Updated += _bookService_Updated;
            _bookCopyService.Updated += _bookService_Updated;
            _loanService.Updated += _bookService_Updated;
            _memberService.Updated += _memberService_Updated;

            _bookService_Updated(this, new EventArgs());
            _memberService_Updated(this, new EventArgs());
        }

        public NewLoanForm(BookService bookService, BookCopyService bookCopyService, MemberService memberService, LoanService loanService, BookCopy selectedBookCopy)
            : this(bookService, bookCopyService, memberService, loanService)
        {
            SetSelectedBookAndCopy(selectedBookCopy);
        }

        public NewLoanForm(BookService bookService, BookCopyService bookCopyService, MemberService memberService, LoanService loanService, Member selectedMember)
            : this(bookService, bookCopyService, memberService, loanService)
        {
            SetSelectedMember(selectedMember);
        }

        private void SetSelectedBookAndCopy(BookCopy bookCopy)
        {
            if (bookCopy != null)
            {
                cbx_Books.SelectedItem = bookCopy.Book;
                cbx_BookCopies.SelectedItem = bookCopy;
            }
        }

        private void SetSelectedMember(Member member)
        {
            if (member != null)
            {
                cbx_Members.SelectedItem = member;
            }
        }

        private void _bookService_Updated(object sender, EventArgs e)
        {
            cbx_Books.Items.Clear();

            foreach (Book b in _bookService.All())
            {
                cbx_Books.Items.Add(b);
            }
        }

        void _memberService_Updated(object sender, EventArgs e)
        {
            cbx_Members.Items.Clear();

            foreach (Member m in _memberService.All())
            {
                cbx_Members.Items.Add(m);
            }
        }

        private void cbx_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book book = (Book)cbx_Books.SelectedItem;

            cbx_BookCopies.Items.Clear();
            cbx_BookCopies.Text = "No copies available";
            cbx_BookCopies.Enabled = false;


            if (book != null && book.Available)
            {
                List<BookCopy> availableBooks = book.BookCopies.Where(b => b.CurrentLoan == null).ToList();

                cbx_BookCopies.Items.AddRange(availableBooks.ToArray());
                cbx_BookCopies.Enabled = true;

                // Choose first copy by default
                if (cbx_BookCopies.Items.Count > 0)
                    cbx_BookCopies.SelectedIndex = 0;

                //Update member combobox, with members that have no active loans on this book
                cbx_Members.Items.Clear();
                cbx_Members.Enabled = false;
                cbx_Members.Text = "No members that qualify for loan";

                IEnumerable<Member> membersWithActiveLoans = _loanService.All().Where(l => l.BookCopy.Book == book && l.Member.HasActiveLoans).Select(m => m.Member);
                IEnumerable<Member> membersToCbx = _memberService.All().Except(membersWithActiveLoans);
                if(membersToCbx.Count() > 0)
                {
                    cbx_Members.Items.AddRange(membersToCbx.ToArray());
                    cbx_Members.Enabled = true;
                }
            }
            else if (!book.Available)
            {
                cbx_Members.Text = "";
                cbx_Members.Items.AddRange(_memberService.All().ToArray());
                cbx_Members.Enabled = true;
            }
        }

        private void btn_NewMember_Click(object sender, EventArgs e)
        {
            var form = new NewMemberForm(_memberService);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                string memberName = form.NewMemberName;
                MetroMessageBox.Show(this, String.Format("{0} was successfully added to the list of members", form.NewMemberName), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                cbx_Members.Text = form.NewMemberName;
            }
        }

        private void btn_SaveLoan_Click(object sender, EventArgs e)
        {
            Member member = (Member)cbx_Members.SelectedItem;
            BookCopy bookCopy = (BookCopy)cbx_BookCopies.SelectedItem;

            try
            {
                _loanService.Add(member, bookCopy, cbx_SubtractDays.Checked);
                this.BookTitle = bookCopy.ToString();
                this.MemberName = member.Name;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ValidationException error)
            {
                MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_Members_SelectedIndexChanged(object sender, EventArgs e)
        {
            Member member = (Member)cbx_Members.SelectedItem;

            cbx_Books.Items.Clear();
            cbx_Books.Text = "No books available for this member";
            cbx_Books.Enabled = false;

            if (member != null)
            {
                IEnumerable<Book> activeBooks = _loanService.All().Where(l => l.Member.Id == member.Id && l.TimeOfReturn == null).Select(l => l.BookCopy.Book);
                IEnumerable<Book> availableBooksForMember = _bookService.All().Except(activeBooks);
                if (availableBooksForMember.Count() > 0)
                {
                    cbx_Books.Items.AddRange(availableBooksForMember.ToArray());
                    cbx_Books.Enabled = true;
                }

                // Choose first copy by default
                if (cbx_Books.Items.Count > 0)
                    cbx_Books.SelectedIndex = 0;
            }
        }
    }
}
