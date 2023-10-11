﻿using EventController.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventController
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Register());
			//Application.Run(new Login());
			//Application.Run(new AddTeams());
			// Application.Run(new AllPlayers());
			//Application.Run(new TeamLotterySelection());
			Application.Run(new StartSession());
			//Application.Run(new HighlightPlayer());
			//Application.Run(new UploadPlayerPicture());
			//Application.Run(new AddTeams());
		}
	}
}
