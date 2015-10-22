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
            _authorService_Updated(this, new EventArgs());
            _authorService.Updated += _authorService_Updated;

            for (int i = 1; i < 11; i++)
            {
                cbx_NoOfCopies.Items.Add(i);
            }
            cbx_NoOfCopies.SelectedIndex = 0;
        }

        void _authorService_Updated(object sender, EventArgs e)
        {
            cbx_BookAuthor.Items.Clear();
            foreach (Author a in _authorService.All())
            {
                cbx_BookAuthor.Items.Add(a);
            }
        }

        private void btn_NewAuthor_Click(object sender, EventArgs e)
        {
            DialogForm form = new DialogForm("New author", "What's the name of the author?");
        
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                string formattedAnswer = Formatting.UppercaseWords(form.Answer).Trim();

                try 
                {
                    _authorService.Add(formattedAnswer);
                    MetroMessageBox.Show(this, string.Format("{0} was successfully added to the list of authors", formattedAnswer), "Success", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    cbx_BookAuthor.Text = formattedAnswer;
                }
                catch(ValidationException error)
                {
                    MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            Author author = (Author)cbx_BookAuthor.SelectedItem;

            try
            {
                _bookService.Add(txt_BookTitle.Text.Trim(), txt_BookDescription.Text.Trim(), txt_BookISBN.Text.Trim(), author, (int)cbx_NoOfCopies.SelectedItem);
                this.NewBookTitle = txt_BookTitle.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ValidationException error)
            {
                MetroMessageBox.Show(this, error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void cbx_BookAuthor_TextChanged(object sender, EventArgs e)
        //{
        //    var a = _authorService.Search(cbx_BookAuthor.Text).ToArray();
        //    cbx_BookAuthor.Items.Clear();
        //    cbx_BookAuthor.Items.AddRange(a);

        //    if (cbx_BookAuthor.Text.Length == 0) overrideSuggestAndAppend();
        //}
        //
        //private void cbx_BookAuthor_KeyUp(object sender, KeyEventArgs e)
        //{

        //}
        //Override suggest append so it's searching, using contains instead och startsWith
        //private void overridesuggestandappend()
        //{
        //    cbx_bookauthor.droppeddown = true;

        //    object[] originallist = (object[])cbx_bookauthor.tag;
        //    if (originallist == null)
        //    {
        //        // backup original list
        //        originallist = new object[cbx_bookauthor.items.count];
        //        cbx_bookauthor.items.copyto(originallist, 0);
        //        cbx_bookauthor.tag = originallist;
        //    }

        //    // prepare list of matching items
        //    string s = cbx_bookauthor.text.tolower();
        //    ienumerable<object> newlist = originallist;
        //    if (s.length > 0)
        //    {
        //        newlist = originallist.where(item => item.tostring().tolower().contains(s));
        //    }

        //    // clear list (loop through it, otherwise the cursor would move to the beginning of the textbox...)
        //    while (cbx_bookauthor.items.count > 0)
        //    {
        //        cbx_bookauthor.items.removeat(0);
        //    }

        //    // re-set list
        //    cbx_bookauthor.items.addrange(newlist.toarray());
        //}


    }
}
