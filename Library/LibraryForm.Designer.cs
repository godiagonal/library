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
            this.pnl_Members = new MetroFramework.Controls.MetroTabControl();
            this.tab_Books = new System.Windows.Forms.TabPage();
            this.tab_Members = new System.Windows.Forms.TabPage();
            this.tab_Loans = new System.Windows.Forms.TabPage();
            this.htmlToolTip1 = new MetroFramework.Drawing.Html.HtmlToolTip();
            this.pnl_Books = new MetroFramework.Controls.MetroPanel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pnl_Loans = new MetroFramework.Controls.MetroPanel();
            this.grd_BookResults = new MetroFramework.Controls.MetroGrid();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pnl_Members.SuspendLayout();
            this.tab_Books.SuspendLayout();
            this.tab_Members.SuspendLayout();
            this.tab_Loans.SuspendLayout();
            this.pnl_Books.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_BookResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Members
            // 
            this.pnl_Members.Controls.Add(this.tab_Books);
            this.pnl_Members.Controls.Add(this.tab_Members);
            this.pnl_Members.Controls.Add(this.tab_Loans);
            this.pnl_Members.Location = new System.Drawing.Point(23, 63);
            this.pnl_Members.Name = "pnl_Members";
            this.pnl_Members.SelectedIndex = 1;
            this.pnl_Members.Size = new System.Drawing.Size(740, 490);
            this.pnl_Members.TabIndex = 2;
            this.pnl_Members.UseSelectable = true;
            // 
            // tab_Books
            // 
            this.tab_Books.BackColor = System.Drawing.Color.Transparent;
            this.tab_Books.Controls.Add(this.pnl_Books);
            this.tab_Books.Location = new System.Drawing.Point(4, 38);
            this.tab_Books.Name = "tab_Books";
            this.tab_Books.Size = new System.Drawing.Size(732, 448);
            this.tab_Books.TabIndex = 0;
            this.tab_Books.Text = "Books";
            // 
            // tab_Members
            // 
            this.tab_Members.BackColor = System.Drawing.Color.Transparent;
            this.tab_Members.Controls.Add(this.metroPanel1);
            this.tab_Members.Location = new System.Drawing.Point(4, 38);
            this.tab_Members.Name = "tab_Members";
            this.tab_Members.Size = new System.Drawing.Size(732, 448);
            this.tab_Members.TabIndex = 1;
            this.tab_Members.Text = "Members";
            // 
            // tab_Loans
            // 
            this.tab_Loans.BackColor = System.Drawing.Color.Transparent;
            this.tab_Loans.Controls.Add(this.pnl_Loans);
            this.tab_Loans.Location = new System.Drawing.Point(4, 38);
            this.tab_Loans.Name = "tab_Loans";
            this.tab_Loans.Size = new System.Drawing.Size(732, 448);
            this.tab_Loans.TabIndex = 2;
            this.tab_Loans.Text = "Loans";
            // 
            // htmlToolTip1
            // 
            this.htmlToolTip1.OwnerDraw = true;
            // 
            // pnl_Books
            // 
            this.pnl_Books.Controls.Add(this.grd_BookResults);
            this.pnl_Books.Controls.Add(this.metroComboBox1);
            this.pnl_Books.HorizontalScrollbarBarColor = true;
            this.pnl_Books.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Books.HorizontalScrollbarSize = 10;
            this.pnl_Books.Location = new System.Drawing.Point(0, 0);
            this.pnl_Books.Name = "pnl_Books";
            this.pnl_Books.Size = new System.Drawing.Size(732, 448);
            this.pnl_Books.TabIndex = 0;
            this.pnl_Books.VerticalScrollbarBarColor = true;
            this.pnl_Books.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Books.VerticalScrollbarSize = 10;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(143, 140);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(732, 448);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pnl_Loans
            // 
            this.pnl_Loans.HorizontalScrollbarBarColor = true;
            this.pnl_Loans.HorizontalScrollbarHighlightOnWheel = false;
            this.pnl_Loans.HorizontalScrollbarSize = 10;
            this.pnl_Loans.Location = new System.Drawing.Point(0, 0);
            this.pnl_Loans.Name = "pnl_Loans";
            this.pnl_Loans.Size = new System.Drawing.Size(732, 448);
            this.pnl_Loans.TabIndex = 0;
            this.pnl_Loans.VerticalScrollbarBarColor = true;
            this.pnl_Loans.VerticalScrollbarHighlightOnWheel = false;
            this.pnl_Loans.VerticalScrollbarSize = 10;
            // 
            // grd_BookResults
            // 
            this.grd_BookResults.AllowUserToResizeRows = false;
            this.grd_BookResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_BookResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grd_BookResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_BookResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_BookResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_BookResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.grd_BookResults.EnableHeadersVisualStyles = false;
            this.grd_BookResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grd_BookResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grd_BookResults.Location = new System.Drawing.Point(72, 173);
            this.grd_BookResults.Name = "grd_BookResults";
            this.grd_BookResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_BookResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grd_BookResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_BookResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_BookResults.Size = new System.Drawing.Size(240, 150);
            this.grd_BookResults.TabIndex = 3;
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
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 576);
            this.Controls.Add(this.pnl_Members);
            this.Name = "LibraryForm";
            this.Text = "The library";
            this.pnl_Members.ResumeLayout(false);
            this.tab_Books.ResumeLayout(false);
            this.tab_Members.ResumeLayout(false);
            this.tab_Loans.ResumeLayout(false);
            this.pnl_Books.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_BookResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl pnl_Members;
        private System.Windows.Forms.TabPage tab_Books;
        private System.Windows.Forms.TabPage tab_Members;
        private System.Windows.Forms.TabPage tab_Loans;
        private MetroFramework.Drawing.Html.HtmlToolTip htmlToolTip1;
        private MetroFramework.Controls.MetroPanel pnl_Books;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnl_Loans;
        private MetroFramework.Controls.MetroGrid grd_BookResults;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

