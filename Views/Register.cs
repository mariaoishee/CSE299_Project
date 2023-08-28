using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventController.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void clr()
        {
            NameTxtBox.Text = ""; EmailTxtBox.Text = "";
            AddressTxtBox.Text = ""; PhoneTxtBox.Text = "";
            NidTxtBox.Text = ""; PassTxtBox.Text = "";
            ConfirmPassTxtBox.Text = "";
        }

        private bool checkPassword()
        {
            if (PassTxtBox.Text == ConfirmPassTxtBox.Text)
            {
                return true;
            }
            return false;
        }

        private bool isValid()
        {
            if (
                NameTxtBox.Text == "" || EmailTxtBox.Text == "" ||
            AddressTxtBox.Text == "" || PhoneTxtBox.Text == "" ||
            NidTxtBox.Text == "" || PassTxtBox.Text == "" ||
            ConfirmPassTxtBox.Text == ""
                ) {
                return false;
            }
            return true;
        }

        WaitFormFunc waitForm = new WaitFormFunc();
        public void sendWelcomeEmail()
        {
            try
            {
                waitForm.show(this);


                SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;

                System.Net.NetworkCredential credential = new System.Net.NetworkCredential("eventController@hotmail.com", "event123");
                client.EnableSsl = true;
                client.Credentials = credential;

                MailMessage message = new MailMessage("eventController@hotmail.com", EmailTxtBox.Text);
                message.Subject = "Welcome to BPL Event Management Panel";

                message.Body = Email.sendWelcome();
                message.IsBodyHtml = true;
                client.Send(message);

                waitForm.Close();

            }
            catch (Exception)
            {
                throw;
            }



            clr();
            _ = MessageBox.Show("Email Sent");
        }



        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (isValid()) {
                if (checkPassword())
                {
                    sendWelcomeEmail();
                    //db.Post.InsertNewAdminDetails(
                    //            Global.GenarateHash(), NameTxtBox.Text, EmailTxtBox.Text,
                    //            AddressTxtBox.Text, PhoneTxtBox.Text, NidTxtBox.Text, PassTxtBox.Text);
                    clr();
                    MessageBox.Show("Your Account Is Created!");
                }
                else
                {
                    MessageBox.Show("The passwords do not match");
                }
            }

        }
    }
}
