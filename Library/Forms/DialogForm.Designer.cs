namespace Library
{
    partial class DialogForm
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
            this.lbl_question = new MetroFramework.Controls.MetroLabel();
            this.txt_answer = new MetroFramework.Controls.MetroTextBox();
            this.btn_Accept = new MetroFramework.Controls.MetroButton();
            this.btn_Cancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.BackColor = System.Drawing.Color.Transparent;
            this.lbl_question.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_question.Location = new System.Drawing.Point(25, 67);
            this.lbl_question.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(65, 19);
            this.lbl_question.TabIndex = 8;
            this.lbl_question.Text = "Question";
            this.lbl_question.UseCustomBackColor = true;
            // 
            // txt_answer
            // 
            this.txt_answer.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txt_answer.CustomButton.Image = null;
            this.txt_answer.CustomButton.Location = new System.Drawing.Point(226, 2);
            this.txt_answer.CustomButton.Name = "";
            this.txt_answer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_answer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_answer.CustomButton.TabIndex = 1;
            this.txt_answer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_answer.CustomButton.UseSelectable = true;
            this.txt_answer.CustomButton.Visible = false;
            this.txt_answer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_answer.Lines = new string[0];
            this.txt_answer.Location = new System.Drawing.Point(25, 91);
            this.txt_answer.Margin = new System.Windows.Forms.Padding(0, 5, 0, 25);
            this.txt_answer.MaxLength = 32767;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.PasswordChar = '\0';
            this.txt_answer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_answer.SelectedText = "";
            this.txt_answer.SelectionLength = 0;
            this.txt_answer.SelectionStart = 0;
            this.txt_answer.Size = new System.Drawing.Size(250, 26);
            this.txt_answer.TabIndex = 0;
            this.txt_answer.UseSelectable = true;
            this.txt_answer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_answer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Accept
            // 
            this.btn_Accept.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Accept.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Accept.Location = new System.Drawing.Point(25, 142);
            this.btn_Accept.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(120, 30);
            this.btn_Accept.TabIndex = 1;
            this.btn_Accept.Text = "OK";
            this.btn_Accept.UseSelectable = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btn_Cancel.Location = new System.Drawing.Point(155, 142);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(120, 30);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseSelectable = true;
            // 
            // DialogForm
            // 
            this.AcceptButton = this.btn_Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(300, 202);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.txt_answer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogForm";
            this.Padding = new System.Windows.Forms.Padding(25, 60, 25, 25);
            this.Resizable = false;
            this.Text = "Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_question;
        private MetroFramework.Controls.MetroTextBox txt_answer;
        private MetroFramework.Controls.MetroButton btn_Accept;
        private MetroFramework.Controls.MetroButton btn_Cancel;
    }
}