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

namespace Library
{
    public partial class DialogForm : MetroFramework.Forms.MetroForm
    {
        public string Answer { get; private set; }

        public DialogForm(string title, string question)
        {
            InitializeComponent();

            this.Text = title;
            this.lbl_question.Text = question;
        }

        public DialogForm(string title, string question, string acceptButtonText, string cancelButtonText)
            : this(title, question)
        {
            this.btn_Accept.Text = acceptButtonText;
            this.btn_Cancel.Text = cancelButtonText;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            this.Answer = txt_answer.Text;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
