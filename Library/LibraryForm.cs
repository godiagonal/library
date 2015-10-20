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

        public LibraryForm()
        {
            InitializeComponent();

            RepositoryFactory repoFactory = new RepositoryFactory();

            _bookService = new BookService(repoFactory);

            ListAllBooks();
        }

        private void ListAllBooks()
        {
            UpdateBooks(_bookService.All());

            return;

            foreach (Book book in _bookService.All())
            {
                grd_Books.Rows.Add(
                    book.Id,
                    book.Title,
                    book.Author == null ? "" : book.Author.Name
                );
            }
        }

        private void grd_Books_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = ((DataGridView)sender).SelectedRows[0];
            Book book = _bookService.Find((int)row.Cells[0].Value);

            lbl_BookTitle.Text = book.Title;
            lbl_BookId.Text = book.Id.ToString();
            lbl_BookISBN.Text = book.ISBN;
            txt_BookDescription.Text = book.Description;
            
            UpdateBookCopies(book.BookCopies);

            pnl_SelectedBook.Visible = true;
        }

        private void UpdateBooks(IEnumerable<Book> books)
        {
            grd_Books.Rows.Clear();

            foreach (Book book in books)
            {
                Bitmap availableIcon;

                if (book.BookCopies.Count > 0)
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
        }

        private void UpdateBookCopies(IEnumerable<BookCopy> bookCopies)
        {
            grd_BookCopies.Rows.Clear();

            foreach (BookCopy bookCopy in bookCopies)
            {
                /*Bitmap availableIcon;

                if (bookCopy.Loans..BookCopies.Count > 0)
                    availableIcon = new Bitmap(global::Library.Properties.Resources.icon_check, 20, 20);
                else
                    availableIcon = new Bitmap(global::Library.Properties.Resources.icon_cross, 18, 18);
                    */

                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell id = new DataGridViewTextBoxCell();
                id.Value = bookCopy.Id;

                DataGridViewImageCell available = new DataGridViewImageCell();
                available.Value = new Bitmap(global::Library.Properties.Resources.icon_check, 20, 20);

                /*DataGridViewTextBoxCell member = new DataGridViewTextBoxCell();
                member.Value = bookCopy.L;

                DataGridViewTextBoxCell author = new DataGridViewTextBoxCell();
                author.Value = book.Author == null ? "" : book.Author.Name;*/

                row.Cells.AddRange(new DataGridViewCell[] { id, available });

                grd_BookCopies.Rows.Add(row);
            }
        }
    }
}
