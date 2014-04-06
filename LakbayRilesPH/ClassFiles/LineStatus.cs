using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LakbayRilesPH.ClassFiles
{
    public class LineStatus
    {
        public string ID { get; set; }
        public int Status { get; set; }
        public int Supervisor { get; set; }
        public DateTime Time { get; set; }
    }
}