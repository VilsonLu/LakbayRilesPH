using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

namespace LakbayRilesPH
{
    public class Admin
    {
        public static Boolean UpdateDatabase(int button, string direction)
        {
            return query(button, direction);
        }

        private static Boolean query(int status, string direction)
        {
            var db = Database.Open("SQLAzureConnection");
            var updateQuery = "INSERT INTO StationStatus (CodeID, StationID, Direction) VALUES (@0, @1, @2) ";
            var time = DateTime.Now;
            var sqlFormattedDate = time.Date.ToString("yyyy-MM-dd HH:mm:ss");
            var flag = db.Execute(updateQuery, status, "1", direction);
            
            if (flag != 0)
                return true;
            else
                return false;

        }
    }
}