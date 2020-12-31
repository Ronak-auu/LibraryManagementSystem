using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class bookRecord : Form
    {
        public bookRecord()
        {
            InitializeComponent();
        }

        private void bookRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khokhaniDataSet1.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.khokhaniDataSet1.Transaction);
            int book_id = Int32.Parse(Transaction.book_id);
            int i = 0;
            // TODO: This line of code loads data into the 'khokhaniDataSet2.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.khokhaniDataSet1.Transaction);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                i++;
                // back.Text = dataGridView1.Rows.Count+"";
                if ((row.Cells[2].Value + "").Equals(book_id + "") || i == dataGridView1.Rows.Count)
                {

                }
                else
                {

                    dataGridView1.Rows.Remove(row);


                }


            }
            dataGridView1.Update();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Transaction formstd = new Transaction();
            this.Hide();
            formstd.Show();
        }
    }
}
