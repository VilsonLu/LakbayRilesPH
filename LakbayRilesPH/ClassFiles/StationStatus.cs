using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LakbayRilesPH.ClassFiles
{
    public class StationStatus
    {
        public int StationID { get; set; }
        public string StationName { get; set; }
        public DateTime Time { get; set; }
        public string CodeName { get; set; }
        public string Direction { get; set; }
        public List<Announcement> Announcements { get; set; } 
    }
}