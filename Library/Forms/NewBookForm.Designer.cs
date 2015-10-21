namespace Library
{
    partial class NewBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_BookTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_BookISBN = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbx_BookAuthor = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_NewAuthor = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_BookDescription = new MetroFramework.Controls.MetroTextBox();
            this.btn_SaveBook = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_BookTitle
            // 
            this.txt_BookTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txt_BookTitle.CustomButton.Image = null;
            this.txt_BookTitle.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txt_BookTitle.CustomButton.Name = "";
            this.txt_BookTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_BookTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_BookTitle.CustomButton.TabIndex = 1;
            this.txt_BookTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BookTitle.CustomButton.UseSelectable = true;
            this.txt_BookTitle.CustomButton.Visible = false;
            this.txt_BookTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_BookTitle.Lines = new string[0];
            this.txt_BookTitle.Location = new System.Drawing.Point(25, 91);
            this.txt_BookTitle.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.txt_BookTitle.MaxLength = 32767;
            this.txt_BookTitle.Name = "txt_BookTitle";
            this.txt_BookTitle.PasswordChar = '\0';
            this.txt_BookTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BookTitle.SelectedText = "";
            this.txt_BookTitle.SelectionLength = 0;
            this.txt_BookTitle.SelectionStart = 0;
            this.txt_BookTitle.Size = new System.Drawing.Size(250, 26);
            this.txt_BookTitle.TabIndex = 5;
            this.txt_BookTitle.UseSelectable = true;
            this.txt_BookTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_BookTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(25, 67);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(34, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Title";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 132);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "ISBN";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txt_BookISBN
            // 
            this.txt_BookISBN.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txt_BookISBN.CustomButton.Image = null;
            this.txt_BookISBN.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txt_BookISBN.CustomButton.Name = "";
            this.txt_BookISBN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_BookISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_BookISBN.CustomButton.TabIndex = 1;
            this.txt_BookISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BookISBN.CustomButton.UseSelectable = true;
            this.txt_BookISBN.CustomButton.Visible = false;
            this.txt_BookISBN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_BookISBN.Lines = new string[0];
            this.txt_BookISBN.Location = new System.Drawing.Point(25, 156);
            this.txt_BookISBN.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.txt_BookISBN.MaxLength = 32767;
            this.txt_BookISBN.Name = "txt_BookISBN";
            this.txt_BookISBN.PasswordChar = '\0';
            this.txt_BookISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BookISBN.SelectedText = "";
            this.txt_BookISBN.SelectionLength = 0;
            this.txt_BookISBN.SelectionStart = 0;
            this.txt_BookISBN.Size = new System.Drawing.Size(250, 26);
            this.txt_BookISBN.TabIndex = 7;
            this.txt_BookISBN.UseSelectable = true;
            this.txt_BookISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_BookISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(25, 197);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Author";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // cbx_BookAuthor
            // 
            this.cbx_BookAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_BookAuthor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_BookAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_BookAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_BookAuthor.FormattingEnabled = true;
            this.cbx_BookAuthor.Location = new System.Drawing.Point(1, 1);
            this.cbx_BookAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_BookAuthor.Name = "cbx_BookAuthor";
            this.cbx_BookAuthor.Size = new System.Drawing.Size(248, 25);
            this.cbx_BookAuthor.TabIndex = 15;
            this.cbx_BookAuthor.TextChanged += new System.EventHandler(this.cbx_BookAuthor_TextChanged);
            this.cbx_BookAuthor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbx_BookAuthor_KeyUp);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.metroPanel1.Controls.Add(this.cbx_BookAuthor);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(25, 221);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(250, 27);
            this.metroPanel1.TabIndex = 16;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_NewAuthor
            // 
            this.btn_NewAuthor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_NewAuthor.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_NewAuthor.Location = new System.Drawing.Point(148, 263);
            this.btn_NewAuthor.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_NewAuthor.Name = "btn_NewAuthor";
            this.btn_NewAuthor.Size = new System.Drawing.Size(126, 30);
            this.btn_NewAuthor.TabIndex = 18;
            this.btn_NewAuthor.Text = "Add new author";
            this.btn_NewAuthor.UseSelectable = true;
            this.btn_NewAuthor.Click += new System.EventHandler(this.btn_NewAuthor_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(25, 308);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Description";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // txt_BookDescription
            // 
            this.txt_BookDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txt_BookDescription.CustomButton.Image = null;
            this.txt_BookDescription.CustomButton.Location = new System.Drawing.Point(134, 2);
            this.txt_BookDescription.CustomButton.Name = "";
            this.txt_BookDescription.CustomButton.Size = new System.Drawing.Size(113, 113);
            this.txt_BookDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_BookDescription.CustomButton.TabIndex = 1;
            this.txt_BookDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BookDescription.CustomButton.UseSelectable = true;
            this.txt_BookDescription.CustomButton.Visible = false;
            this.txt_BookDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_BookDescription.Lines = new string[0];
            this.txt_BookDescription.Location = new System.Drawing.Point(25, 332);
            this.txt_BookDescription.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.txt_BookDescription.MaxLength = 300;
            this.txt_BookDescription.Multiline = true;
            this.txt_BookDescription.Name = "txt_BookDescription";
            this.txt_BookDescription.PasswordChar = '\0';
            this.txt_BookDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BookDescription.SelectedText = "";
            this.txt_BookDescription.SelectionLength = 0;
            this.txt_BookDescription.SelectionStart = 0;
            this.txt_BookDescription.Size = new System.Drawing.Size(250, 118);
            this.txt_BookDescription.TabIndex = 19;
            this.txt_BookDescription.UseSelectable = true;
            this.txt_BookDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_BookDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_SaveBook
            // 
            this.btn_SaveBook.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_SaveBook.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_SaveBook.Location = new System.Drawing.Point(25, 465);
            this.btn_SaveBook.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_SaveBook.Name = "btn_SaveBook";
            this.btn_SaveBook.Size = new System.Drawing.Size(249, 30);
            this.btn_SaveBook.TabIndex = 21;
            this.btn_SaveBook.Text = "Save book";
            this.btn_SaveBook.UseSelectable = true;
            this.btn_SaveBook.Click += new System.EventHandler(this.btn_SaveBook_Click);
            // 
            // NewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 524);
            this.Controls.Add(this.btn_SaveBook);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txt_BookDescription);
            this.Controls.Add(this.btn_NewAuthor);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_BookISBN);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txt_BookTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewBookForm";
            this.Padding = new System.Windows.Forms.Padding(25, 60, 25, 25);
            this.Resizable = false;
            this.Text = "New Book";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_BookTitle;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_BookISBN;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cbx_BookAuthor;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_NewAuthor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_BookDescription;
        private MetroFramework.Controls.MetroButton btn_SaveBook;
    }
}