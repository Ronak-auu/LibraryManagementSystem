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
    public partial class AddBook : Form
    {
        SqlConnection con;
        public AddBook()
        {

            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            // con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            //con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox1.Text;
            string author = textBox2.Text;
            string publisher = textBox3.Text;
            string category = comboBox1.Text;
            int reserve;
            int status = 0;
            if (comboBox2.Text.Equals("Student"))
                reserve = 0;
            else
                reserve = 1;
            using (con)
            {
                string command = "INSERT INTO Book(Title,Status,Publisher,Author,Reserve,Category)VALUES(@Title,@Status,@Publisher,@Author,@Reserve,@Category)";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Publisher", publisher);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Reserve", reserve);
                cmd.Parameters.AddWithValue("@Category", category);

                con.Open();



                cmd.ExecuteNonQuery();
            }

            ManageBook formname = new ManageBook();
            this.Hide();
            formname.Show();

        }

        private void back_Click(object sender, EventArgs e)
        {
            ManageBook formstd = new ManageBook();
            this.Hide();
            formstd.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
