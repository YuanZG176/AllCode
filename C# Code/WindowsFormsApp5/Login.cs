using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.txbUsername.Text;
            string password = this.txbPassword.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("please enter first!");
                return;
            }

            //whether is the administrator
            if (username == "Admin" && password == "123")
            {
                //log successful , enter the main form
                Form1 mainForm = new Form1();
                // this.Hide(); //hide the Login Form
                mainForm.FormClosed += new FormClosedEventHandler(MyFormClosed);
                mainForm.Show(this); //show the main Form
                this.Hide();
                
            }
            else
                MessageBox.Show("Incorrect username or password!");
        }
        public void MyFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2;
            this.Top = Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2;
        }

    }
}
