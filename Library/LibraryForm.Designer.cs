using System.Windows.Forms;

namespace Library
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbc_Main = new MetroFramework.Controls.MetroTabControl();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.pnl_Books = new MetroFramework.Controls.MetroPanel();
            this.btn_NewAuthor = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btn_NewBook = new MetroFramework.Controls.MetroButton();
            this.pnl_SelectedBook = new MetroFramework.Controls.MetroPanel();
            this.txt_BookDescription = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_BookISBN = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_BookId = new MetroFramework.Controls.MetroLabel();
            this.lbl_BookTitle = new MetroFramework.Controls.MetroLabel();
            this.txt_BookSearch = new MetroFramework.Controls.MetroTextBox();
            this.grd_Books = new MetroFramework.Controls.MetroGrid();
            this.tab_Members = new System.Windows.Forms.TabPage();
            this.pnl_Members = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tab_Loans = new System.Windows.Forms.TabPage();
            this.pnl_Loans = new MetroFramework.Controls.MetroPanel();
            this.grd_BookCopies = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btn_MakeLoan = new MetroFramework.Controls.MetroButton();
            this.btn_AddCopy = new MetroFramework.Controls.MetroButton();
            this.btn_ReturnLoan = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.books_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_Available = new System.Windows.Forms.DataGridViewImageColumn();
            this.books_Blank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopies_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopies_Available = new System.Windows.Forms.DataGridViewImageColumn();
            this.bookCopies_Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopies_DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbc_Main.SuspendLayout();
            this.tab_Books.SuspendLayout();
            this.pnl_Books.SuspendLayout();
            this.pnl_SelectedBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Books)).BeginInit();
            this.tab_Members.SuspendLayout();
            this.pnl_Members.SuspendLayout();
            this.tab_Loans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BookCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_Main
            // 
            this.tbc_Main.Controls.Add(this.tab_Books);
            this.tbc_Main.Controls.Add(this.tab_Members);
            this.tbc_Main.Controls.Add(this.tab_Loans);
            this.tbc_Main.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tbc_Main.ItemSize = new System.Drawing.Size(100, 34);
            this.tbc_Main.Location = new System.Drawing.Point(23, 63);
            this.tbc_Main.Name = "tbc_Main";
            this.tbc_Main.SelectedIndex = 0;
            this.tbc_Main.Size = new System.Drawing.Size(829, 557);
            this.tbc_Main.TabIndex = 2;
            this.tbc_Main.UseSelectable = true;
            // 
            // tab_Books
            // 
            this.tab_Books.BackColor = System.Drawing.Color.Transparent;
            this.tab_Books.Controls.Add(this.pnl_Books);
            this.tab_Books.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Books.Location = new System.Drawing.Point(4, 38);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Size = new System.Drawing.Size(821, 515);
            this.tab_Books.TabIndex = 0;
            this.tab_Books.Text = "Books";
            // 
            // pnl_Books
            // 
            this.pnl_Books.Controls.Add(this.metroPanel2);
            this.pnl_Books.Controls.Add(this.btn_NewAuthor);
            this.pnl_Books.Controls.Add(this.btn_NewBook);
            this.pnl_Books.Controls.Add(this.pnl_SelectedBook);
            this.pnl_Books.Controls.Add(this.txt_BookSearch);
            this.pnl_Books.Controls.Add(this.grd_Books);
            this.pnl_Books.HorizontalScrollbarBarColor = true;
            this.pnl_Books.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Books.HorizontalScrollbarSize = 10;
            this.pnl_Books.Location = new System.Drawing.Point(0, 0);
            this.pnl_Books.Name = "pnl_Books";
            this.pnl_Books.Size = new System.Drawing.Size(821, 515);
            this.pnl_Books.TabIndex = 0;
            this.pnl_Books.VerticalScrollbarBarColor = true;
            this.pnl_Books.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Books.VerticalScrollbarSize = 10;
            // 
            // btn_NewAuthor
            // 
            this.btn_NewAuthor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_NewAuthor.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_NewAuthor.Location = new System.Drawing.Point(110, 465);
            this.btn_NewAuthor.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.btn_NewAuthor.Name = "btn_NewAuthor";
            this.btn_NewAuthor.Size = new System.Drawing.Size(100, 30);
            this.btn_NewAuthor.TabIndex = 8;
            this.btn_NewAuthor.Text = "New author";
            this.btn_NewAuthor.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 444);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(388, 1);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btn_NewBook
            // 
            this.btn_NewBook.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_NewBook.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_NewBook.Location = new System.Drawing.Point(0, 465);
            this.btn_NewBook.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.btn_NewBook.Name = "btn_NewBook";
            this.btn_NewBook.Size = new System.Drawing.Size(100, 30);
            this.btn_NewBook.TabIndex = 6;
            this.btn_NewBook.Text = "New book";
            this.btn_NewBook.UseSelectable = true;
            // 
            // pnl_SelectedBook
            // 
            this.pnl_SelectedBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_SelectedBook.Controls.Add(this.metroPanel3);
            this.pnl_SelectedBook.Controls.Add(this.btn_ReturnLoan);
            this.pnl_SelectedBook.Controls.Add(this.btn_AddCopy);
            this.pnl_SelectedBook.Controls.Add(this.btn_MakeLoan);
            this.pnl_SelectedBook.Controls.Add(this.metroLabel5);
            this.pnl_SelectedBook.Controls.Add(this.grd_BookCopies);
            this.pnl_SelectedBook.Controls.Add(this.txt_BookDescription);
            this.pnl_SelectedBook.Controls.Add(this.metroLabel6);
            this.pnl_SelectedBook.Controls.Add(this.lbl_BookISBN);
            this.pnl_SelectedBook.Controls.Add(this.metroLabel3);
            this.pnl_SelectedBook.Controls.Add(this.lbl_BookId);
            this.pnl_SelectedBook.Controls.Add(this.lbl_BookTitle);
            this.pnl_SelectedBook.HorizontalScrollbarBarColor = true;
            this.pnl_SelectedBook.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_SelectedBook.HorizontalScrollbarSize = 10;
            this.pnl_SelectedBook.Location = new System.Drawing.Point(411, 0);
            this.pnl_SelectedBook.Name = "pnl_SelectedBook";
            this.pnl_SelectedBook.Size = new System.Drawing.Size(410, 515);
            this.pnl_SelectedBook.TabIndex = 5;
            this.pnl_SelectedBook.UseCustomBackColor = true;
            this.pnl_SelectedBook.VerticalScrollbarBarColor = true;
            this.pnl_SelectedBook.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_SelectedBook.VerticalScrollbarSize = 10;
            this.pnl_SelectedBook.Visible = false;
            // 
            // txt_BookDescription
            // 
            this.txt_BookDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_BookDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BookDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookDescription.Location = new System.Drawing.Point(20, 178);
            this.txt_BookDescription.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.txt_BookDescription.Multiline = true;
            this.txt_BookDescription.Name = "txt_BookDescription";
            this.txt_BookDescription.ReadOnly = true;
            this.txt_BookDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_BookDescription.Size = new System.Drawing.Size(370, 88);
            this.txt_BookDescription.TabIndex = 7;
            this.txt_BookDescription.Text = resources.GetString("txt_BookDescription.Text");
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(20, 154);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "DESCRIPTION";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // lbl_BookISBN
            // 
            this.lbl_BookISBN.AutoSize = true;
            this.lbl_BookISBN.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookISBN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_BookISBN.Location = new System.Drawing.Point(20, 115);
            this.lbl_BookISBN.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.lbl_BookISBN.Name = "lbl_BookISBN";
            this.lbl_BookISBN.Size = new System.Drawing.Size(42, 19);
            this.lbl_BookISBN.TabIndex = 5;
            this.lbl_BookISBN.Text = "#isbn";
            this.lbl_BookISBN.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(20, 91);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "ISBN";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // lbl_BookId
            // 
            this.lbl_BookId.AutoSize = true;
            this.lbl_BookId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookId.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_BookId.Location = new System.Drawing.Point(20, 56);
            this.lbl_BookId.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_BookId.Name = "lbl_BookId";
            this.lbl_BookId.Size = new System.Drawing.Size(23, 15);
            this.lbl_BookId.TabIndex = 3;
            this.lbl_BookId.Text = "#id";
            this.lbl_BookId.UseCustomBackColor = true;
            // 
            // lbl_BookTitle
            // 
            this.lbl_BookTitle.AutoSize = true;
            this.lbl_BookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BookTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_BookTitle.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_BookTitle.Location = new System.Drawing.Point(20, 31);
            this.lbl_BookTitle.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(52, 25);
            this.lbl_BookTitle.TabIndex = 2;
            this.lbl_BookTitle.Text = "#title";
            this.lbl_BookTitle.UseCustomBackColor = true;
            // 
            // txt_BookSearch
            // 
            this.txt_BookSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txt_BookSearch.CustomButton.Image = null;
            this.txt_BookSearch.CustomButton.Location = new System.Drawing.Point(364, 2);
            this.txt_BookSearch.CustomButton.Name = "";
            this.txt_BookSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_BookSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_BookSearch.CustomButton.TabIndex = 1;
            this.txt_BookSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BookSearch.CustomButton.UseSelectable = true;
            this.txt_BookSearch.CustomButton.Visible = false;
            this.txt_BookSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_BookSearch.Lines = new string[0];
            this.txt_BookSearch.Location = new System.Drawing.Point(0, 30);
            this.txt_BookSearch.Margin = new System.Windows.Forms.Padding(0, 30, 20, 0);
            this.txt_BookSearch.MaxLength = 32767;
            this.txt_BookSearch.Name = "txt_BookSearch";
            this.txt_BookSearch.PasswordChar = '\0';
            this.txt_BookSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_BookSearch.SelectedText = "";
            this.txt_BookSearch.SelectionLength = 0;
            this.txt_BookSearch.SelectionStart = 0;
            this.txt_BookSearch.Size = new System.Drawing.Size(388, 26);
            this.txt_BookSearch.TabIndex = 4;
            this.txt_BookSearch.UseSelectable = true;
            this.txt_BookSearch.WaterMark = "Search for a book or author";
            this.txt_BookSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_BookSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // grd_Books
            // 
            this.grd_Books.AllowUserToAddRows = false;
            this.grd_Books.AllowUserToDeleteRows = false;
            this.grd_Books.AllowUserToResizeColumns = false;
            this.grd_Books.AllowUserToResizeRows = false;
            this.grd_Books.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Books.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Books.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_Books.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grd_Books.ColumnHeadersHeight = 26;
            this.grd_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.books_Id,
            this.books_Title,
            this.books_Author,
            this.books_Available,
            this.books_Blank});
            this.grd_Books.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Books.DefaultCellStyle = dataGridViewCellStyle5;
            this.grd_Books.EnableHeadersVisualStyles = false;
            this.grd_Books.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_Books.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Books.Location = new System.Drawing.Point(0, 66);
            this.grd_Books.Margin = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.grd_Books.MultiSelect = false;
            this.grd_Books.Name = "grd_Books";
            this.grd_Books.ReadOnly = true;
            this.grd_Books.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Books.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grd_Books.RowHeadersVisible = false;
            this.grd_Books.RowHeadersWidth = 10;
            this.grd_Books.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Books.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Books.Size = new System.Drawing.Size(388, 379);
            this.grd_Books.TabIndex = 3;
            this.grd_Books.UseCustomBackColor = true;
            this.grd_Books.UseCustomForeColor = true;
            this.grd_Books.UseStyleColors = true;
            this.grd_Books.SelectionChanged += new System.EventHandler(this.grd_Books_SelectionChanged);
            // 
            // tab_Members
            // 
            this.tab_Members.BackColor = System.Drawing.Color.Transparent;
            this.tab_Members.Controls.Add(this.pnl_Members);
            this.tab_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Members.Location = new System.Drawing.Point(4, 38);
            this.tab_Members.Name = "tab_Members";
            this.tab_Members.Size = new System.Drawing.Size(821, 448);
            this.tab_Members.TabIndex = 1;
            this.tab_Members.Text = "Members";
            // 
            // pnl_Members
            // 
            this.pnl_Members.Controls.Add(this.metroButton1);
            this.pnl_Members.HorizontalScrollbarBarColor = true;
            this.pnl_Members.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Members.HorizontalScrollbarSize = 10;
            this.pnl_Members.Location = new System.Drawing.Point(0, 0);
            this.pnl_Members.Name = "pnl_Members";
            this.pnl_Members.Size = new System.Drawing.Size(821, 448);
            this.pnl_Members.TabIndex = 0;
            this.pnl_Members.VerticalScrollbarBarColor = true;
            this.pnl_Members.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Members.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(323, 170);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // tab_Loans
            // 
            this.tab_Loans.BackColor = System.Drawing.Color.Transparent;
            this.tab_Loans.Controls.Add(this.pnl_Loans);
            this.tab_Loans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Loans.Location = new System.Drawing.Point(4, 38);
            this.tab_Loans.Name = "tab_Loans";
            this.tab_Loans.Size = new System.Drawing.Size(821, 448);
            this.tab_Loans.TabIndex = 2;
            this.tab_Loans.Text = "Loans";
            // 
            // pnl_Loans
            // 
            this.pnl_Loans.HorizontalScrollbarBarColor = true;
            this.pnl_Loans.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Loans.HorizontalScrollbarSize = 10;
            this.pnl_Loans.Location = new System.Drawing.Point(0, 0);
            this.pnl_Loans.Name = "pnl_Loans";
            this.pnl_Loans.Size = new System.Drawing.Size(821, 448);
            this.pnl_Loans.TabIndex = 0;
            this.pnl_Loans.VerticalScrollbarBarColor = true;
            this.pnl_Loans.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Loans.VerticalScrollbarSize = 10;
            // 
            // grd_BookCopies
            // 
            this.grd_BookCopies.AllowUserToAddRows = false;
            this.grd_BookCopies.AllowUserToDeleteRows = false;
            this.grd_BookCopies.AllowUserToResizeColumns = false;
            this.grd_BookCopies.AllowUserToResizeRows = false;
            this.grd_BookCopies.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grd_BookCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_BookCopies.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_BookCopies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_BookCopies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_BookCopies.ColumnHeadersHeight = 26;
            this.grd_BookCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_BookCopies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCopies_Id,
            this.bookCopies_Available,
            this.bookCopies_Member,
            this.bookCopies_DueDate});
            this.grd_BookCopies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_BookCopies.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_BookCopies.EnableHeadersVisualStyles = false;
            this.grd_BookCopies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_BookCopies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_BookCopies.Location = new System.Drawing.Point(22, 326);
            this.grd_BookCopies.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.grd_BookCopies.MultiSelect = false;
            this.grd_BookCopies.Name = "grd_BookCopies";
            this.grd_BookCopies.ReadOnly = true;
            this.grd_BookCopies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_BookCopies.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_BookCopies.RowHeadersVisible = false;
            this.grd_BookCopies.RowHeadersWidth = 10;
            this.grd_BookCopies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_BookCopies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_BookCopies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_BookCopies.Size = new System.Drawing.Size(368, 119);
            this.grd_BookCopies.TabIndex = 9;
            this.grd_BookCopies.UseCustomBackColor = true;
            this.grd_BookCopies.UseCustomForeColor = true;
            this.grd_BookCopies.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(20, 292);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "COPIES";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // btn_MakeLoan
            // 
            this.btn_MakeLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_MakeLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_MakeLoan.Location = new System.Drawing.Point(22, 465);
            this.btn_MakeLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_MakeLoan.Name = "btn_MakeLoan";
            this.btn_MakeLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_MakeLoan.TabIndex = 9;
            this.btn_MakeLoan.Text = "Make loan";
            this.btn_MakeLoan.UseSelectable = true;
            // 
            // btn_AddCopy
            // 
            this.btn_AddCopy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_AddCopy.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_AddCopy.Location = new System.Drawing.Point(290, 286);
            this.btn_AddCopy.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_AddCopy.Name = "btn_AddCopy";
            this.btn_AddCopy.Size = new System.Drawing.Size(100, 30);
            this.btn_AddCopy.TabIndex = 11;
            this.btn_AddCopy.Text = "Add copy";
            this.btn_AddCopy.UseSelectable = true;
            // 
            // btn_ReturnLoan
            // 
            this.btn_ReturnLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_ReturnLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_ReturnLoan.Location = new System.Drawing.Point(132, 465);
            this.btn_ReturnLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_ReturnLoan.Name = "btn_ReturnLoan";
            this.btn_ReturnLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_ReturnLoan.TabIndex = 12;
            this.btn_ReturnLoan.Text = "Return loan";
            this.btn_ReturnLoan.UseSelectable = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(22, 444);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(368, 1);
            this.metroPanel3.TabIndex = 8;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // books_Id
            // 
            this.books_Id.HeaderText = "Id";
            this.books_Id.Name = "books_Id";
            this.books_Id.ReadOnly = true;
            this.books_Id.Width = 30;
            // 
            // books_Title
            // 
            this.books_Title.HeaderText = "Title";
            this.books_Title.Name = "books_Title";
            this.books_Title.ReadOnly = true;
            this.books_Title.Width = 150;
            // 
            // books_Author
            // 
            this.books_Author.HeaderText = "Author";
            this.books_Author.Name = "books_Author";
            this.books_Author.ReadOnly = true;
            this.books_Author.Width = 130;
            // 
            // books_Available
            // 
            this.books_Available.HeaderText = "Available";
            this.books_Available.Image = global::Library.Properties.Resources.icon_check;
            this.books_Available.Name = "books_Available";
            this.books_Available.ReadOnly = true;
            this.books_Available.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.books_Available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.books_Available.Width = 60;
            // 
            // books_Blank
            // 
            this.books_Blank.HeaderText = "";
            this.books_Blank.Name = "books_Blank";
            this.books_Blank.ReadOnly = true;
            this.books_Blank.Width = 20;
            // 
            // bookCopies_Id
            // 
            this.bookCopies_Id.HeaderText = "Id";
            this.bookCopies_Id.Name = "bookCopies_Id";
            this.bookCopies_Id.ReadOnly = true;
            this.bookCopies_Id.Width = 30;
            // 
            // bookCopies_Available
            // 
            this.bookCopies_Available.HeaderText = "Available";
            this.bookCopies_Available.Image = global::Library.Properties.Resources.icon_check;
            this.bookCopies_Available.Name = "bookCopies_Available";
            this.bookCopies_Available.ReadOnly = true;
            this.bookCopies_Available.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bookCopies_Available.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bookCopies_Available.Width = 65;
            // 
            // bookCopies_Member
            // 
            this.bookCopies_Member.HeaderText = "Member";
            this.bookCopies_Member.Name = "bookCopies_Member";
            this.bookCopies_Member.ReadOnly = true;
            this.bookCopies_Member.Width = 170;
            // 
            // bookCopies_DueDate
            // 
            this.bookCopies_DueDate.HeaderText = "Due date";
            this.bookCopies_DueDate.Name = "bookCopies_DueDate";
            this.bookCopies_DueDate.ReadOnly = true;
            this.bookCopies_DueDate.Width = 110;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 643);
            this.Controls.Add(this.tbc_Main);
            this.MaximizeBox = false;
            this.Name = "LibraryForm";
            this.Resizable = false;
            this.Text = "The library";
            this.tbc_Main.ResumeLayout(false);
            this.tab_Books.ResumeLayout(false);
            this.pnl_Books.ResumeLayout(false);
            this.pnl_SelectedBook.ResumeLayout(false);
            this.pnl_SelectedBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Books)).EndInit();
            this.tab_Members.ResumeLayout(false);
            this.pnl_Members.ResumeLayout(false);
            this.tab_Loans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_BookCopies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tbc_Main;
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_Members;
        private System.Windows.Forms.TabPage tab_Loans;
        private MetroFramework.Controls.MetroPanel pnl_Books;
        private MetroFramework.Controls.MetroPanel pnl_Members;
        private MetroFramework.Controls.MetroPanel pnl_Loans;
        private MetroFramework.Controls.MetroGrid grd_Books;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txt_BookSearch;
        private MetroFramework.Controls.MetroPanel pnl_SelectedBook;
        private MetroFramework.Controls.MetroLabel lbl_BookId;
        private MetroFramework.Controls.MetroLabel lbl_BookTitle;
        private System.Windows.Forms.TextBox txt_BookDescription;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lbl_BookISBN;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_NewAuthor;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btn_NewBook;
        private MetroFramework.Controls.MetroButton btn_ReturnLoan;
        private MetroFramework.Controls.MetroButton btn_AddCopy;
        private MetroFramework.Controls.MetroButton btn_MakeLoan;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid grd_BookCopies;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private DataGridViewTextBoxColumn books_Id;
        private DataGridViewTextBoxColumn books_Title;
        private DataGridViewTextBoxColumn books_Author;
        private DataGridViewImageColumn books_Available;
        private DataGridViewTextBoxColumn books_Blank;
        private DataGridViewTextBoxColumn bookCopies_Id;
        private DataGridViewImageColumn bookCopies_Available;
        private DataGridViewTextBoxColumn bookCopies_Member;
        private DataGridViewTextBoxColumn bookCopies_DueDate;
    }
}

