using LakbayRilesPH.ClassFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

namespace LakbayRilesPH
{
    public class Admin
    {

        public static string CurrentTime()
        {
            var time = DateTime.Now;
            var sqlFormattedDate = time.ToString("yyyy-MM-dd HH:mm:ss");
            return sqlFormattedDate;
        }
        public static Boolean UpdateDatabase(LineStatus status)
        {
            var db = Database.Open("SQLAzureConnection");
            var updateQuery = "INSERT INTO LineStatus (Status, StatusTime, Supervisor) VALUES (@0, @1, @2)";
            var sqlFormattedDate = CurrentTime();

            var flag = db.Execute(updateQuery, status.Status, sqlFormattedDate, status.Supervisor);

            if (flag != 0)
                return true;
            else
                return false;

        }
        public static Boolean UpdateDatabase(int button, string direction, int id)
        {
            return query(button, direction, id);
        }

        public static Boolean UpdateDatabase(string title, string message, int stationID, string type)
        {
            return query(title, message, stationID, type);
        }
        // this is for the crowd volume / announcement
        private static Boolean query(string title, string message, int stationID, string type)
        {
            var db = Database.Open("SQLAzureConnection");
            var updateQuery = "";
            if (type == "station") { 
                updateQuery = "INSERT INTO StationAnnouncement(AnnouncementTitle, AnnouncementBody, Station, AnnouncementTime) VALUES(@0, @1, @2, @3)";
            } else {
                updateQuery = "INSERT INTO LineAnnouncement(AnnouncementTitle, AnnouncementBody, Line, AnnouncementTime) VALUES(@0, @1, @2, @3)";
            }

            var sqlFormattedDate = CurrentTime();

            var flag = db.Execute(updateQuery, title, message, stationID, sqlFormattedDate);

            if (flag != 0)
                return true;
            else
                return false;
            
        }
        // this is for the crowd volume / crowd control
        private static Boolean query(int status, string direction, int id)
        {
            var db = Database.Open("SQLAzureConnection");
            var updateQuery = "INSERT INTO StationStatus (Status, Supervisor, Direction, StatusTime) VALUES (@0, @1, @2, @3) ";

            var sqlFormattedDate = CurrentTime();
   
            var flag = db.Execute(updateQuery, status, id, direction, sqlFormattedDate);
            
            if (flag != 0)
                return true;
            else
                return false;

        }
    }
}