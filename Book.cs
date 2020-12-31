using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ManageBook : Form
    {
        SqlConnection con;
        SqlDataReader dreader;
        public ManageBook()
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            // con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
            InitializeComponent();
        }

        private void ManageBook_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter1.Fill(this.khokhaniDataSet.Book);
            // con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");

        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //this.bookTableAdapter.Update(this.libraryManagementSystemDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected_id = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString();

            string delete_row = "delete  from Book where Id = " + selected_id;
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand(delete_row, con);
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.DeleteCommand = new SqlCommand(delete_row, con);
            adapter.DeleteCommand.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            ManageBook formName = new ManageBook();
            this.Hide();
            formName.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public Boolean updateByTransaction(int book_id)
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            string query = "UPDATE Book set Status = 0 where Id = " + book_id;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            

            cmd.ExecuteNonQuery();
            this.bookTableAdapter1.Update(this.khokhaniDataSet);
            //string id = dataGridView1.Rows[book_id].Cells[0].Text;
            return true;
        }
        public Boolean IssueByTransaction(int book_id)
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            string query = "UPDATE Book set Status = 1 where Id = " + book_id;
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);


            cmd.ExecuteNonQuery();
            this.bookTableAdapter1.Update(this.khokhaniDataSet);
            //string id = dataGridView1.Rows[book_id].Cells[0].Text;
            return true;
        }
        public int StatusOfBook(int book_id)
        {
            string query = "Select * from Book  where Id = " + book_id;
            //
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            using (con)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);


                dreader = cmd.ExecuteReader();
                if (dreader.Read())
                {
                    if ((dreader[2].ToString()).Equals(1 + ""))
                    {
                       
                        return 1;
                    }
                    else if((dreader[5].ToString()).Equals(1 + ""))
                    {
                       
                        return 2;
                        
                    }
                    else
                        return 0;
                }
                return 4;
            }
            
            
        }
        private void updateBook(object sender, EventArgs e)
        {
            this.bookTableAdapter1.Update(this.khokhaniDataSet);
        }

        private void addBook(object sender, EventArgs e)
        {
            AddBook formname = new AddBook();
            this.Hide();
            formname.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home formstd = new Home();
            this.Hide();
            formstd.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = "*";
            string author = "*";
            string category = "*";

            name = textBox1.Text;
            DataTable dt = new DataTable();
            if (textBox1.Text.Length == 0 && comboBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Book", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length != 0 && comboBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Book WHERE [Title] LIKE '" + name + "%'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length == 0 && comboBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                category = comboBox1.Text;
                author = textBox2.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Book WHERE Author = '" + author + "' AND Category = '" + category + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length != 0 && textBox2.Text.Length > 0)
            {
                author = textBox2.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Book WHERE [Title] LIKE '" + name + "%' AND Author = '" + author + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length != 0 && comboBox1.Text.Length > 0)
            {
                category = comboBox1.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Book WHERE [Title] LIKE '" + name + "%' AND Category = '" + category + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length == 0 && textBox2.Text.Length > 0)
            {
                author = textBox2.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Book WHERE Author = '" + author + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length == 0 && comboBox1.Text.Length > 0)
            {
                category = comboBox1.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Book WHERE Category = '" + category + "'", con);
                sda.Fill(dt);
            }


            dataGridView1.DataSource = dt;
        }
    }
}
