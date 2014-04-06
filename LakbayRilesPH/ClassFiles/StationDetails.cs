using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LakbayRilesPH.ClassFiles
{
    public class StationDetails {
        public string idName { get; set; }
        public string stationName { get; set; }
        public string top { get; set; }
        public string left { get; set; }

        public string NorthCode { get; set; }
        public string NorthCV { get; set; }
        public string NorthColor { get; set; }
        public DateTime NorthTime { get; set; }

        public string SouthCode { get; set; }
        public string SouthCV { get; set; }
        public string SouthColor { get; set; }
        public DateTime SouthTime { get; set; }

        public List<Announcement> StationAnnouncement { get; set; }
    }
}