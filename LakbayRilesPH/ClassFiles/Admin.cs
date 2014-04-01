using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

namespace LakbayRilesPH
{
    public class Admin
    {
        public static Boolean UpdateDatabase(int button, string direction, int id)
        {
            return query(button, direction, id);
        }

        public static Boolean UpdateDatabase(string title, string message, int stationID)
        {
            return query(title, message, stationID);
        }

        private static Boolean query(string title, string message, int stationID)
        {
            var db = Database.Open("SQLAzureConnection");
            var updateQuery = "INSERT INTO StationAnnouncement(AnnouncementTitle, AnnouncementBody, Station, AnnouncementTime) VALUES(@0, @1, @2, @3)";
            var time = DateTime.Now;
            var sqlFormattedDate = time.ToString("yyyy-MM-dd HH:mm:ss");

            var flag = db.Execute(updateQuery, title, message, stationID, sqlFormattedDate);

            if (flag != 0)
                return true;
            else
                return false;
            
        }

        private static Boolean query(int status, string direction, int id)
        {
            var db = Database.Open("SQLAzureConnection");
            var updateQuery = "INSERT INTO StationStatus (Status, Supervisor, Direction, StatusTime) VALUES (@0, @1, @2, @3) ";
            var time = DateTime.Now;
            var sqlFormattedDate = time.ToString("yyyy-MM-dd HH:mm:ss");
   
            var flag = db.Execute(updateQuery, status, id, direction, sqlFormattedDate);
            
            if (flag != 0)
                return true;
            else
                return false;

        }
    }
}