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
	public partial class DashBoard : Form
	{
		public DashBoard()
		{
			InitializeComponent();
		}

		private void ALLTeamsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Category_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void PlayerName_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		public static DataTable distinctCategories, distinctTeam;
		private void DashBoard_Load(object sender, EventArgs e)
		{
			distinctCategories = db.Get.getDistinctCategory(Global.sessionID);


			Category.DataSource = distinctCategories;
			Category.DisplayMember = "PlayerCategory";
			Category.ValueMember = "PlayerCategory";

			Category.SelectedIndex = -1;

			PlayerName.Enabled = false;

			SessionDataTxtBox.Text = Global.sessionID.ToString();
			ALLTeamsComboBox.DataSource = db.Get.getTeamsParticipating(Global.sessionID); ;
			ALLTeamsComboBox.DisplayMember = "TeamName";
			DataTable existingRound = db.Get.getActiveRoundInfo();
			if (existingRound != null && existingRound.Rows.Count > 0)
			{
				Global.roundID = existingRound.Rows[0]["RoundID"].ToString();
				Global.sessionID = existingRound.Rows[0]["SessionID"].ToString();

				//ShowLotteryResult.Enabled = true;
				Global.allowAccessToLottery = false;
				Global.allowAccessToSelectPlayer = true;
			}
			else
			{
				//ShowLotteryResult.Enabled = false;
				Global.allowAccessToLottery = true;
				Global.allowAccessToSelectPlayer = false;

			}



		}
	}
}
