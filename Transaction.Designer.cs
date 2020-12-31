namespace LibrarySystem
{
    partial class Transaction
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
            this.book = new System.Windows.Forms.TextBox();
            this.student = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(646, 222);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(194, 26);
            this.book.TabIndex = 0;
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(646, 95);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(192, 26);
            this.student.TabIndex = 1;
            this.student.UseWaitCursor = true;
            this.student.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Issue",
            "Renew",
            "Return"});
            this.comboBox1.Location = new System.Drawing.Point(646, 380);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 65);
            this.button1.TabIndex = 3;
            this.button1.Text = "Student History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.student_record);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "View All Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.view_record);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1021, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 65);
            this.button3.TabIndex = 5;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.submit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transaction type";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 521);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 65);
            this.button4.TabIndex = 9;
            this.button4.Text = "Book History";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.book_history);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(26, 21);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(145, 46);
            this.back.TabIndex = 10;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 700);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.student);
            this.Controls.Add(this.book);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox book;
        private System.Windows.Forms.TextBox student;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button back;
    }
}