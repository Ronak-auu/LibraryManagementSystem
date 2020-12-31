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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void login(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("Admin"))
            {
                if (textBox1.Text.Equals("Admin"))
                {
                    Home.login = 1;
                    Home formName = new Home();
                    this.Hide();
                    
                    formName.Show();
                }
                else if (textBox1.Text.Length == 0)
                    MessageBox.Show("Paasword is required");
                else
                {
                    MessageBox.Show("Password is wrong");
                }
            }
            else if(textBox2.Text.Length == 0)
                MessageBox.Show("Username is required");
            else
                MessageBox.Show("Username is wrong");
        }

        private void back_Click(object sender, EventArgs e)
        {
            Home formstd = new Home();
            this.Hide();
            formstd.Show();
        }
    }
}
