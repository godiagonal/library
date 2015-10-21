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

        public NewBookForm(BookService bookService)
        {
            InitializeComponent();

            _bookService = bookService;
        }

        private void btn_NewAuthor_Click(object sender, EventArgs e)
        {
            DialogForm form = new DialogForm("New author", "What's the name of the author?");

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // Spara författare här
                MessageBox.Show("ok " + form.Answer);
            }
            else
            {

                MessageBox.Show("not ok");
            }
        }

        private void btn_SaveBook_Click(object sender, EventArgs e)
        {
            // Spara bok här

            this.Close();
        }
    }
}
