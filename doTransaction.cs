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
    public partial class doTransaction : Form
    {
        SqlConnection con;
        String issue_date, renew_date, return_date, transaction_date;
         
        public doTransaction()
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            InitializeComponent();
        }

        private void doTransaction_Load(object sender, EventArgs e)
        {
            ManageBook bk = new ManageBook();

            this.transactionTableAdapter.Fill(this.khokhaniDataSet1.Transaction);
           
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
           
            int student_id =Int32.Parse(Transaction.student_id) ;
            int book_id =Int32.Parse(Transaction.book_id) ;
            string transaction_type = Transaction.transaction_type;
            int seen = 0;
            int penulty;
            DataTable dt = new DataTable();
            DateTime date, futureDate, tabeldate;
            date = System.DateTime.Now.Date;

            tabeldate = date;

            TimeSpan ts = tabeldate.Subtract(date);

            date = new DateTime(date.Year, date.Month, date.Day);

            String searchValue = student_id+"";
            String searchbook = book_id + "";
            int rowIndex = 1;
      
            

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                if (bk.StatusOfBook(book_id) != 0 && transaction_type.Equals("Issue"))
                {
                    if (bk.StatusOfBook(book_id) == 1)
                    {
                        MessageBox.Show("another Student  have already issued this book");
                    }
                    if (bk.StatusOfBook(book_id) == 2)
                    {
                        MessageBox.Show("This book is reserved for faculty member");
                    }
                    if (bk.StatusOfBook(book_id) == 4)
                    {
                        MessageBox.Show("Book with this id does not exist");
                    }
                    rowIndex = 0;
                    
                    this.Hide();
                }
                else
                {

                    if (((row.Cells[1].Value) + "").Equals(searchValue))
                    {
                        if (((row.Cells[2].Value) + "").Equals(searchbook))
                        {
                            rowIndex = 0;
                            if (transaction_type.Equals("Issue"))
                            {
                                MessageBox.Show("This book is already issued by  you ");

                                this.Hide();
                            }

                            else
                            {
                                if (transaction_type.Equals("Return"))
                                {

                                    bk.updateByTransaction(Int32.Parse(searchbook));
                                    return_date = System.DateTime.Now.Date.ToString();
                                    futureDate = date;
                                }
                                else
                                {

                                    return_date = row.Cells[5].Value.ToString();
                                    futureDate = date.AddDays(21);
                                }
                                issue_date = row.Cells[3].Value.ToString();

                                if (ts.Days > 0)
                                {


                                    penulty = 0;

                                }
                                else
                                    penulty = ts.Days * 30;

                                using (con)
                                {
                                    string command = "INSERT INTO [Transaction](studentId,bookId,issueDate,renewDate,returnDate,transactionDate," +
                                        "seen, penulty)VALUES(@studentid,@bookid,@issuedate,@renewdate,@returndate,@transactiondate,@seen,@penulty)";
                                    SqlCommand cmd = new SqlCommand(command, con);
                                    cmd.Parameters.AddWithValue("@studentid", student_id);
                                    cmd.Parameters.AddWithValue("@bookid", book_id);
                                    cmd.Parameters.AddWithValue("@issuedate", Convert.ToDateTime(issue_date).Date);
                                    cmd.Parameters.AddWithValue("@renewdate", futureDate.Date);
                                    cmd.Parameters.AddWithValue("@returndate", Convert.ToDateTime(return_date).Date);
                                    cmd.Parameters.AddWithValue("@transactiondate", System.DateTime.Now.Date);
                                    cmd.Parameters.AddWithValue("@seen", 1);
                                    cmd.Parameters.AddWithValue("@penulty", penulty);


                                    con.Open();


                                    cmd.ExecuteNonQuery();
                                }

                                dataGridView1.Update();
                                break;

                            }
                            //this.transactionTableAdapter.Update(this.khokhaniDataSet1.Transaction);

                        }



                    }
                }
                
            }
            if (rowIndex == 1)
            
            {
                if (transaction_type.Equals("Issue"))
                {
                    bk.IssueByTransaction(book_id);

                    futureDate = date.AddDays(21);
                    string command = "INSERT INTO [Transaction](studentId,bookId,issueDate,renewDate,returnDate,transactionDate," +
                                   "seen, penulty)VALUES(@studentid,@bookid,@issuedate,@renewdate,@returndate,@transactiondate,@seen,@penulty)";
                    SqlCommand cmd = new SqlCommand(command, con);
                    cmd.Parameters.AddWithValue("@studentid", student_id);
                    cmd.Parameters.AddWithValue("@bookid", book_id);
                    cmd.Parameters.AddWithValue("@issuedate", System.DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@renewdate", futureDate.Date);
                    cmd.Parameters.AddWithValue("@returndate", futureDate.AddDays(42));
                    cmd.Parameters.AddWithValue("@transactiondate", System.DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@seen", 1);
                    cmd.Parameters.AddWithValue("@penulty", 0);


                    con.Open();


                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Student have not issued this book with id" + searchbook);
                    this.Hide();
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Hide();
           
        }

        private void transactionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //this.transactionTableAdapter.Update(this.khokhaniDataSet2);
        }
    }
}
