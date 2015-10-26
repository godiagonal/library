namespace Library
{
    partial class NewLoanForm
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
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbx_Members = new System.Windows.Forms.ComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_NewMember = new MetroFramework.Controls.MetroButton();
            this.btn_SaveLoan = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cbx_Books = new System.Windows.Forms.ComboBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.cbx_BookCopies = new System.Windows.Forms.ComboBox();
            this.cbx_SubtractDays = new MetroFramework.Controls.MetroCheckBox();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(25, 178);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Book";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(25, 243);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Available copies";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(25, 67);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Member";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // cbx_Members
            // 
            this.cbx_Members.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Members.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Members.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Members.FormattingEnabled = true;
            this.cbx_Members.Location = new System.Drawing.Point(1, 1);
            this.cbx_Members.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_Members.Name = "cbx_Members";
            this.cbx_Members.Size = new System.Drawing.Size(247, 25);
            this.cbx_Members.TabIndex = 0;
            this.cbx_Members.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveLoan_KeyDown);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.metroPanel1.Controls.Add(this.cbx_Members);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(25, 91);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(249, 27);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_NewMember
            // 
            this.btn_NewMember.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_NewMember.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_NewMember.Location = new System.Drawing.Point(148, 133);
            this.btn_NewMember.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_NewMember.Name = "btn_NewMember";
            this.btn_NewMember.Size = new System.Drawing.Size(126, 30);
            this.btn_NewMember.TabIndex = 1;
            this.btn_NewMember.Text = "Add new member";
            this.btn_NewMember.UseSelectable = true;
            this.btn_NewMember.Click += new System.EventHandler(this.btn_NewMember_Click);
            // 
            // btn_SaveLoan
            // 
            this.btn_SaveLoan.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_SaveLoan.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_SaveLoan.Location = new System.Drawing.Point(25, 349);
            this.btn_SaveLoan.Margin = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.btn_SaveLoan.Name = "btn_SaveLoan";
            this.btn_SaveLoan.Size = new System.Drawing.Size(249, 30);
            this.btn_SaveLoan.TabIndex = 5;
            this.btn_SaveLoan.Text = "Save loan";
            this.btn_SaveLoan.UseSelectable = true;
            this.btn_SaveLoan.Click += new System.EventHandler(this.btn_SaveLoan_Click);
            this.btn_SaveLoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveLoan_KeyDown);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.DarkGray;
            this.metroPanel2.Controls.Add(this.cbx_Books);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(25, 202);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 15);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(249, 27);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // cbx_Books
            // 
            this.cbx_Books.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_Books.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Books.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Books.FormattingEnabled = true;
            this.cbx_Books.Location = new System.Drawing.Point(1, 1);
            this.cbx_Books.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_Books.Name = "cbx_Books";
            this.cbx_Books.Size = new System.Drawing.Size(247, 25);
            this.cbx_Books.TabIndex = 0;
            this.cbx_Books.SelectedIndexChanged += new System.EventHandler(this.cbx_Books_SelectedIndexChanged);
            this.cbx_Books.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveLoan_KeyDown);
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.DarkGray;
            this.metroPanel3.Controls.Add(this.cbx_BookCopies);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(25, 267);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 20);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(249, 27);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // cbx_BookCopies
            // 
            this.cbx_BookCopies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_BookCopies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_BookCopies.Enabled = false;
            this.cbx_BookCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_BookCopies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_BookCopies.FormattingEnabled = true;
            this.cbx_BookCopies.Location = new System.Drawing.Point(1, 1);
            this.cbx_BookCopies.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_BookCopies.Name = "cbx_BookCopies";
            this.cbx_BookCopies.Size = new System.Drawing.Size(247, 25);
            this.cbx_BookCopies.TabIndex = 0;
            this.cbx_BookCopies.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveLoan_KeyDown);
            // 
            // cbx_SubtractDays
            // 
            this.cbx_SubtractDays.AutoSize = true;
            this.cbx_SubtractDays.Location = new System.Drawing.Point(25, 314);
            this.cbx_SubtractDays.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.cbx_SubtractDays.Name = "cbx_SubtractDays";
            this.cbx_SubtractDays.Size = new System.Drawing.Size(169, 15);
            this.cbx_SubtractDays.TabIndex = 4;
            this.cbx_SubtractDays.Text = "Save as already expired loan";
            this.cbx_SubtractDays.UseSelectable = true;
            this.cbx_SubtractDays.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_SaveLoan_KeyDown);
            // 
            // NewLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 406);
            this.Controls.Add(this.cbx_SubtractDays);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.btn_SaveLoan);
            this.Controls.Add(this.btn_NewMember);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewLoanForm";
            this.Padding = new System.Windows.Forms.Padding(25, 60, 25, 25);
            this.Resizable = false;
            this.Text = "Make loan";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ComboBox cbx_Members;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_NewMember;
        private MetroFramework.Controls.MetroButton btn_SaveLoan;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.ComboBox cbx_Books;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.ComboBox cbx_BookCopies;
        private MetroFramework.Controls.MetroCheckBox cbx_SubtractDays;
    }
}