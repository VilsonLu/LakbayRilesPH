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

        private static Boolean query(int status, string direction, int id)
        {
            var db = Database.Open("SQLAzureConnection");
            var updateQuery = "INSERT INTO StationStatus (CodeID, StationID, Direction, Timestamp) VALUES (@0, @1, @2, @3) ";
            var time = DateTime.Now;
            var sqlFormattedDate = time.ToString("yyyy-MM-dd HH:mm:ss");
            // Don't forget to change these once the login module has been created.
            var flag = db.Execute(updateQuery, status, id, direction, sqlFormattedDate);
            
            if (flag != 0)
                return true;
            else
                return false;

        }
    }
}