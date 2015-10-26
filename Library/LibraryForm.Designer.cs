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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbc_Main = new MetroFramework.Controls.MetroTabControl();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.pnl_Books = new MetroFramework.Controls.MetroPanel();
            this.cbx_AvailableOnly = new MetroFramework.Controls.MetroCheckBox();
            this.btn_NewBook = new MetroFramework.Controls.MetroButton();
            this.pnl_SelectedBook = new MetroFramework.Controls.MetroPanel();
            this.btn_Books_ReturnLoan = new MetroFramework.Controls.MetroButton();
            this.btn_AddCopy = new MetroFramework.Controls.MetroButton();
            this.btn_Books_MakeLoan = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.grd_BookCopies = new MetroFramework.Controls.MetroGrid();
            this.bookCopies_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopies_Available = new System.Windows.Forms.DataGridViewImageColumn();
            this.bookCopies_Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopies_DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCopies_Blank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_BookDescription = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lbl_BookISBN = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lbl_BookId = new MetroFramework.Controls.MetroLabel();
            this.lbl_BookTitle = new MetroFramework.Controls.MetroLabel();
            this.txt_BookSearch = new MetroFramework.Controls.MetroTextBox();
            this.grd_Books = new MetroFramework.Controls.MetroGrid();
            this.books_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.books_Available = new System.Windows.Forms.DataGridViewImageColumn();
            this.books_Blank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Members = new System.Windows.Forms.TabPage();
            this.pnl_Members = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cbx_MembersWithActiveLoans = new MetroFramework.Controls.MetroCheckBox();
            this.btn_NewMember = new MetroFramework.Controls.MetroButton();
            this.pnl_SelectedMember = new MetroFramework.Controls.MetroPanel();
            this.cbx_Members_ShowReturnedLoans = new MetroFramework.Controls.MetroCheckBox();
            this.btn_Members_ReturnLoan = new MetroFramework.Controls.MetroButton();
            this.lbl_MemberLoans = new MetroFramework.Controls.MetroLabel();
            this.grd_Members_Loans = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members_loans_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members_loans_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members_loans_dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members_loans_dateOfReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_pNr = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.lbl_MemberID = new MetroFramework.Controls.MetroLabel();
            this.lbl_MemberName = new MetroFramework.Controls.MetroLabel();
            this.btn_Members_MakeLoan = new MetroFramework.Controls.MetroButton();
            this.txt_MemberSearch = new MetroFramework.Controls.MetroTextBox();
            this.grd_Members = new MetroFramework.Controls.MetroGrid();
            this.members_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members_pNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members_currentLoans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Loans = new System.Windows.Forms.TabPage();
            this.pnl_Loans = new MetroFramework.Controls.MetroPanel();
            this.cbx_Loans_ShowReturnedLoans = new MetroFramework.Controls.MetroCheckBox();
            this.btn_Loans_ReturnLoan = new MetroFramework.Controls.MetroButton();
            this.grd_Loans = new MetroFramework.Controls.MetroGrid();
            this.loans_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loans_CopyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loans_memberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loans_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loans_author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loans_dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loans_dateOfReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Loans_MakeLoan = new MetroFramework.Controls.MetroButton();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbc_Main.SuspendLayout();
            this.tab_Books.SuspendLayout();
            this.pnl_Books.SuspendLayout();
            this.pnl_SelectedBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BookCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Books)).BeginInit();
            this.tab_Members.SuspendLayout();
            this.pnl_Members.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.pnl_SelectedMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Members_Loans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Members)).BeginInit();
            this.tab_Loans.SuspendLayout();
            this.pnl_Loans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Loans)).BeginInit();
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
            this.tbc_Main.SelectedIndex = 1;
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
            this.pnl_Books.Controls.Add(this.cbx_AvailableOnly);
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
            // cbx_AvailableOnly
            // 
            this.cbx_AvailableOnly.AutoSize = true;
            this.cbx_AvailableOnly.Location = new System.Drawing.Point(0, 66);
            this.cbx_AvailableOnly.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbx_AvailableOnly.Name = "cbx_AvailableOnly";
            this.cbx_AvailableOnly.Size = new System.Drawing.Size(162, 15);
            this.cbx_AvailableOnly.TabIndex = 9;
            this.cbx_AvailableOnly.Text = "Show available books only";
            this.cbx_AvailableOnly.UseSelectable = true;
            this.cbx_AvailableOnly.CheckedChanged += new System.EventHandler(this.cbx_AvailableOnly_CheckedChanged);
            // 
            // btn_NewBook
            // 
            this.btn_NewBook.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_NewBook.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_NewBook.Location = new System.Drawing.Point(0, 485);
            this.btn_NewBook.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.btn_NewBook.Name = "btn_NewBook";
            this.btn_NewBook.Size = new System.Drawing.Size(117, 30);
            this.btn_NewBook.TabIndex = 6;
            this.btn_NewBook.Text = "Add new book";
            this.btn_NewBook.UseSelectable = true;
            this.btn_NewBook.Click += new System.EventHandler(this.btn_NewBook_Click);
            // 
            // pnl_SelectedBook
            // 
            this.pnl_SelectedBook.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SelectedBook.Controls.Add(this.btn_Books_ReturnLoan);
            this.pnl_SelectedBook.Controls.Add(this.btn_AddCopy);
            this.pnl_SelectedBook.Controls.Add(this.btn_Books_MakeLoan);
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
            // btn_Books_ReturnLoan
            // 
            this.btn_Books_ReturnLoan.Enabled = false;
            this.btn_Books_ReturnLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Books_ReturnLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Books_ReturnLoan.Location = new System.Drawing.Point(139, 484);
            this.btn_Books_ReturnLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_Books_ReturnLoan.Name = "btn_Books_ReturnLoan";
            this.btn_Books_ReturnLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_Books_ReturnLoan.TabIndex = 12;
            this.btn_Books_ReturnLoan.Text = "Return loan";
            this.btn_Books_ReturnLoan.UseSelectable = true;
            this.btn_Books_ReturnLoan.Click += new System.EventHandler(this.btn_Books_ReturnLoan_Click);
            // 
            // btn_AddCopy
            // 
            this.btn_AddCopy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_AddCopy.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_AddCopy.Location = new System.Drawing.Point(310, 285);
            this.btn_AddCopy.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_AddCopy.Name = "btn_AddCopy";
            this.btn_AddCopy.Size = new System.Drawing.Size(100, 30);
            this.btn_AddCopy.TabIndex = 11;
            this.btn_AddCopy.Text = "Add copy";
            this.btn_AddCopy.UseSelectable = true;
            this.btn_AddCopy.Click += new System.EventHandler(this.btn_AddCopy_Click);
            // 
            // btn_Books_MakeLoan
            // 
            this.btn_Books_MakeLoan.Enabled = false;
            this.btn_Books_MakeLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Books_MakeLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Books_MakeLoan.Location = new System.Drawing.Point(29, 484);
            this.btn_Books_MakeLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_Books_MakeLoan.Name = "btn_Books_MakeLoan";
            this.btn_Books_MakeLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_Books_MakeLoan.TabIndex = 9;
            this.btn_Books_MakeLoan.Text = "Make loan";
            this.btn_Books_MakeLoan.UseSelectable = true;
            this.btn_Books_MakeLoan.Click += new System.EventHandler(this.btn_Books_MakeLoan_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(27, 291);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "COPIES";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // grd_BookCopies
            // 
            this.grd_BookCopies.AllowUserToAddRows = false;
            this.grd_BookCopies.AllowUserToDeleteRows = false;
            this.grd_BookCopies.AllowUserToResizeColumns = false;
            this.grd_BookCopies.AllowUserToResizeRows = false;
            this.grd_BookCopies.BackgroundColor = System.Drawing.Color.AliceBlue;
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
            this.bookCopies_DueDate,
            this.bookCopies_Blank});
            this.grd_BookCopies.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_BookCopies.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_BookCopies.EnableHeadersVisualStyles = false;
            this.grd_BookCopies.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_BookCopies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_BookCopies.Location = new System.Drawing.Point(29, 325);
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
            this.grd_BookCopies.Size = new System.Drawing.Size(381, 139);
            this.grd_BookCopies.TabIndex = 9;
            this.grd_BookCopies.UseCustomBackColor = true;
            this.grd_BookCopies.UseCustomForeColor = true;
            this.grd_BookCopies.UseStyleColors = true;
            this.grd_BookCopies.SelectionChanged += new System.EventHandler(this.grd_BookCopies_SelectionChanged);
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
            this.bookCopies_Available.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.bookCopies_DueDate.Width = 95;
            // 
            // bookCopies_Blank
            // 
            this.bookCopies_Blank.HeaderText = "";
            this.bookCopies_Blank.Name = "bookCopies_Blank";
            this.bookCopies_Blank.ReadOnly = true;
            this.bookCopies_Blank.Width = 25;
            // 
            // txt_BookDescription
            // 
            this.txt_BookDescription.BackColor = System.Drawing.Color.White;
            this.txt_BookDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BookDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BookDescription.Location = new System.Drawing.Point(27, 177);
            this.txt_BookDescription.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.txt_BookDescription.Multiline = true;
            this.txt_BookDescription.Name = "txt_BookDescription";
            this.txt_BookDescription.ReadOnly = true;
            this.txt_BookDescription.Size = new System.Drawing.Size(383, 88);
            this.txt_BookDescription.TabIndex = 7;
            this.txt_BookDescription.Text = "#description";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(27, 153);
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
            this.lbl_BookISBN.Location = new System.Drawing.Point(27, 114);
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
            this.metroLabel3.Location = new System.Drawing.Point(27, 90);
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
            this.lbl_BookId.Location = new System.Drawing.Point(27, 55);
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
            this.lbl_BookTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lbl_BookTitle.Location = new System.Drawing.Point(27, 30);
            this.lbl_BookTitle.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_BookTitle.Name = "lbl_BookTitle";
            this.lbl_BookTitle.Size = new System.Drawing.Size(52, 25);
            this.lbl_BookTitle.TabIndex = 2;
            this.lbl_BookTitle.Text = "#title";
            this.lbl_BookTitle.UseCustomBackColor = true;
            this.lbl_BookTitle.UseCustomForeColor = true;
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
            this.txt_BookSearch.TextChanged += new System.EventHandler(this.txt_BookSearch_TextChanged);
            // 
            // grd_Books
            // 
            this.grd_Books.AllowUserToAddRows = false;
            this.grd_Books.AllowUserToDeleteRows = false;
            this.grd_Books.AllowUserToResizeColumns = false;
            this.grd_Books.AllowUserToResizeRows = false;
            this.grd_Books.BackgroundColor = System.Drawing.Color.AliceBlue;
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
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Books.DefaultCellStyle = dataGridViewCellStyle5;
            this.grd_Books.EnableHeadersVisualStyles = false;
            this.grd_Books.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_Books.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Books.Location = new System.Drawing.Point(0, 91);
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
            this.grd_Books.Size = new System.Drawing.Size(388, 374);
            this.grd_Books.TabIndex = 3;
            this.grd_Books.UseCustomBackColor = true;
            this.grd_Books.UseCustomForeColor = true;
            this.grd_Books.UseStyleColors = true;
            this.grd_Books.SelectionChanged += new System.EventHandler(this.grd_Books_SelectionChanged);
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
            this.books_Available.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // tab_Members
            // 
            this.tab_Members.BackColor = System.Drawing.Color.Transparent;
            this.tab_Members.Controls.Add(this.pnl_Members);
            this.tab_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Members.Location = new System.Drawing.Point(4, 38);
            this.tab_Members.Name = "tab_Members";
            this.tab_Members.Size = new System.Drawing.Size(821, 515);
            this.tab_Members.TabIndex = 1;
            this.tab_Members.Text = "Members";
            // 
            // pnl_Members
            // 
            this.pnl_Members.Controls.Add(this.metroPanel2);
            this.pnl_Members.HorizontalScrollbarBarColor = true;
            this.pnl_Members.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Members.HorizontalScrollbarSize = 10;
            this.pnl_Members.Location = new System.Drawing.Point(0, 0);
            this.pnl_Members.Name = "pnl_Members";
            this.pnl_Members.Size = new System.Drawing.Size(821, 515);
            this.pnl_Members.TabIndex = 0;
            this.pnl_Members.VerticalScrollbarBarColor = true;
            this.pnl_Members.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Members.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.cbx_MembersWithActiveLoans);
            this.metroPanel2.Controls.Add(this.btn_NewMember);
            this.metroPanel2.Controls.Add(this.pnl_SelectedMember);
            this.metroPanel2.Controls.Add(this.txt_MemberSearch);
            this.metroPanel2.Controls.Add(this.grd_Members);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(821, 515);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cbx_MembersWithActiveLoans
            // 
            this.cbx_MembersWithActiveLoans.AutoSize = true;
            this.cbx_MembersWithActiveLoans.Location = new System.Drawing.Point(0, 66);
            this.cbx_MembersWithActiveLoans.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbx_MembersWithActiveLoans.Name = "cbx_MembersWithActiveLoans";
            this.cbx_MembersWithActiveLoans.Size = new System.Drawing.Size(222, 15);
            this.cbx_MembersWithActiveLoans.TabIndex = 9;
            this.cbx_MembersWithActiveLoans.Text = "Show members with active loans only";
            this.cbx_MembersWithActiveLoans.UseSelectable = true;
            this.cbx_MembersWithActiveLoans.CheckedChanged += new System.EventHandler(this.cbx_MembersWithActiveLoans_CheckedChanged);
            // 
            // btn_NewMember
            // 
            this.btn_NewMember.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_NewMember.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_NewMember.Location = new System.Drawing.Point(0, 485);
            this.btn_NewMember.Margin = new System.Windows.Forms.Padding(0, 20, 10, 0);
            this.btn_NewMember.Name = "btn_NewMember";
            this.btn_NewMember.Size = new System.Drawing.Size(141, 30);
            this.btn_NewMember.TabIndex = 6;
            this.btn_NewMember.Text = "Add new member";
            this.btn_NewMember.UseSelectable = true;
            this.btn_NewMember.Click += new System.EventHandler(this.btn_NewMember_Click);
            // 
            // pnl_SelectedMember
            // 
            this.pnl_SelectedMember.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SelectedMember.Controls.Add(this.cbx_Members_ShowReturnedLoans);
            this.pnl_SelectedMember.Controls.Add(this.btn_Members_ReturnLoan);
            this.pnl_SelectedMember.Controls.Add(this.lbl_MemberLoans);
            this.pnl_SelectedMember.Controls.Add(this.grd_Members_Loans);
            this.pnl_SelectedMember.Controls.Add(this.lbl_pNr);
            this.pnl_SelectedMember.Controls.Add(this.metroLabel19);
            this.pnl_SelectedMember.Controls.Add(this.lbl_MemberID);
            this.pnl_SelectedMember.Controls.Add(this.lbl_MemberName);
            this.pnl_SelectedMember.Controls.Add(this.btn_Members_MakeLoan);
            this.pnl_SelectedMember.HorizontalScrollbarBarColor = true;
            this.pnl_SelectedMember.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_SelectedMember.HorizontalScrollbarSize = 10;
            this.pnl_SelectedMember.Location = new System.Drawing.Point(411, 0);
            this.pnl_SelectedMember.Name = "pnl_SelectedMember";
            this.pnl_SelectedMember.Size = new System.Drawing.Size(410, 515);
            this.pnl_SelectedMember.TabIndex = 5;
            this.pnl_SelectedMember.UseCustomBackColor = true;
            this.pnl_SelectedMember.VerticalScrollbarBarColor = true;
            this.pnl_SelectedMember.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_SelectedMember.VerticalScrollbarSize = 10;
            this.pnl_SelectedMember.Visible = false;
            // 
            // cbx_Members_ShowReturnedLoans
            // 
            this.cbx_Members_ShowReturnedLoans.AutoSize = true;
            this.cbx_Members_ShowReturnedLoans.Location = new System.Drawing.Point(269, 154);
            this.cbx_Members_ShowReturnedLoans.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbx_Members_ShowReturnedLoans.Name = "cbx_Members_ShowReturnedLoans";
            this.cbx_Members_ShowReturnedLoans.Size = new System.Drawing.Size(141, 15);
            this.cbx_Members_ShowReturnedLoans.TabIndex = 14;
            this.cbx_Members_ShowReturnedLoans.Text = "Include returned loans";
            this.cbx_Members_ShowReturnedLoans.UseSelectable = true;
            this.cbx_Members_ShowReturnedLoans.CheckedChanged += new System.EventHandler(this.cbx_Members_ShowReturnedLoans_CheckedChanged);
            // 
            // btn_Members_ReturnLoan
            // 
            this.btn_Members_ReturnLoan.Enabled = false;
            this.btn_Members_ReturnLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Members_ReturnLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Members_ReturnLoan.Location = new System.Drawing.Point(139, 484);
            this.btn_Members_ReturnLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_Members_ReturnLoan.Name = "btn_Members_ReturnLoan";
            this.btn_Members_ReturnLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_Members_ReturnLoan.TabIndex = 12;
            this.btn_Members_ReturnLoan.Text = "Return loan";
            this.btn_Members_ReturnLoan.UseSelectable = true;
            this.btn_Members_ReturnLoan.Click += new System.EventHandler(this.btn_Members_ReturnLoan_Click);
            // 
            // lbl_MemberLoans
            // 
            this.lbl_MemberLoans.AutoSize = true;
            this.lbl_MemberLoans.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MemberLoans.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_MemberLoans.Location = new System.Drawing.Point(27, 153);
            this.lbl_MemberLoans.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.lbl_MemberLoans.Name = "lbl_MemberLoans";
            this.lbl_MemberLoans.Size = new System.Drawing.Size(53, 19);
            this.lbl_MemberLoans.TabIndex = 10;
            this.lbl_MemberLoans.Text = "LOANS";
            this.lbl_MemberLoans.UseCustomBackColor = true;
            // 
            // grd_Members_Loans
            // 
            this.grd_Members_Loans.AllowUserToAddRows = false;
            this.grd_Members_Loans.AllowUserToDeleteRows = false;
            this.grd_Members_Loans.AllowUserToResizeColumns = false;
            this.grd_Members_Loans.AllowUserToResizeRows = false;
            this.grd_Members_Loans.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grd_Members_Loans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Members_Loans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_Members_Loans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Members_Loans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grd_Members_Loans.ColumnHeadersHeight = 26;
            this.grd_Members_Loans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Members_Loans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.members_loans_title,
            this.members_loans_author,
            this.members_loans_dueDate,
            this.members_loans_dateOfReturn,
            this.dataGridViewTextBoxColumn10});
            this.grd_Members_Loans.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Members_Loans.DefaultCellStyle = dataGridViewCellStyle8;
            this.grd_Members_Loans.EnableHeadersVisualStyles = false;
            this.grd_Members_Loans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_Members_Loans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Members_Loans.Location = new System.Drawing.Point(29, 182);
            this.grd_Members_Loans.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.grd_Members_Loans.MultiSelect = false;
            this.grd_Members_Loans.Name = "grd_Members_Loans";
            this.grd_Members_Loans.ReadOnly = true;
            this.grd_Members_Loans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Members_Loans.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grd_Members_Loans.RowHeadersVisible = false;
            this.grd_Members_Loans.RowHeadersWidth = 10;
            this.grd_Members_Loans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Members_Loans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Members_Loans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Members_Loans.Size = new System.Drawing.Size(381, 282);
            this.grd_Members_Loans.TabIndex = 9;
            this.grd_Members_Loans.UseCustomBackColor = true;
            this.grd_Members_Loans.UseCustomForeColor = true;
            this.grd_Members_Loans.UseStyleColors = true;
            this.grd_Members_Loans.SelectionChanged += new System.EventHandler(this.grd_Members_Loans_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 30;
            // 
            // members_loans_title
            // 
            this.members_loans_title.HeaderText = "Title";
            this.members_loans_title.Name = "members_loans_title";
            this.members_loans_title.ReadOnly = true;
            // 
            // members_loans_author
            // 
            this.members_loans_author.HeaderText = "Author";
            this.members_loans_author.Name = "members_loans_author";
            this.members_loans_author.ReadOnly = true;
            this.members_loans_author.Width = 90;
            // 
            // members_loans_dueDate
            // 
            this.members_loans_dueDate.HeaderText = "Due date";
            this.members_loans_dueDate.Name = "members_loans_dueDate";
            this.members_loans_dueDate.ReadOnly = true;
            this.members_loans_dueDate.Width = 70;
            // 
            // members_loans_dateOfReturn
            // 
            this.members_loans_dateOfReturn.HeaderText = "Return date";
            this.members_loans_dateOfReturn.Name = "members_loans_dateOfReturn";
            this.members_loans_dateOfReturn.ReadOnly = true;
            this.members_loans_dateOfReturn.Width = 80;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 25;
            // 
            // lbl_pNr
            // 
            this.lbl_pNr.AutoSize = true;
            this.lbl_pNr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pNr.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_pNr.Location = new System.Drawing.Point(27, 114);
            this.lbl_pNr.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.lbl_pNr.Name = "lbl_pNr";
            this.lbl_pNr.Size = new System.Drawing.Size(119, 19);
            this.lbl_pNr.TabIndex = 5;
            this.lbl_pNr.Text = "#personalNumber";
            this.lbl_pNr.UseCustomBackColor = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel19.Location = new System.Drawing.Point(27, 90);
            this.metroLabel19.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(136, 19);
            this.metroLabel19.TabIndex = 4;
            this.metroLabel19.Text = "PERSONAL NUMBER";
            this.metroLabel19.UseCustomBackColor = true;
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MemberID.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbl_MemberID.Location = new System.Drawing.Point(27, 55);
            this.lbl_MemberID.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(23, 15);
            this.lbl_MemberID.TabIndex = 3;
            this.lbl_MemberID.Text = "#id";
            this.lbl_MemberID.UseCustomBackColor = true;
            // 
            // lbl_MemberName
            // 
            this.lbl_MemberName.AutoSize = true;
            this.lbl_MemberName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MemberName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_MemberName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_MemberName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lbl_MemberName.Location = new System.Drawing.Point(27, 30);
            this.lbl_MemberName.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbl_MemberName.Name = "lbl_MemberName";
            this.lbl_MemberName.Size = new System.Drawing.Size(137, 25);
            this.lbl_MemberName.TabIndex = 2;
            this.lbl_MemberName.Text = "#memberName";
            this.lbl_MemberName.UseCustomBackColor = true;
            this.lbl_MemberName.UseCustomForeColor = true;
            // 
            // btn_Members_MakeLoan
            // 
            this.btn_Members_MakeLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Members_MakeLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Members_MakeLoan.Location = new System.Drawing.Point(29, 484);
            this.btn_Members_MakeLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_Members_MakeLoan.Name = "btn_Members_MakeLoan";
            this.btn_Members_MakeLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_Members_MakeLoan.TabIndex = 11;
            this.btn_Members_MakeLoan.Text = "Make loan";
            this.btn_Members_MakeLoan.UseSelectable = true;
            this.btn_Members_MakeLoan.Click += new System.EventHandler(this.btn_Members_MakeLoan_Click);
            // 
            // txt_MemberSearch
            // 
            this.txt_MemberSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txt_MemberSearch.CustomButton.Image = null;
            this.txt_MemberSearch.CustomButton.Location = new System.Drawing.Point(364, 2);
            this.txt_MemberSearch.CustomButton.Name = "";
            this.txt_MemberSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_MemberSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_MemberSearch.CustomButton.TabIndex = 1;
            this.txt_MemberSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_MemberSearch.CustomButton.UseSelectable = true;
            this.txt_MemberSearch.CustomButton.Visible = false;
            this.txt_MemberSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_MemberSearch.Lines = new string[0];
            this.txt_MemberSearch.Location = new System.Drawing.Point(0, 30);
            this.txt_MemberSearch.Margin = new System.Windows.Forms.Padding(0, 30, 20, 0);
            this.txt_MemberSearch.MaxLength = 32767;
            this.txt_MemberSearch.Name = "txt_MemberSearch";
            this.txt_MemberSearch.PasswordChar = '\0';
            this.txt_MemberSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_MemberSearch.SelectedText = "";
            this.txt_MemberSearch.SelectionLength = 0;
            this.txt_MemberSearch.SelectionStart = 0;
            this.txt_MemberSearch.Size = new System.Drawing.Size(388, 26);
            this.txt_MemberSearch.TabIndex = 4;
            this.txt_MemberSearch.UseSelectable = true;
            this.txt_MemberSearch.WaterMark = "Search for a member";
            this.txt_MemberSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_MemberSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MemberSearch.TextChanged += new System.EventHandler(this.txt_MemberSearch_TextChanged);
            // 
            // grd_Members
            // 
            this.grd_Members.AllowUserToAddRows = false;
            this.grd_Members.AllowUserToDeleteRows = false;
            this.grd_Members.AllowUserToResizeColumns = false;
            this.grd_Members.AllowUserToResizeRows = false;
            this.grd_Members.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grd_Members.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Members.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_Members.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Members.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grd_Members.ColumnHeadersHeight = 26;
            this.grd_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.members_Id,
            this.members_Name,
            this.members_pNr,
            this.members_currentLoans,
            this.dataGridViewTextBoxColumn14});
            this.grd_Members.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Members.DefaultCellStyle = dataGridViewCellStyle13;
            this.grd_Members.EnableHeadersVisualStyles = false;
            this.grd_Members.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_Members.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Members.Location = new System.Drawing.Point(0, 91);
            this.grd_Members.Margin = new System.Windows.Forms.Padding(0, 10, 20, 0);
            this.grd_Members.MultiSelect = false;
            this.grd_Members.Name = "grd_Members";
            this.grd_Members.ReadOnly = true;
            this.grd_Members.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Members.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grd_Members.RowHeadersVisible = false;
            this.grd_Members.RowHeadersWidth = 10;
            this.grd_Members.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Members.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Members.Size = new System.Drawing.Size(388, 374);
            this.grd_Members.TabIndex = 3;
            this.grd_Members.UseCustomBackColor = true;
            this.grd_Members.UseCustomForeColor = true;
            this.grd_Members.UseStyleColors = true;
            this.grd_Members.SelectionChanged += new System.EventHandler(this.grd_Members_SelectionChanged);
            // 
            // members_Id
            // 
            this.members_Id.HeaderText = "Id";
            this.members_Id.Name = "members_Id";
            this.members_Id.ReadOnly = true;
            this.members_Id.Width = 30;
            // 
            // members_Name
            // 
            this.members_Name.HeaderText = "Name";
            this.members_Name.Name = "members_Name";
            this.members_Name.ReadOnly = true;
            this.members_Name.Width = 150;
            // 
            // members_pNr
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.members_pNr.DefaultCellStyle = dataGridViewCellStyle11;
            this.members_pNr.HeaderText = "Personal number";
            this.members_pNr.Name = "members_pNr";
            this.members_pNr.ReadOnly = true;
            this.members_pNr.Width = 110;
            // 
            // members_currentLoans
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.members_currentLoans.DefaultCellStyle = dataGridViewCellStyle12;
            this.members_currentLoans.HeaderText = "Active loans";
            this.members_currentLoans.Name = "members_currentLoans";
            this.members_currentLoans.ReadOnly = true;
            this.members_currentLoans.Width = 80;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 20;
            // 
            // tab_Loans
            // 
            this.tab_Loans.BackColor = System.Drawing.Color.Transparent;
            this.tab_Loans.Controls.Add(this.pnl_Loans);
            this.tab_Loans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Loans.Location = new System.Drawing.Point(4, 38);
            this.tab_Loans.Name = "tab_Loans";
            this.tab_Loans.Size = new System.Drawing.Size(821, 515);
            this.tab_Loans.TabIndex = 2;
            this.tab_Loans.Text = "Loans";
            // 
            // pnl_Loans
            // 
            this.pnl_Loans.Controls.Add(this.cbx_Loans_ShowReturnedLoans);
            this.pnl_Loans.Controls.Add(this.btn_Loans_ReturnLoan);
            this.pnl_Loans.Controls.Add(this.grd_Loans);
            this.pnl_Loans.Controls.Add(this.btn_Loans_MakeLoan);
            this.pnl_Loans.HorizontalScrollbarBarColor = true;
            this.pnl_Loans.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Loans.HorizontalScrollbarSize = 10;
            this.pnl_Loans.Location = new System.Drawing.Point(0, 0);
            this.pnl_Loans.Name = "pnl_Loans";
            this.pnl_Loans.Size = new System.Drawing.Size(821, 515);
            this.pnl_Loans.TabIndex = 0;
            this.pnl_Loans.VerticalScrollbarBarColor = true;
            this.pnl_Loans.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Loans.VerticalScrollbarSize = 10;
            // 
            // cbx_Loans_ShowReturnedLoans
            // 
            this.cbx_Loans_ShowReturnedLoans.AutoSize = true;
            this.cbx_Loans_ShowReturnedLoans.Location = new System.Drawing.Point(0, 30);
            this.cbx_Loans_ShowReturnedLoans.Margin = new System.Windows.Forms.Padding(0, 30, 0, 10);
            this.cbx_Loans_ShowReturnedLoans.Name = "cbx_Loans_ShowReturnedLoans";
            this.cbx_Loans_ShowReturnedLoans.Size = new System.Drawing.Size(141, 15);
            this.cbx_Loans_ShowReturnedLoans.TabIndex = 19;
            this.cbx_Loans_ShowReturnedLoans.Text = "Include returned loans";
            this.cbx_Loans_ShowReturnedLoans.UseSelectable = true;
            this.cbx_Loans_ShowReturnedLoans.CheckedChanged += new System.EventHandler(this.cbx_Loans_ShowReturnedLoans_CheckedChanged);
            // 
            // btn_Loans_ReturnLoan
            // 
            this.btn_Loans_ReturnLoan.Enabled = false;
            this.btn_Loans_ReturnLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Loans_ReturnLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Loans_ReturnLoan.Location = new System.Drawing.Point(110, 485);
            this.btn_Loans_ReturnLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_Loans_ReturnLoan.Name = "btn_Loans_ReturnLoan";
            this.btn_Loans_ReturnLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_Loans_ReturnLoan.TabIndex = 18;
            this.btn_Loans_ReturnLoan.Text = "Return loan";
            this.btn_Loans_ReturnLoan.UseSelectable = true;
            this.btn_Loans_ReturnLoan.Click += new System.EventHandler(this.btn_Loans_ReturnLoan_Click);
            // 
            // grd_Loans
            // 
            this.grd_Loans.AllowUserToAddRows = false;
            this.grd_Loans.AllowUserToDeleteRows = false;
            this.grd_Loans.AllowUserToResizeColumns = false;
            this.grd_Loans.AllowUserToResizeRows = false;
            this.grd_Loans.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.grd_Loans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Loans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_Loans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Loans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grd_Loans.ColumnHeadersHeight = 26;
            this.grd_Loans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Loans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loans_Id,
            this.loans_CopyId,
            this.loans_memberName,
            this.loans_title,
            this.loans_author,
            this.loans_dueDate,
            this.loans_dateOfReturn,
            this.dataGridViewTextBoxColumn18});
            this.grd_Loans.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Loans.DefaultCellStyle = dataGridViewCellStyle18;
            this.grd_Loans.EnableHeadersVisualStyles = false;
            this.grd_Loans.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_Loans.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_Loans.Location = new System.Drawing.Point(0, 60);
            this.grd_Loans.Margin = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.grd_Loans.MultiSelect = false;
            this.grd_Loans.Name = "grd_Loans";
            this.grd_Loans.ReadOnly = true;
            this.grd_Loans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Loans.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grd_Loans.RowHeadersVisible = false;
            this.grd_Loans.RowHeadersWidth = 10;
            this.grd_Loans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Loans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Loans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Loans.Size = new System.Drawing.Size(821, 405);
            this.grd_Loans.TabIndex = 15;
            this.grd_Loans.UseCustomBackColor = true;
            this.grd_Loans.UseCustomForeColor = true;
            this.grd_Loans.UseStyleColors = true;
            this.grd_Loans.SelectionChanged += new System.EventHandler(this.grd_Loans_SelectionChanged);
            // 
            // loans_Id
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.loans_Id.DefaultCellStyle = dataGridViewCellStyle16;
            this.loans_Id.HeaderText = "Id";
            this.loans_Id.Name = "loans_Id";
            this.loans_Id.ReadOnly = true;
            this.loans_Id.Width = 40;
            // 
            // loans_CopyId
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.loans_CopyId.DefaultCellStyle = dataGridViewCellStyle17;
            this.loans_CopyId.HeaderText = "Copy Id";
            this.loans_CopyId.Name = "loans_CopyId";
            this.loans_CopyId.ReadOnly = true;
            this.loans_CopyId.Width = 60;
            // 
            // loans_memberName
            // 
            this.loans_memberName.HeaderText = "Member";
            this.loans_memberName.Name = "loans_memberName";
            this.loans_memberName.ReadOnly = true;
            this.loans_memberName.Width = 170;
            // 
            // loans_title
            // 
            this.loans_title.HeaderText = "Title";
            this.loans_title.Name = "loans_title";
            this.loans_title.ReadOnly = true;
            this.loans_title.Width = 210;
            // 
            // loans_author
            // 
            this.loans_author.HeaderText = "Author";
            this.loans_author.Name = "loans_author";
            this.loans_author.ReadOnly = true;
            this.loans_author.Width = 120;
            // 
            // loans_dueDate
            // 
            this.loans_dueDate.HeaderText = "Due date";
            this.loans_dueDate.Name = "loans_dueDate";
            this.loans_dueDate.ReadOnly = true;
            this.loans_dueDate.Width = 95;
            // 
            // loans_dateOfReturn
            // 
            this.loans_dateOfReturn.HeaderText = "Return date";
            this.loans_dateOfReturn.Name = "loans_dateOfReturn";
            this.loans_dateOfReturn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 25;
            // 
            // btn_Loans_MakeLoan
            // 
            this.btn_Loans_MakeLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Loans_MakeLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Loans_MakeLoan.Location = new System.Drawing.Point(0, 485);
            this.btn_Loans_MakeLoan.Margin = new System.Windows.Forms.Padding(0, 20, 10, 20);
            this.btn_Loans_MakeLoan.Name = "btn_Loans_MakeLoan";
            this.btn_Loans_MakeLoan.Size = new System.Drawing.Size(100, 30);
            this.btn_Loans_MakeLoan.TabIndex = 17;
            this.btn_Loans_MakeLoan.Text = "Make loan";
            this.btn_Loans_MakeLoan.UseSelectable = true;
            this.btn_Loans_MakeLoan.Click += new System.EventHandler(this.btn_Loans_MakeLoan_Click);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Available";
            this.dataGridViewImageColumn2.Image = global::Library.Properties.Resources.icon_check;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 65;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Available";
            this.dataGridViewImageColumn3.Image = global::Library.Properties.Resources.icon_check;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 60;
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
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.tbc_Main.ResumeLayout(false);
            this.tab_Books.ResumeLayout(false);
            this.pnl_Books.ResumeLayout(false);
            this.pnl_Books.PerformLayout();
            this.pnl_SelectedBook.ResumeLayout(false);
            this.pnl_SelectedBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BookCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Books)).EndInit();
            this.tab_Members.ResumeLayout(false);
            this.pnl_Members.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.pnl_SelectedMember.ResumeLayout(false);
            this.pnl_SelectedMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Members_Loans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Members)).EndInit();
            this.tab_Loans.ResumeLayout(false);
            this.pnl_Loans.ResumeLayout(false);
            this.pnl_Loans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Loans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tbc_Main;
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_Members;
        private System.Windows.Forms.TabPage tab_Loans;
        private MetroFramework.Controls.MetroPanel pnl_Books;
        private MetroFramework.Controls.MetroPanel pnl_Loans;
        private MetroFramework.Controls.MetroGrid grd_Books;
        private MetroFramework.Controls.MetroTextBox txt_BookSearch;
        private MetroFramework.Controls.MetroPanel pnl_SelectedBook;
        private MetroFramework.Controls.MetroLabel lbl_BookId;
        private MetroFramework.Controls.MetroLabel lbl_BookTitle;
        private System.Windows.Forms.TextBox txt_BookDescription;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lbl_BookISBN;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_NewBook;
        private MetroFramework.Controls.MetroButton btn_Books_ReturnLoan;
        private MetroFramework.Controls.MetroButton btn_AddCopy;
        private MetroFramework.Controls.MetroButton btn_Books_MakeLoan;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid grd_BookCopies;
        private MetroFramework.Controls.MetroCheckBox cbx_AvailableOnly;
        private DataGridViewTextBoxColumn bookCopies_Id;
        private DataGridViewImageColumn bookCopies_Available;
        private DataGridViewTextBoxColumn bookCopies_Member;
        private DataGridViewTextBoxColumn bookCopies_DueDate;
        private DataGridViewTextBoxColumn bookCopies_Blank;
        private DataGridViewTextBoxColumn books_Id;
        private DataGridViewTextBoxColumn books_Title;
        private DataGridViewTextBoxColumn books_Author;
        private DataGridViewImageColumn books_Available;
        private DataGridViewTextBoxColumn books_Blank;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private MetroFramework.Controls.MetroPanel pnl_Members;
        private MetroFramework.Controls.MetroCheckBox cbx_Loans_ShowReturnedLoans;
        private MetroFramework.Controls.MetroButton btn_Loans_ReturnLoan;
        private MetroFramework.Controls.MetroGrid grd_Loans;
        private MetroFramework.Controls.MetroButton btn_Loans_MakeLoan;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroCheckBox cbx_MembersWithActiveLoans;
        private MetroFramework.Controls.MetroButton btn_NewMember;
        private MetroFramework.Controls.MetroPanel pnl_SelectedMember;
        private MetroFramework.Controls.MetroCheckBox cbx_Members_ShowReturnedLoans;
        private MetroFramework.Controls.MetroButton btn_Members_ReturnLoan;
        private MetroFramework.Controls.MetroLabel lbl_MemberLoans;
        private MetroFramework.Controls.MetroGrid grd_Members_Loans;
        private MetroFramework.Controls.MetroLabel lbl_pNr;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel lbl_MemberID;
        private MetroFramework.Controls.MetroLabel lbl_MemberName;
        private MetroFramework.Controls.MetroButton btn_Members_MakeLoan;
        private MetroFramework.Controls.MetroTextBox txt_MemberSearch;
        private MetroFramework.Controls.MetroGrid grd_Members;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn members_loans_title;
        private DataGridViewTextBoxColumn members_loans_author;
        private DataGridViewTextBoxColumn members_loans_dueDate;
        private DataGridViewTextBoxColumn members_loans_dateOfReturn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn loans_Id;
        private DataGridViewTextBoxColumn loans_CopyId;
        private DataGridViewTextBoxColumn loans_memberName;
        private DataGridViewTextBoxColumn loans_title;
        private DataGridViewTextBoxColumn loans_author;
        private DataGridViewTextBoxColumn loans_dueDate;
        private DataGridViewTextBoxColumn loans_dateOfReturn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn members_Id;
        private DataGridViewTextBoxColumn members_Name;
        private DataGridViewTextBoxColumn members_pNr;
        private DataGridViewTextBoxColumn members_currentLoans;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}

