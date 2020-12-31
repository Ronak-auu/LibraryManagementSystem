using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Records : Form
    {
        SqlConnection con;
        public Records()
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            InitializeComponent();
        }

        private void Records_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khokhaniDataSet1.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.khokhaniDataSet1.Transaction);
            int student_id = Int32.Parse(Transaction.student_id);
            int i = 0;
            // TODO: This line of code loads data into the 'khokhaniDataSet2.Transaction' table. You can move, or remove it, as needed.
           // this.transactionTableAdapter.Fill(this.khokhaniDataSet1.Transaction);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                i++;
               // back.Text = dataGridView1.Rows.Count+"";
                if ((row.Cells[1].Value + "").Equals(student_id+"") || i == dataGridView1.Rows.Count)
                {
                   
                }
                else
                {
                   
                    dataGridView1.Rows.Remove(row);
                    
                   
                }
              
                
            }
            dataGridView1.Update();
            //this.transactionTableAdapter.Update(this.khokhaniDataSet1.Transaction);
                //  this.transactionTableAdapter.Fill(this.khokhaniDataSet1.Transaction);
            //  back.Text = student_id + "";

        }
      

        private void transactionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back(object sender, EventArgs e)
        {
            Transaction formstd = new Transaction();
            this.Hide();
            formstd.Show();
        }

        private void khokhaniDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
