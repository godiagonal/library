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
            this.lb_BookResults = new System.Windows.Forms.ListBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_Books = new MetroFramework.Controls.MetroTabPage();
            this.btn_BookAdd = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tab_Members = new MetroFramework.Controls.MetroTabPage();
            this.tab_Loans = new MetroFramework.Controls.MetroTabPage();
            this.txt_BookSearch = new MetroFramework.Controls.MetroTextBox();
            this.btn_AuthorAdd = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.tab_Books.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_BookResults
            // 
            this.lb_BookResults.FormattingEnabled = true;
            this.lb_BookResults.Location = new System.Drawing.Point(3, 69);
            this.lb_BookResults.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.lb_BookResults.Name = "lb_BookResults";
            this.lb_BookResults.Size = new System.Drawing.Size(310, 199);
            this.lb_BookResults.TabIndex = 0;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_Books);
            this.metroTabControl1.Controls.Add(this.tab_Members);
            this.metroTabControl1.Controls.Add(this.tab_Loans);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(100, 40);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Multiline = true;
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(740, 490);
            this.metroTabControl1.TabIndex = 2;
            // 
            // tab_Books
            // 
            this.tab_Books.Controls.Add(this.button1);
            this.tab_Books.Controls.Add(this.btn_AuthorAdd);
            this.tab_Books.Controls.Add(this.txt_BookSearch);
            this.tab_Books.Controls.Add(this.btn_BookAdd);
            this.tab_Books.Controls.Add(this.comboBox1);
            this.tab_Books.Controls.Add(this.lb_BookResults);
            this.tab_Books.HorizontalScrollbarBarColor = true;
            this.tab_Books.Location = new System.Drawing.Point(4, 44);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tab_Books.Size = new System.Drawing.Size(732, 442);
            this.tab_Books.TabIndex = 1;
            this.tab_Books.Text = "Books";
            this.tab_Books.VerticalScrollbarBarColor = true;
            // 
            // btn_BookAdd
            // 
            this.btn_BookAdd.Location = new System.Drawing.Point(3, 281);
            this.btn_BookAdd.Name = "btn_BookAdd";
            this.btn_BookAdd.Size = new System.Drawing.Size(121, 30);
            this.btn_BookAdd.TabIndex = 4;
            this.btn_BookAdd.Text = "Add new book";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "asdf",
            "fdsa",
            "fasdfasdf",
            "asdf"});
            this.comboBox1.Location = new System.Drawing.Point(471, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // tab_Members
            // 
            this.tab_Members.HorizontalScrollbarBarColor = true;
            this.tab_Members.Location = new System.Drawing.Point(4, 44);
            this.tab_Members.Name = "tab_Members";
            this.tab_Members.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tab_Members.Size = new System.Drawing.Size(732, 442);
            this.tab_Members.TabIndex = 0;
            this.tab_Members.Text = "Members";
            this.tab_Members.VerticalScrollbarBarColor = true;
            // 
            // tab_Loans
            // 
            this.tab_Loans.HorizontalScrollbarBarColor = true;
            this.tab_Loans.Location = new System.Drawing.Point(4, 44);
            this.tab_Loans.Name = "tab_Loans";
            this.tab_Loans.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.tab_Loans.Size = new System.Drawing.Size(732, 442);
            this.tab_Loans.TabIndex = 3;
            this.tab_Loans.Text = "Loans";
            this.tab_Loans.VerticalScrollbarBarColor = true;
            // 
            // txt_BookSearch
            // 
            this.txt_BookSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_BookSearch.Location = new System.Drawing.Point(3, 33);
            this.txt_BookSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txt_BookSearch.Name = "txt_BookSearch";
            this.txt_BookSearch.PromptText = "Type to search for books and authors";
            this.txt_BookSearch.Size = new System.Drawing.Size(310, 30);
            this.txt_BookSearch.TabIndex = 5;
            // 
            // btn_AuthorAdd
            // 
            this.btn_AuthorAdd.Location = new System.Drawing.Point(173, 281);
            this.btn_AuthorAdd.Name = "btn_AuthorAdd";
            this.btn_AuthorAdd.Size = new System.Drawing.Size(119, 23);
            this.btn_AuthorAdd.TabIndex = 6;
            this.btn_AuthorAdd.Text = "Add new author";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "New book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 576);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "LibraryForm";
            this.Text = "The library";
            this.metroTabControl1.ResumeLayout(false);
            this.tab_Books.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_BookResults;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tab_Members;
        private MetroFramework.Controls.MetroTabPage tab_Books;
        private MetroFramework.Controls.MetroTabPage tab_Loans;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroButton btn_BookAdd;
        private MetroFramework.Controls.MetroTextBox txt_BookSearch;
        private MetroFramework.Controls.MetroButton btn_AuthorAdd;
        private System.Windows.Forms.Button button1;
    }
}

