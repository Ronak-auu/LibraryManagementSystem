using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Home : Form
    {
        
        public static int login = 0;
        public Home()
        {
            
            InitializeComponent();
            if (login == 1)
                button4.Text = "Logout";
        }

        private void books(object sender, EventArgs e)
        {
            if (login == 0)
                MessageBox.Show("Please Login into system before any action");
            else
            {
                ManageBook formstd = new ManageBook();
                this.Hide();
                formstd.Show();
            }
               
        }

        private void syudent(object sender, EventArgs e)
        {
            if (login == 0)
                MessageBox.Show("Please Login into system before any action");
            else
            {
                Student formstd = new Student();
                this.Hide();
                formstd.Show();
            }
        }

        private void faculty(object sender, EventArgs e)
        {
            if (button4.Text.Equals("Login"))
            {
                adminLogin formName = new adminLogin();
                this.Hide();
                formName.Show();
            }
            else
            {
                login = 0;
                button4.Text = "Login";
            }
        }

        
        private void transaction(object sender, EventArgs e)
        {
            if (login == 0)
                MessageBox.Show("Please Login into system before any action");
            else
            {
                Transaction formName = new Transaction();
                this.Hide();
                formName.Show();
            }
        }

        private void Login(object sender, EventArgs e)
        {
            if (button4.Text.Equals("Login"))
            {
                adminLogin formName = new adminLogin();
                this.Hide();
                formName.Show();
            }
            else
            {
                login = 0;
                button4.Text = "Login";
            }
        }
    }
}
