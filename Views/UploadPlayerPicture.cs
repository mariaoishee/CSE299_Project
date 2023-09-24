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
    public partial class UploadPlayerPicture : Form
    {
        public UploadPlayerPicture()
        {
            InitializeComponent();
        }

        private void UploadPlayerPicture_Load(object sender, EventArgs e)
        {
            DataTable cTab = db.Get.GetPlayerDataTable();
            PlayerNameCombo.DataSource = cTab;
            PlayerNameCombo.DisplayMember = "Player_Name";
            PlayerNameCombo.ValueMember = "PLAYER_SK";

            PlayerNameCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            PlayerNameCombo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection CIDautoCompleteStringCollection = new AutoCompleteStringCollection();

            foreach (DataRow row in cTab.Rows)
            {
                CIDautoCompleteStringCollection.Add(row["Player_Name"].ToString());
            }

            PlayerNameCombo.AutoCompleteCustomSource = CIDautoCompleteStringCollection;

            PlayerNameCombo.SelectedIndex = -1;
        }

        private void PPButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

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
                PPLabel.Text = openFileDialog.FileName;
            }
        }

        private void BPbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

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
                BPLabel.Text = openFileDialog.FileName;
            }
        }

        private void Batbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

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
                Batlabel.Text = openFileDialog.FileName;
            }
        }

        private void Bowlbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Image Files",

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
                Bowllabel.Text = openFileDialog.FileName;
            }
        }
        private void cls()
        {
            PPLabel.Text = "Image Location";
            BPLabel.Text = "Image Location";
            Batlabel.Text = "Image Location";
            Bowllabel.Text = "Image Location";

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            cls();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string PPImg = Global.GenarateHash(), bannerImg = Global.GenarateHash(),
                  BatGrpImg = Global.GenarateHash(), BowlGrpImg = Global.GenarateHash();

            db.Post.InsertPlayerImage(PlayerNameCombo.SelectedValue.ToString(),PPImg,bannerImg,BatGrpImg,BowlGrpImg);

            Global.FileTrasfer(PPLabel.Text, PPImg);
            Global.FileTrasfer(BPLabel.Text, bannerImg);
            Global.FileTrasfer(Batlabel.Text, BatGrpImg);
            Global.FileTrasfer(Bowllabel.Text, BowlGrpImg);

            cls();
        }
    }
}
