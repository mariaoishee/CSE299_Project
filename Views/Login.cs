using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventController.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void clr()
        {
            EmailTxtBox.Text = "";
            PassTxtBox.Text = "";
        }

        private bool isValid()
        {
            if (EmailTxtBox.Text == "" ||  PassTxtBox.Text == "")
                return false;
            return true;
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;

            bool found = db.Get.LoginAuth(EmailTxtBox.Text, PassTxtBox.Text);
            if (found)
            {
                MessageBox.Show("Login Success");
                clr();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
