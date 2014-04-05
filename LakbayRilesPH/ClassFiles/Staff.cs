using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace LakbayRilesPH
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StationHandle { get; set; }
        public int LineHandle { get; set; }
    }
}