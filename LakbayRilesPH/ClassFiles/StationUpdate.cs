using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

namespace LakbayRilesPH.ClassFiles
{
    public class StationUpdate
    {
        public static StationStatus DisplayUpdate( string station, string code, string direction)
        {
            var db = Database.Open("SQLAzureConnection");
            var query = "SELECT TOP 1 StationID, StationName, StatusTime as Time, CodeName, Direction " +
                        "FROM Staff as E, Code as C, StationStatus as U, Station as P " +
                        "WHERE E.StaffID = U.Supervisor and E.StationHandle = P.StationID and C.CodeID = U.Status and " +
                        "StationName = @0 and Direction = @1 and CodeType = @2 " +
                        "ORDER BY Time DESC";

            var result = db.QuerySingle(query,station, direction, code);
            StationStatus temp = new StationStatus();
            var x = result["StationName"].Trim();
            temp.StationName = x;
            var y = result["Direction"].Trim();
            temp.Direction = y;
            temp.Time = result["Time"];
            var z = result["CodeName"].Trim();
            temp.CodeName = z;
            temp.StationID = result["StationID"];
            temp.Time = result["Time"];
            temp.Announcements = GetAnnouncements(result["StationID"]);
            return temp;
        }

        public static List<Announcement> GetAnnouncements(int stationID) {
            List<Announcement> temp = new List<Announcement>();
            var db = Database.Open("SQLAzureConnection");
            var query = "SELECT TOP 3 AnnouncementTitle, AnnouncementBody, AnnouncementTime FROM StationAnnouncement WHERE Station = @0 ORDER BY AnnouncementTime DESC";
            var result = db.Query(query, stationID);
            Announcement announcement;
            foreach (var row in result)
            {
                announcement = new Announcement();
                announcement.Title = row.AnnouncementTitle;
                announcement.Message = row.AnnouncementBody;
                announcement.Time = row.AnnouncementTime;
                temp.Add(announcement);
            }

            return temp;
        }
        public static string DisplayStatus(string north, string south)
        {
            if (north == "Heavy" && south == "Heavy")
            {
                return "-1px";
            }
            else if (north == "Heavy" && south == "Moderate")
            {
                return "-49px";
            }
            else if (north == "Heavy" && south == "Light")
            {
                return "-25px";
            }
            else if (north == "Light" && south == "Moderate")
            {
                return "-97px";
            }
            else if (north == "Light" && south == "Light")
            {
                return "-73px";
            }
            else if (north == "Light" && south == "Heavy")
            {
                return "-121px";
            }
            else if (north == "Moderate" && south == "Moderate")
            {
                return "-145px";
            }
            else if (north == "Moderate" && south == "Light")
            {
                return "-169px";
            }
            else if (north == "Moderate" && south == "Heavy")
            {
                return "-192px";
            }
            else
            {
                return "0";
            }
        }
    }
}