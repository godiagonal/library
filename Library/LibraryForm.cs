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
        BookCopyService _bookCopyService;
        Book _selectedBook;
        BookCopy _selectedBookCopy;

        public LibraryForm()
        {
            InitializeComponent();

            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookCopyService = new BookCopyService(repoFactory);
            _bookService = new BookService(repoFactory);
            _authorService = new AuthorService(repoFactory);

            _bookService.Updated += _bookService_Updated;
            _bookCopyService.Updated += _bookService_Updated;

            UpdateBooks(_bookService.All());
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
                    btn_MakeLoan.Enabled = false;
                    btn_ReturnLoan.Enabled = true;
                }

                // Book available
                else if (_selectedBookCopy != null)
                {
                    btn_MakeLoan.Enabled = true;
                    btn_ReturnLoan.Enabled = false;
                }

                // No book
                else
                {
                    btn_MakeLoan.Enabled = false;
                    btn_ReturnLoan.Enabled = false;
                }
            }
            else
            {
                _selectedBookCopy = null;

                btn_MakeLoan.Enabled = false;
                btn_ReturnLoan.Enabled = false;
            }
        }

        private BookCopy GetSelectedBookCopy()
        {
            DataGridViewRow row = grd_BookCopies.SelectedRows[0];
            return _bookCopyService.Find((int)row.Cells[0].Value);
        }

        private void btn_ReturnLoan_Click(object sender, EventArgs e)
        {
            if (_selectedBookCopy != null)
            {

            }
        }

        private void btn_MakeLoan_Click(object sender, EventArgs e)
        {
            if (_selectedBookCopy != null)
            {
                
            }
        }
    }
}
