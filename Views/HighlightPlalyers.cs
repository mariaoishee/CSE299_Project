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
    public partial class HighlightPlalyers : Form
    {
        public HighlightPlalyers()
        {
            InitializeComponent();
            Models.PlayerCombinedModel player = db.Get.GetCombinedPlayerDataByID(ProjectionController.highlightPlayerID);

            pictureBox1.BackColor = Color.Transparent;

            playerBannerPic.ImageLocation = @"C:\CSE299_EventController_Images\" + player.BannerPic + ".png";
            PlayerBatStatPic.ImageLocation = @"C:\CSE299_EventController_Images\" + player.BatStat + ".png";
            PlayerBowlStatPic.ImageLocation = @"C:\CSE299_EventController_Images\" + player.BowlStat + ".png";

            ResizePictureBox(PlayerBatStatPic, 818, 318);
            ResizePictureBox(PlayerBowlStatPic, 818, 318);


            BatSkill.Text = player.Batting_hand;
            BowlSkill.Text = player.Bowling_skill;
            string dobString = player.DOB;

            DateTime dob = DateTime.Parse(dobString);

            DOB.Text = dob.ToString("dd/MM/yyyy");

            Country.Text = player.Country_Name;
        }
        private void ResizePictureBox(PictureBox pictureBox, int width, int height)
        {
            pictureBox.Size = new Size(width, height);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void HighlightPlalyers_Load(object sender, EventArgs e)
        {
            best3.Items.Clear(); // Clear existing items
            List<BatsmanStatModel> batsmanStats = db.Get.GetTopBatsmanStats(ProjectionController.highlightPlayerID);
            foreach (var batsmanStat in batsmanStats)
            {
                ListViewItem item = new ListViewItem(
                  batsmanStat.MatchDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(batsmanStat.Balls.ToString());
                item.SubItems.Add(batsmanStat.Runs.ToString());
                item.SubItems.Add(batsmanStat.Sixes.ToString());
                item.SubItems.Add(batsmanStat.Fours.ToString());
                item.SubItems.Add(batsmanStat.Dots.ToString());
                item.SubItems.Add(batsmanStat.StrikeRate.ToString());

                best3.Items.Add(item);
            }


            worst3.Items.Clear(); // Clear existing items
            batsmanStats = db.Get.GetBotBatsmanStats(ProjectionController.highlightPlayerID);
            foreach (var batsmanStat in batsmanStats)
            {
                ListViewItem item = new ListViewItem(batsmanStat.MatchDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(batsmanStat.Balls.ToString());
                item.SubItems.Add(batsmanStat.Runs.ToString());
                item.SubItems.Add(batsmanStat.Sixes.ToString());
                item.SubItems.Add(batsmanStat.Fours.ToString());
                item.SubItems.Add(batsmanStat.Dots.ToString());
                item.SubItems.Add(batsmanStat.StrikeRate.ToString());

                worst3.Items.Add(item);
            }

            last3.Items.Clear(); // Clear existing items
            batsmanStats = db.Get.GetLast3BatsmanStats(ProjectionController.highlightPlayerID);
            foreach (var batsmanStat in batsmanStats)
            {
                ListViewItem item = new ListViewItem(batsmanStat.MatchDate.ToString("dd/MM/yyyy"));
                item.SubItems.Add(batsmanStat.Balls.ToString());
                item.SubItems.Add(batsmanStat.Runs.ToString());
                item.SubItems.Add(batsmanStat.Sixes.ToString());
                item.SubItems.Add(batsmanStat.Fours.ToString());
                item.SubItems.Add(batsmanStat.Dots.ToString());
                item.SubItems.Add(batsmanStat.StrikeRate.ToString());

                last3.Items.Add(item);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
