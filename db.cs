using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EventController.Models;

namespace EventController
{
    internal class db
    {


        public static string Connection_String()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=cse299;User Id=ggwp;password=123;TrustServerCertificate=True";
        }

        public class Set
        {

        }

        public class Post
        {
            public static void InsertNewTeam(string TeamID, string TeamName, string Image, string Banner,
                string OwnerImage, string OwnerName, string ManagerImage, string ManagerName,
                string TeamShortName)
            {
                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertNewTeam", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TeamID", TeamID);
                        cmd.Parameters.AddWithValue("@TeamName", TeamName);
                        cmd.Parameters.AddWithValue("@Image", Image);
                        cmd.Parameters.AddWithValue("@Banner", Banner);
                        cmd.Parameters.AddWithValue("@OwnerImage", OwnerImage);
                        cmd.Parameters.AddWithValue("@OwnerName", OwnerName);
                        cmd.Parameters.AddWithValue("@ManagerImage", ManagerImage);
                        cmd.Parameters.AddWithValue("@ManagerName", ManagerName);
                        cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TeamShortName", TeamShortName);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            


            public static void InsertNewAdminDetails(
                string adminID, string name, string email, 
                string address, string phoneNumber, string nid, 
                string password
            )
            {
                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {
                    using (SqlCommand command = new SqlCommand("InsertNewAdminDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AdminID", adminID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@NID", nid);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@DateNTime", DateTime.Now);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
        }


        public class Get
        {
            public static List<BatsmanStatModel> GetLast3BatsmanStats(string playerID)
            {
                List<BatsmanStatModel> batsmanStats = new List<BatsmanStatModel>();

                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {


                    string query = @"WITH RankedMatches AS (
                                    SELECT
                                        [MatchID],
                                        [MatchDate],
                                        [PlayerID],
                                        [PlayerName],
                                        [Balls],
                                        [Runs],
                                        [Sixes],
                                        [Fours],
                                        [Dots],
                                        [StrikeRate],
                                        t1.TeamShortName + ' vs ' + t2.TeamShortName AS TeamVs,
                                        ROW_NUMBER() OVER (PARTITION BY [MatchID] ORDER BY Runs ASC, StrikeRate ASC) AS RowNum
                                    FROM
                                        [BatsmanStat]
                                    JOIN
                                        Player_match pm ON Match_Id = pm.Match_Id
                                    JOIN
                                        [TeamImport] t1 ON pm.Player_team = t1.Team_Name
                                    JOIN
                                        [TeamImport] t2 ON pm.Opposit_Team = t2.Team_Name
                                    WHERE
                                        PlayerID = " + (int.Parse(playerID) - 1) + @"
                                        AND Balls > (SELECT MAX(Balls) FROM BatsmanStat WHERE Runs = 0)
                                )

                                SELECT TOP 3 
                                    [MatchID],
                                    [MatchDate],
                                    [PlayerID],
                                    [PlayerName],
                                    [Balls],
                                    [Runs],
                                    [Sixes],
                                    [Fours],
                                    [Dots],
                                    [StrikeRate],
                                    TeamVs
                                FROM
                                    RankedMatches
                                WHERE
                                    RowNum = 1
	
                                ORDER BY
                                    MatchDate desc;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            BatsmanStatModel batsmanStat = new BatsmanStatModel
                            {
                                MatchDate = Convert.ToDateTime(reader["MatchDate"]),
                                PlayerID = Convert.ToInt32(reader["PlayerID"]),
                                PlayerName = reader["PlayerName"].ToString(),
                                MatchID = Convert.ToInt32(reader["MatchID"]),
                                Balls = Convert.ToInt32(reader["Balls"]),
                                Runs = Convert.ToInt32(reader["Runs"]),
                                Sixes = Convert.ToInt32(reader["Sixes"]),
                                Fours = Convert.ToInt32(reader["Fours"]),
                                Dots = Convert.ToInt32(reader["Dots"]),
                                StrikeRate = Convert.ToDecimal(reader["StrikeRate"]),
                                TeamVs = reader["TeamVs"].ToString()
                            };

                            batsmanStats.Add(batsmanStat);
                        }
                    }
                }

                return batsmanStats;
            }

            public static List<BatsmanStatModel> GetTopBatsmanStats(string playerID)
            {
                List<BatsmanStatModel> batsmanStats = new List<BatsmanStatModel>();

                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {


                    string query = @"WITH RankedMatches AS (
                                    SELECT
                                        [MatchID],
                                        [MatchDate],
                                        [PlayerID],
                                        [PlayerName],
                                        [Balls],
                                        [Runs],
                                        [Sixes],
                                        [Fours],
                                        [Dots],
                                        [StrikeRate],
                                        t1.TeamShortName + ' vs ' + t2.TeamShortName AS TeamVs,
                                        ROW_NUMBER() OVER (PARTITION BY [MatchID] ORDER BY Runs ASC, StrikeRate ASC) AS RowNum
                                    FROM
                                        [BatsmanStat]
                                    JOIN
                                        Player_match pm ON Match_Id = pm.Match_Id
                                    JOIN
                                        [TeamImport] t1 ON pm.Player_team = t1.Team_Name
                                    JOIN
                                        [TeamImport] t2 ON pm.Opposit_Team = t2.Team_Name
                                    WHERE
                                        PlayerID = " + (int.Parse(playerID) - 1) + @"
                                        AND Balls > (SELECT MAX(Balls) FROM BatsmanStat WHERE Runs = 0)
                                )

                                SELECT TOP 3 
                                    [MatchID],
                                    [MatchDate],
                                    [PlayerID],
                                    [PlayerName],
                                    [Balls],
                                    [Runs],
                                    [Sixes],
                                    [Fours],
                                    [Dots],
                                    [StrikeRate],
                                    TeamVs
                                FROM
                                    RankedMatches
                                WHERE
                                    RowNum = 1
	
                                ORDER BY
                                    Runs desc, StrikeRate desc;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            BatsmanStatModel batsmanStat = new BatsmanStatModel
                            {
                                MatchDate = Convert.ToDateTime(reader["MatchDate"]),
                                PlayerID = Convert.ToInt32(reader["PlayerID"]),
                                PlayerName = reader["PlayerName"].ToString(),
                                MatchID = Convert.ToInt32(reader["MatchID"]),
                                Balls = Convert.ToInt32(reader["Balls"]),
                                Runs = Convert.ToInt32(reader["Runs"]),
                                Sixes = Convert.ToInt32(reader["Sixes"]),
                                Fours = Convert.ToInt32(reader["Fours"]),
                                Dots = Convert.ToInt32(reader["Dots"]),
                                StrikeRate = Convert.ToDecimal(reader["StrikeRate"]),
                                TeamVs = reader["TeamVs"].ToString()
                            };

                            batsmanStats.Add(batsmanStat);
                        }
                    }
                }

                return batsmanStats;
            }

            public static List<BatsmanStatModel> GetBotBatsmanStats(string playerID)
            {
                List<BatsmanStatModel> batsmanStats = new List<BatsmanStatModel>();

                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {


                    string query = @"WITH RankedMatches AS (
                                    SELECT
                                        [MatchID],
                                        [MatchDate],
                                        [PlayerID],
                                        [PlayerName],
                                        [Balls],
                                        [Runs],
                                        [Sixes],
                                        [Fours],
                                        [Dots],
                                        [StrikeRate],
                                        t1.TeamShortName + ' vs ' + t2.TeamShortName AS TeamVs,
                                        ROW_NUMBER() OVER (PARTITION BY [MatchID] ORDER BY Runs ASC, StrikeRate ASC) AS RowNum
                                    FROM
                                        [BatsmanStat]
                                    JOIN
                                        Player_match pm ON Match_Id = pm.Match_Id
                                    JOIN
                                        [TeamImport] t1 ON pm.Player_team = t1.Team_Name
                                    JOIN
                                        [TeamImport] t2 ON pm.Opposit_Team = t2.Team_Name
                                    WHERE
                                        PlayerID = " +(int.Parse(playerID) -1)+@"
                                        AND Balls > (SELECT MAX(Balls) FROM BatsmanStat WHERE Runs = 0)
                                )

                                SELECT TOP 3 
                                    [MatchID],
                                    [MatchDate],
                                    [PlayerID],
                                    [PlayerName],
                                    [Balls],
                                    [Runs],
                                    [Sixes],
                                    [Fours],
                                    [Dots],
                                    [StrikeRate],
                                    TeamVs
                                FROM
                                    RankedMatches
                                WHERE
                                    RowNum = 1
	
                                ORDER BY
                                    Runs ASC, StrikeRate ASC;";
                  
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            BatsmanStatModel batsmanStat = new BatsmanStatModel
                            {
                                MatchDate = Convert.ToDateTime(reader["MatchDate"]),
                                PlayerID = Convert.ToInt32(reader["PlayerID"]),
                                PlayerName = reader["PlayerName"].ToString(),
                                MatchID = Convert.ToInt32(reader["MatchID"]),
                                Balls = Convert.ToInt32(reader["Balls"]),
                                Runs = Convert.ToInt32(reader["Runs"]),
                                Sixes = Convert.ToInt32(reader["Sixes"]),
                                Fours = Convert.ToInt32(reader["Fours"]),
                                Dots = Convert.ToInt32(reader["Dots"]),
                                StrikeRate = Convert.ToDecimal(reader["StrikeRate"]),
                                TeamVs = reader["TeamVs"].ToString()
                            };

                            batsmanStats.Add(batsmanStat);
                        }
                    }
                }

                return batsmanStats;
            }


            public static PlayerCombinedModel GetCombinedPlayerDataByID(string playerID)
            {
                PlayerCombinedModel player = null;

                string query = @"
                        SELECT TOP(16) PI.playerSK, PI.profilePic, PI.bannerPic, PI.batStat, PI.bowlStat,
                        P.Player_Id, P.Player_Name, P.DOB, P.Batting_hand, P.Bowling_skill, P.Country_Name 
                        FROM Player P
                        JOIN PlayerImage PI ON P.Player_SK = PI.playerSK 
                        WHERE [Player_Id] = @PlayerId";

                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PlayerId", playerID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                player = new PlayerCombinedModel
                                {
                                    Player_SK = reader["playerSK"].ToString(),
                                    ProfilePic = reader["profilePic"].ToString(),
                                    BannerPic = reader["bannerPic"].ToString(),
                                    BatStat = reader["batStat"].ToString(),
                                    BowlStat = reader["bowlStat"].ToString(),
                                    Player_Id = reader["Player_Id"].ToString(),
                                    Player_Name = reader["Player_Name"].ToString(),
                                    DOB = reader["DOB"].ToString(),
                                    Batting_hand = reader["Batting_hand"].ToString(),
                                    Bowling_skill = reader["Bowling_skill"].ToString(),
                                    Country_Name = reader["Country_Name"].ToString()
                                };
                            }
                        }
                    }
                }

                return player;
            }




            public static List<PlayerCombinedModel> GetCombinedPlayerData()
            {
                List<PlayerCombinedModel> players = new List<PlayerCombinedModel>();

                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {
                    string query = @"SELECT TOP(16) PI.playerSK, PI.profilePic, PI.bannerPic, PI.batStat, PI.bowlStat,
                                    P.Player_Id, P.Player_Name, P.DOB, P.Batting_hand, P.Bowling_skill, P.Country_Name FROM Player P
                                    JOIN PlayerImage PI ON P.Player_SK = PI.playerSK";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PlayerCombinedModel player = new PlayerCombinedModel
                                {
                                    Player_SK = reader["playerSK"].ToString(),
                                    ProfilePic = reader["profilePic"].ToString(),
                                    BannerPic = reader["bannerPic"].ToString(),
                                    BatStat = reader["batStat"].ToString(),
                                    BowlStat = reader["bowlStat"].ToString(),
                                    Player_Id = reader["Player_Id"].ToString(),
                                    Player_Name = reader["Player_Name"].ToString(),
                                    DOB = reader["DOB"].ToString(),
                                    Batting_hand = reader["Batting_hand"].ToString(),
                                    Bowling_skill = reader["Bowling_skill"].ToString(),
                                    Country_Name = reader["Country_Name"].ToString()
                                };

                                players.Add(player);
                            }
                        }
                    }
                }

                return players;
            }

            public static List<PlayerModel> GetAllPlayers()
            {
                List<PlayerModel> players = new List<PlayerModel>();

                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {
                    connection.Open();

                    string query = "SELECT TOP (1000) [PLAYER_SK], [Player_Id], [Player_Name], " +
                                   "[DOB], [Batting_hand], [Bowling_skill], [Country_Name] " +
                                   "FROM [cse299].[dbo].[Player]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                PlayerModel player = new PlayerModel
                                {
                                    Player_SK = (reader["PLAYER_SK"]).ToString(),
                                    Player_Id = reader["Player_Id"].ToString(),
                                    Player_Name = reader["Player_Name"].ToString(),
                                    DOB = (reader["DOB"]).ToString(),
                                    Batting_hand = reader["Batting_hand"].ToString(),
                                    Bowling_skill = reader["Bowling_skill"].ToString(),
                                    Country_Name = reader["Country_Name"].ToString()
                                };

                                players.Add(player);
                            }
                        }
                    }
                }

                return players;
            }


            public static bool LoginAuth(string email, string password)
            {
                using (SqlConnection con = new SqlConnection(db.Connection_String()))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT  '#' FROM [cse299].[dbo].[AdminDetails] where [Email]='" + email + "' and [Password]='" + password + "'", con))
                    {
                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            con.Close();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }
                    }

                }
            }
        }
    }
}
