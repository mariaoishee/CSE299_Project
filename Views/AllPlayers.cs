using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EventController.Models;

namespace EventController.Views
{
    public partial class AllPlayers : Form
    {
        public AllPlayers()
        {
            InitializeComponent();
        }

        private void AllPlayers_Load(object sender, EventArgs e)
        {

            int imgheight = 250;
            int imgwidth = 250;

            List<PlayerCombinedModel> AllPlayers = db.Get.GetCombinedPlayerData();
            int count = AllPlayers.Count;
            int SpaceBeforeLabel = 63;
            int[][] arr = ImgGrid.getImageGrid(16, 90, 120, imgheight, imgwidth, 300, 200, 2360, 1340);

            int i = 0;
            foreach (var player in AllPlayers)
            {
                ImgGrid.drawImages(this, count, arr[i][0], arr[i][1], imgheight, imgwidth, @"C:\CSE299_EventController_Images\" + player.ProfilePic, player.Player_Name, SpaceBeforeLabel);
                i++;
            }
            i = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
