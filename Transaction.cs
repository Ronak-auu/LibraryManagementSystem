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
    public partial class Transaction : Form
    {
        public static string student_id="";
        public static string book_id="";
        public static string transaction_type="";
        public Transaction()
        {
            InitializeComponent();
        }

        private void view_record(object sender, EventArgs e)
        {
            student_id = student.Text;
            book_id = book.Text;

            
            ViewAllRecords formstd = new ViewAllRecords();
            this.Hide();
            formstd.Show();
        }

        private void student_record(object sender, EventArgs e)
        {
            student_id = student.Text;
            book_id = book.Text;

           
            Records formstd = new Records();
            this.Hide();
            formstd.Show();
        }

        private void submit(object sender, EventArgs e)
        {
            student_id = student.Text;
            book_id = book.Text;
            
            transaction_type = comboBox1.Text;
            if (student_id == null)
            {
                MessageBox.Show("Please enter student id");
            }
           else  if (book_id == null)
            {
                MessageBox.Show("Please enter book id");
            }
            else if (transaction_type == null)
            {
                MessageBox.Show("Please select transaction type");
            }
            else
            {
                doTransaction formstd = new doTransaction();

                formstd.Show();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_history(object sender, EventArgs e)
        {
            student_id = student.Text;
            book_id = book.Text;

           
            bookRecord formstd = new bookRecord();
            this.Hide();
            formstd.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home formstd = new Home();
            this.Hide();
            formstd.Show();
        }
    }
}
