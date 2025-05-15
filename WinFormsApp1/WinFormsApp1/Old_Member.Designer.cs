namespace Library_Managment__System
{
    partial class Old_Member
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
            this.label1 = new System.Windows.Forms.Label();
            this.old_name = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.Book_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // old_name
            // 
            this.old_name.Location = new System.Drawing.Point(15, 63);
            this.old_name.Name = "old_name";
            this.old_name.Size = new System.Drawing.Size(100, 20);
            this.old_name.TabIndex = 1;
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(15, 132);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 20);
            this.phone_number.TabIndex = 2;
            // 
            // Book_name
            // 
            this.Book_name.Location = new System.Drawing.Point(15, 225);
            this.Book_name.Name = "Book_name";
            this.Book_name.Size = new System.Drawing.Size(100, 20);
            this.Book_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book_name";
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(297, 150);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Old_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 401);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Book_name);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.old_name);
            this.Controls.Add(this.label1);
            this.Name = "Old_Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Old_Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old_name;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox Book_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search_btn;
    }
}