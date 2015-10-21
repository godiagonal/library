using Library.Services;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public NewBookForm(BookService bookService, AuthorService authorService)
        {
            InitializeComponent();
            _authorService = authorService;
            _bookService = bookService;
            cbx_BookAuthor_UpdateCollection();
        }

        //Snyggare att uppdatera med events?
        private void cbx_BookAuthor_UpdateCollection()
        {
            cbx_BookAuthor.Items.Clear();
            cbx_BookAuthor.Items.AddRange(_authorService.All().ToArray());
        }

        private void btn_NewAuthor_Click(object sender, EventArgs e)
        {
            DialogForm form = new DialogForm("New author", "What's the name of the author?");
            
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                _authorService.Add(form.Answer);
                cbx_BookAuthor_UpdateCollection();
                cbx_BookAuthor.Text = form.Answer;
            }
            else
            {
                MessageBox.Show("not ok");
            }
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            // Spara bok här
            //Selected items 
            var authorInList = cbx_BookAuthor.SelectedItem.ToString();
            var author = _authorService.All().Where(a => a.Name == authorInList);
            if (author.Count() > 0) 
            { 
                var ab = author.First();
                _bookService.Add(txt_BookTitle.Text, txt_BookDescription.Text, txt_BookDescription.Text, ab);
            }
            this.Close();
        }

        private void cbx_BookAuthor_TextChanged(object sender, EventArgs e)
        {
           //var a = _authorService.Search(cbx_BookAuthor.Text).ToArray();
           //cbx_BookAuthor.Items.Clear();
           //cbx_BookAuthor.Items.AddRange(a);
           //
           if (cbx_BookAuthor.Text.Length == 0) overrideSuggestAndAppend();
        }
        //
        private void cbx_BookAuthor_KeyUp(object sender, KeyEventArgs e)
        {
            overrideSuggestAndAppend();
        }
        //Override suggest append so it's searching, using contains instead och startsWith
        private void overrideSuggestAndAppend()
        {
            cbx_BookAuthor.DroppedDown = true;

            object[] originalList = (object[])cbx_BookAuthor.Tag;
            if (originalList == null)
            {
                // backup original list
                originalList = new object[cbx_BookAuthor.Items.Count];
                cbx_BookAuthor.Items.CopyTo(originalList, 0);
                cbx_BookAuthor.Tag = originalList;
            }

            // prepare list of matching items
            string s = cbx_BookAuthor.Text.ToLower();
            IEnumerable<object> newList = originalList;
            if (s.Length > 0)
            {
                newList = originalList.Where(item => item.ToString().ToLower().Contains(s));
            }

            // clear list (loop through it, otherwise the cursor would move to the beginning of the textbox...)
            while (cbx_BookAuthor.Items.Count > 0)
            {
                cbx_BookAuthor.Items.RemoveAt(0);
            }

            // re-set list
            cbx_BookAuthor.Items.AddRange(newList.ToArray());
        }


    }
}
