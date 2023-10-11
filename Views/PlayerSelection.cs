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
    public partial class PlayerSelection : Form
    {
        public PlayerSelection()
        {
            InitializeComponent();

            DataTable dt = DB.Get.getSessionData(PlayerID);

            PlayerSessionDetailsBox.Text = "";
            PlayerSessionDetailsBox.AppendText(
                                        "ID:                            " + dt.Rows[0]["SessionID"].ToString() +
                                        "\r\nStatus:                      " + dt.Rows[0]["Status"].ToString() +
                                        "\r\nAdded By:                 " + dt.Rows[0]["AddedBy"].ToString()
                                        + "\r\nDate:                         " + ((DateTime)dt.Rows[0]["DateTime"]).ToString("dd/MM/yyyy")


                     );

            updatePlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {

                foreach (ListViewItem item in PlayerListViewBox.Items)
                {
                    if (item.Checked)
                    {
                        DataTable playerInfo = DB.Get.getPlayerDetails(item.SubItems[0].Text);

                        DB.Post.PostSessionDetailsData(sessionID, item.SubItems[0].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[5].Text, "0", "Afsana");
                    }
                }

                cls();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select participant");
            }
        }

       
    }
}
