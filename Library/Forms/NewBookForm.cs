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
    public partial class NewBookForm : MetroFramework.Forms.MetroForm
    {
        BookService _bookService;
        AuthorService _authorService;
        public string NewBookTitle { get; private set; }

        public NewBookForm(BookService bookService, AuthorService authorService)
        {
            InitializeComponent();

            _authorService = authorService;
            _bookService = bookService;

            // Keep combobox updated
            _authorService.Updated += _authorService_Updated;
            _authorService_Updated(this, new EventArgs());

            for (int i = 1; i < 11; i++)
            {
                cbx_NoOfCopies.Items.Add(i);
            }

            cbx_NoOfCopies.SelectedIndex = 0;
        }

        /// <summary>
        /// Keep the author combobox updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _authorService_Updated(object sender, EventArgs e)
        {
            Author prevSelectedAuthor = (Author)cbx_BookAuthors.SelectedItem;

            cbx_BookAuthors.Items.Clear();
            cbx_BookAuthors.Items.AddRange(_authorService.All().ToArray());

            if (prevSelectedAuthor != null && cbx_BookAuthors.Items.Contains(prevSelectedAuthor))
                cbx_BookAuthors.SelectedItem = prevSelectedAuthor;
        }

        /// <summary>
        /// Open up a new dialog to add a new author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_NewAuthor_Click(object sender, EventArgs e)
        {
            DialogForm form = new DialogForm("New author", "What's the name of the author?");
        
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                //Format input so its comparable
                string formattedAnswer = Formatting.UppercaseWords(form.Answer).Trim();

                try 
                {
                    _authorService.Add(formattedAnswer);
                    MetroMessageBox.Show(this, String.Format("{0} was successfully added to the list of authors", formattedAnswer), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    cbx_BookAuthors.Text = formattedAnswer;
                }
                catch (ValidationException error)
                {
                    MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Save the book and close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            Author author = (Author)cbx_BookAuthors.SelectedItem;

            try
            {
                _bookService.Add(txt_BookTitle.Text.Trim(), txt_BookDescription.Text.Trim(), txt_BookISBN.Text.Trim(), author, (int)cbx_NoOfCopies.SelectedItem);
                this.NewBookTitle = txt_BookTitle.Text;
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

        /// <summary>
        /// Listen to enter key down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SaveBook_Click(sender, e);
            }
        }

        private void UnsubscribeEvents()
        {
            _authorService.Updated -= _authorService_Updated;
        }
    }
}
