// The library
// Samuel Johansson och Lukas Peterson
// Version 1.0 2015-10-26

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
        Book _selectedBook;

        public string BookTitle { get; private set; }
        public string MemberName { get; private set; }

        public NewLoanForm(BookService bookService, BookCopyService bookCopyService, MemberService memberService, LoanService loanService)
        {
            InitializeComponent();

            _bookService = bookService;
            _bookCopyService = bookCopyService;
            _memberService = memberService;
            _loanService = loanService;

            // Keep comboboxes updated
            _bookService.Updated += _bookService_Updated;
            _bookCopyService.Updated += _bookService_Updated;
            _memberService.Updated += _memberService_Updated;

            _bookService_Updated(this, new EventArgs());
            _memberService_Updated(this, new EventArgs());
        }

        /// <summary>
        /// Different ways to enter the NewLoanForm, either from the Member view, with the member as predetermined value or
        /// with the selected book and bookcopy as predetermined values, from the Books view.
        /// </summary>
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

        /// <summary>
        /// Set the predetermined values on book and bookcopy 
        /// </summary>
        /// <param name="bookCopy"></param>
        private void SetSelectedBookAndCopy(BookCopy bookCopy)
        {
            if (bookCopy != null)
            {
                cbx_Books.SelectedItem = bookCopy.Book;
                cbx_BookCopies.SelectedItem = bookCopy;
            }
        }

        /// <summary>
        /// Set the predetermined value on member 
        /// </summary>
        /// <param name="member"></param>
        private void SetSelectedMember(Member member)
        {
            if (member != null)
            {
                cbx_Members.SelectedItem = member;
            }
        }

        /// <summary>
        /// Update the content of book combobox and update the selected item  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _bookService_Updated(object sender, EventArgs e)
        {
            Book prevSelectedBook = (Book)cbx_Books.SelectedItem;

            cbx_Books.Items.Clear();
            cbx_Books.Items.AddRange(_bookService.All().ToArray());

            if (prevSelectedBook != null && cbx_Books.Items.Contains(prevSelectedBook))
                cbx_Books.SelectedItem = prevSelectedBook;
        }

        /// <summary>
        /// Update the content of member combobox and update the selected item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _memberService_Updated(object sender, EventArgs e)
        {
            Member prevSelectedMember = (Member)cbx_Members.SelectedItem;

            //If no members qualify for loan
            cbx_Members.Items.Clear();
            cbx_Members.Text = "No members that qualify for loan";
            cbx_Members.Enabled = false;

            //Calculate the members that qualify for loan
            List<Member> members = MembersThatQualifyForLoan(_selectedBook);

            if (members.Count() > 0)
            {
                cbx_Members.Items.AddRange(members.ToArray());
                cbx_Members.Text = "";
                cbx_Members.Enabled = true;
            }

            //Select the member that was chosen before the update
            if (prevSelectedMember != null && cbx_Members.Items.Contains(prevSelectedMember))
                cbx_Members.SelectedItem = prevSelectedMember;
            else if (prevSelectedMember != null)
                MetroMessageBox.Show(this, "The previously selected member does not qualify for loan because he or she is already borrowing a copy of this book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Update the bookCopies combobox with content that match the selected book
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedBook = (Book)cbx_Books.SelectedItem;

            cbx_BookCopies.Items.Clear();
            cbx_BookCopies.Text = "No copies available";
            cbx_BookCopies.Enabled = false;

            if (_selectedBook != null && _selectedBook.AvailableBookCopies.Count() > 0)
            {
                List<BookCopy> availableBooks = _selectedBook.AvailableBookCopies;

                cbx_BookCopies.Items.AddRange(availableBooks.ToArray());
                cbx_BookCopies.Enabled = true;

                // Choose first copy by default
                if (cbx_BookCopies.Items.Count > 0)
                    cbx_BookCopies.SelectedIndex = 0;
            }

            //Update member combobox, with members that have no active loans on this book
            _memberService_Updated(this, new EventArgs());
        }

        /// <summary>
        /// Method to list members that are allowed to borrow a specific book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        private List<Member> MembersThatQualifyForLoan(Book book)
        {
            IEnumerable<Member> membersWithActiveLoans = _loanService.All().Where(l => l.BookCopy.Book == book && l.Member.ActiveLoans.Count() > 0).Select(m => m.Member);
            return _memberService.All().Except(membersWithActiveLoans).ToList();
        }

        /// <summary>
        /// Open a new dialog to add a new member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Save the loan and close the NewLoanForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                // Remove event handlers to avoid event execution after the form is closed
                UnsubscribeEvents();

                this.Close();
            }
            catch (ValidationException error)
            {
                MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnsubscribeEvents()
        {
            _bookService.Updated -= _bookService_Updated;
            _bookCopyService.Updated -= _bookService_Updated;
            _memberService.Updated -= _memberService_Updated;
        }

        /// <summary>
        /// Listen to enter key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveLoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_SaveLoan_Click(sender, e);
        }
    }
}
