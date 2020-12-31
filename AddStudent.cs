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
    public partial class AddStudent : Form
    {
        SqlConnection con;
        string name, collegeId, contactNo, email, dep;
        Decimal sem;

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Student formstd = new Student();
            this.Hide();
            formstd.Show();
        }

        private void department_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        String dob;


        public AddStudent()
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
            //con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
            InitializeComponent();
        }
        
        private void addstudent_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=khokhani;Integrated Security=True;");
         //   con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
             name = textBox2.Text;
             collegeId = textBox4.Text;
             contactNo = textBox5.Text;
             email = textBox6.Text;
             dep = department.Text;
             sem = numericUpDown1.Value;
             dob = monthCalendar1.SelectionRange.Start.ToShortDateString();



            using (con)
            {
                string command = "INSERT INTO Student(Name,Department,Semester,College_id,ContactNo,Email,Birthdate)VALUES(@Name,@Department,@Semester,@College_id,@ContactNo,@Email,@Birthdate)";
                SqlCommand cmd = new SqlCommand(command, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Department", dep);
                cmd.Parameters.AddWithValue("@Semester", sem);
                cmd.Parameters.AddWithValue("@College_id", collegeId);
                cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Birthdate", dob);


                con.Open();

 
                cmd.ExecuteNonQuery();
            }
            Student formname = new Student();
            this.Hide();
            formname.Show();
        }
    }
}
