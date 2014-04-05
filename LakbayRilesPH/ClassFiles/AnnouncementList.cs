using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

namespace LakbayRilesPH.ClassFiles
{
    public class AnnouncementList
    {
        public static List<Announcement> GetAnnouncements(){
            List<Announcement> announcements = new List<Announcement>();
            var db = Database.Open("SQLAzureConnection");
            var query = "SELECT Top 5 AnnouncementTitle, AnnouncementBody, AnnouncementTime FROM LineAnnouncement ORDER BY AnnouncementTime DESC";
            var result = db.Query(query);

            Announcement announcement;
            foreach (var row in result)
            {
                announcement = new Announcement();
                announcement.Title = row.AnnouncementTitle;
                announcement.Message = row.AnnouncementBody;
                announcement.Time = row.AnnouncementTime;
                announcements.Add(announcement);
            }

            return announcements;
        }


    }
}