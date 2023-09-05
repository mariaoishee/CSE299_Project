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
    public partial class AddTeams : Form
    {
        public AddTeams()
        {
            InitializeComponent();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void cls()
        {
            TeamNameTxtBox.Text = "";
            TeamShortNameTxtBox.Text = "" ;
            OwnerNameTxtBox.Text = "" ;
            ManagerNameTxtBox.Text = "" ;

            LocationTeamImg.Text = "" ;
            LocationBannerImg.Text  = "";
            LocationOwnerImg.Text = "" ;
            LocationManagerImg.Text =  "";
        }
        private bool isValid()
        {
            if (
                    TeamNameTxtBox.Text == "" ||
                    TeamShortNameTxtBox.Text == "" ||
                    OwnerNameTxtBox.Text == "" ||
                    ManagerNameTxtBox.Text == "" ||

                    LocationTeamImg.Text == "" ||
                    LocationBannerImg.Text == "" ||
                    LocationOwnerImg.Text == "" ||
                    LocationManagerImg.Text == ""
                )
                return false;
             return true;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {

                string teamImg = Global.GenarateHash(), bannerImg = Global.GenarateHash(),
                   ownerImg = Global.GenarateHash(), managerImg = Global.GenarateHash();

                db.Post.InsertNewTeam(Global.GenarateHash(), TeamNameTxtBox.Text, teamImg, bannerImg, ownerImg,
                    OwnerNameTxtBox.Text, managerImg, ManagerNameTxtBox.Text, TeamShortNameTxtBox.Text);
                Global.FileTrasfer(LocationTeamImg.Text, teamImg);
                Global.FileTrasfer(LocationBannerImg.Text, bannerImg);
                Global.FileTrasfer(LocationOwnerImg.Text, ownerImg);
                Global.FileTrasfer(LocationManagerImg.Text, managerImg);

                cls();
            }
            else
            {
                MessageBox.Show("Enter Every Info");
            }
        }

        private void TeamImageBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                //Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                Filter = "Images (*.PNG)|*.PNG",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LocationTeamImg.Text = openFileDialog.FileName;
            }
        }

        private void BannerImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                //Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                Filter = "Images (*.PNG)|*.PNG",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LocationBannerImg.Text = openFileDialog.FileName;
            }
        }

        private void OwnerImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                //Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                Filter = "Images (*.PNG)|*.PNG",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LocationOwnerImg.Text = openFileDialog.FileName;
            }
        }

        private void ManagerImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "jpg",
                //Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF",
                Filter = "Images (*.PNG)|*.PNG",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LocationManagerImg.Text = openFileDialog.FileName;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
