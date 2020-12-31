namespace LibrarySystem
{
    partial class ViewAllRecords
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.khokhaniDataSet1 = new LibrarySystem.khokhaniDataSet1();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTableAdapter = new LibrarySystem.khokhaniDataSet1TableAdapters.TransactionTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renewdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khokhaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.bookidDataGridViewTextBoxColumn,
            this.issuedateDataGridViewTextBoxColumn,
            this.renewdateDataGridViewTextBoxColumn,
            this.returndateDataGridViewTextBoxColumn,
            this.transactiondateDataGridViewTextBoxColumn,
            this.seenDataGridViewTextBoxColumn,
            this.penultyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-10, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1400, 567);
            this.dataGridView1.TabIndex = 1;
            // 
            // khokhaniDataSet1
            // 
            this.khokhaniDataSet1.DataSetName = "khokhaniDataSet1";
            this.khokhaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.khokhaniDataSet1;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "studentid";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "studentid";
            this.studentidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "bookid";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "bookid";
            this.bookidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.Width = 150;
            // 
            // issuedateDataGridViewTextBoxColumn
            // 
            this.issuedateDataGridViewTextBoxColumn.DataPropertyName = "issuedate";
            this.issuedateDataGridViewTextBoxColumn.HeaderText = "issuedate";
            this.issuedateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.issuedateDataGridViewTextBoxColumn.Name = "issuedateDataGridViewTextBoxColumn";
            this.issuedateDataGridViewTextBoxColumn.Width = 150;
            // 
            // renewdateDataGridViewTextBoxColumn
            // 
            this.renewdateDataGridViewTextBoxColumn.DataPropertyName = "renewdate";
            this.renewdateDataGridViewTextBoxColumn.HeaderText = "renewdate";
            this.renewdateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.renewdateDataGridViewTextBoxColumn.Name = "renewdateDataGridViewTextBoxColumn";
            this.renewdateDataGridViewTextBoxColumn.Width = 150;
            // 
            // returndateDataGridViewTextBoxColumn
            // 
            this.returndateDataGridViewTextBoxColumn.DataPropertyName = "returndate";
            this.returndateDataGridViewTextBoxColumn.HeaderText = "returndate";
            this.returndateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.returndateDataGridViewTextBoxColumn.Name = "returndateDataGridViewTextBoxColumn";
            this.returndateDataGridViewTextBoxColumn.Width = 150;
            // 
            // transactiondateDataGridViewTextBoxColumn
            // 
            this.transactiondateDataGridViewTextBoxColumn.DataPropertyName = "transactiondate";
            this.transactiondateDataGridViewTextBoxColumn.HeaderText = "transactiondate";
            this.transactiondateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactiondateDataGridViewTextBoxColumn.Name = "transactiondateDataGridViewTextBoxColumn";
            this.transactiondateDataGridViewTextBoxColumn.Width = 150;
            // 
            // seenDataGridViewTextBoxColumn
            // 
            this.seenDataGridViewTextBoxColumn.DataPropertyName = "seen";
            this.seenDataGridViewTextBoxColumn.HeaderText = "seen";
            this.seenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seenDataGridViewTextBoxColumn.Name = "seenDataGridViewTextBoxColumn";
            this.seenDataGridViewTextBoxColumn.Width = 150;
            // 
            // penultyDataGridViewTextBoxColumn
            // 
            this.penultyDataGridViewTextBoxColumn.DataPropertyName = "penulty";
            this.penultyDataGridViewTextBoxColumn.HeaderText = "penulty";
            this.penultyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.penultyDataGridViewTextBoxColumn.Name = "penultyDataGridViewTextBoxColumn";
            this.penultyDataGridViewTextBoxColumn.Width = 150;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(251, 46);
            this.back.TabIndex = 2;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ViewAllRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 684);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewAllRecords";
            this.Text = "ViewAllRecords";
            this.Load += new System.EventHandler(this.ViewAllRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khokhaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private khokhaniDataSet1 khokhaniDataSet1;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private khokhaniDataSet1TableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn renewdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returndateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn penultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button back;
    }
}