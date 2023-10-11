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
	public partial class TeamLotterySelection : Form
	{
		public static int LotteryCount = 0;
		public TeamLotterySelection()
		{
			InitializeComponent();
			LotteryCount = 0;
		}

		private void TeamLotterySelection_Load(object sender, EventArgs e)
		{
			List<Team> allTeam = db.Get.GetAllTeams();
			TeamComboBox.DataSource = allTeam;
			TeamComboBox.DisplayMember = "TeamName";
			TeamComboBox.ValueMember = "TeamID";
			LotteryCount = 0;
		}

		private void Lottary_Click(object sender, EventArgs e)
		{
			LotteryCount++;
			ListViewItem varItem = new ListViewItem(new string[0]);
			DataRowView rVCat = RoundOrderComboBox1.SelectedItem as DataRowView;
			DataRowView rVTeam = TeamComboBox.SelectedItem as DataRowView;

			varItem = new ListViewItem(new string[]
							{
								SequenceNo.Text,
								TeamComboBox.Text,
								TeamComboBox.SelectedValue.ToString(),
							});
			listView.Items.Add(varItem);
		}

		public void cls()
		{

			LotteryCount = 0;
			RoundOrderComboBox.SelectedIndex = -1;
			TeamComboBox.SelectedIndex = -1;
			RoundOrderComboBox.Enabled = false;
			TeamComboBox.Enabled = false;
			listView.Items.Clear();
		}
		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
