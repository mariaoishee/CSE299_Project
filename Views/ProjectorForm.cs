using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static EventController.Models;

namespace EventController.Views
{
    public partial class ProjectorForm : Form
    {
        public ProjectorForm()
        {
            InitializeComponent();
            timer1.Start();
            this.Shown += ProjectorForm_Shown;
        }
        private void ProjectorForm_Shown(object sender, EventArgs e)
        {
            // Get the second screen (if available)
            Screen[] screens = Screen.AllScreens;
            if (screens.Length > 1)
            {
                // Set the location and size to cover the entire second screen
                this.Location = screens[0].WorkingArea.Location;
                this.Size = screens[0].WorkingArea.Size;
            }
        }

        public static string nowActive = "";
        AllPlayers allPlaeyers = new AllPlayers();  HighlightPlalyers highlight;
        private void ProjectorForm_Load(object sender, EventArgs e)
        {
            if(nowActive != ProjectionController.ActiveForm)
            {
                switch(ProjectionController.ActiveForm)
                {
                    case "AllPlayers":
                        CloseActiveForm();
                        allPlaeyers.Close();
                        allPlaeyers = new AllPlayers();
                        allPlaeyers.TopLevel = false;
                        allPlaeyers.FormBorderStyle = FormBorderStyle.None;
                        this.Controls.Add(allPlaeyers);
                        allPlaeyers.Show();

                        nowActive = ProjectionController.ActiveForm;

                        break;
                    case "HighlightPlayer":
                        CloseActiveForm();
                        if(highlight != null)
                            highlight.Close();
                        highlight = new HighlightPlalyers();
                        highlight.TopLevel = false;
                        highlight.FormBorderStyle = FormBorderStyle.None;
                        highlight.Show();
                        this.Controls.Add(highlight);
                        break;
                    case "":
                        break;
                    default:
                        break;
                }
            }
        }



        private void CloseActiveForm()
        {
            switch(nowActive)
            {
                case "AllPlayers":
                    allPlaeyers.Hide();
                    break;
                case "HighlightPlayer":
                    highlight.Close();
                    break;
            }
        }

        private void ProjectorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                else
                    this.FormBorderStyle = FormBorderStyle.None;
            }
        }
    }
}
