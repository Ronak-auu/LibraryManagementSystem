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
    public partial class Student : Form
    {
        SqlConnection con;
        public Student()
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            InitializeComponent();
            //con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");

        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            // TODO: This line of code loads data into the 'libraryManagementSystemDataSet1.Student' table. You can move, or remove it, as needed.
            //  this.studentTableAdapter.Fill(this.khokhaniDataSet.Student);
            this.studentTableAdapter2.FillBy(this.khokhaniDataSet.Student);
            // con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
            //con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False");
        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //this.studentTableAdapter.Update(this.libraryManagementSystemDataSet1);
            //this.studentTableAdapter2.Update(this.khokhaniDataSet);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // string selected_id = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            string selected_id = dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value.ToString();
            string delete_row = "delete  from Student where Id = " + selected_id;

            con.Open();
            SqlCommand cmd = new SqlCommand(delete_row, con);
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.DeleteCommand = new SqlCommand(delete_row, con);
            adapter.DeleteCommand.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();

            Student formName = new Student();
            this.Hide();
            formName.Show();

        }

        private void studentBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void add_new(object sender, EventArgs e)
        {
            AddStudent formname = new AddStudent();
            this.Hide();
            formname.Show();
        }

        private void ViewStudent_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khokhaniDataSet1.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this.khokhaniDataSet1.Student);

        }

        private void updateStudent(object sender, EventArgs e)
        {
            this.studentTableAdapter2.Update(this.khokhaniDataSet1);
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

        private void search(object sender, EventArgs e)
        {
            string name = "*";
            string dep = "*";
            string sem = "*";

            name = textBox1.Text;
            DataTable dt = new DataTable();
            if (textBox1.Text.Length == 0 && comboBox1.Text.Length == 0 && comboBox2.Text.Length == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length != 0 && comboBox1.Text.Length == 0 && comboBox2.Text.Length == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student WHERE [Name] LIKE '" + name + "%'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length == 0 && comboBox1.Text.Length > 0 && comboBox2.Text.Length > 0)
            {
                sem = comboBox1.Text;
                dep = comboBox2.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student WHERE Department = '" + dep + "' AND Semester = '" + sem + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length != 0 && comboBox2.Text.Length > 0)
            {
                dep = comboBox2.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student WHERE [Name] LIKE '" + name + "%' AND Department = '" + dep + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length != 0 && comboBox1.Text.Length > 0)
            {
                sem = comboBox1.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student WHERE [Name] LIKE '" + name + "%' AND Semester = '" + sem + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length == 0 && comboBox2.Text.Length > 0)
            {
                dep = comboBox2.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student WHERE Department = '" + dep + "'", con);
                sda.Fill(dt);
            }
            else if (textBox1.Text.Length == 0 && comboBox1.Text.Length > 0)
            {
                sem = comboBox1.Text;
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Student WHERE Semester = '" + sem + "'", con);
                sda.Fill(dt);
            }


            dataGridView1.DataSource = dt;
            //this.studentTableAdapter2.Update(this.khokhaniDataSet1);
        }
    
    }
}
