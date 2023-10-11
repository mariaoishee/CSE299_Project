using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventController
{
    internal class Models
    {

		public class Team
		{
			public int TeamID { get; set; }
			public string TeamName { get; set; }
			public string Image { get; set; }
			public string Banner { get; set; }
			public string OwnerImage { get; set; }
			public string OwnerName { get; set; }
			public string ManagerImage { get; set; }
			public string ManagerName { get; set; }
			public DateTime DateTime { get; set; }
			public string TeamShortName { get; set; }
		}

		public class PlayerModel
        {
            public string Player_SK { get; set; }
            public string Player_Id { get; set; }
            public string Player_Name { get; set; }
            public string DOB { get; set; }
            public string Batting_hand { get; set; }
            public string Bowling_skill { get; set; }
            public string Country_Name { get; set; }
        }

        public class PlayerCombinedModel
        {
            public string Player_SK { get; set; }
            public string ProfilePic { get; set; }
            public string BannerPic { get; set; }
            public string BatStat { get; set; }
            public string BowlStat { get; set; }
            public string Player_Id { get; set; }
            public string Player_Name { get; set; }
            public string DOB { get; set; }
            public string Batting_hand { get; set; }
            public string Bowling_skill { get; set; }
            public string Country_Name { get; set; }
        }

        public class BatsmanStatModel
        {
            public DateTime MatchDate { get; set; }
            public int PlayerID { get; set; }
            public string PlayerName { get; set; }
            public int MatchID { get; set; }
            public int Balls { get; set; }
            public int Runs { get; set; }
            public int Sixes { get; set; }
            public int Fours { get; set; }
            public int Dots { get; set; }
            public decimal StrikeRate { get; set; }
            public string TeamVs { get; set; }
        }


    }
}
