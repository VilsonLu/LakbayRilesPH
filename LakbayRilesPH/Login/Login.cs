using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

namespace LakbayRilesPH.Login
{
    public class Login
    {
         public Staff ValidateUser(string username, string password)
        {
            var db = Database.Open("SQLAzureConnection");
            var loginQuery = db.QuerySingle("SELECT * FROM Staff WHERE Username = '"+ username +"' and Password = '" + password + "'");

            if (loginQuery != null)
            {
                var staff = new Staff();
                staff.FirstName = loginQuery["FirstName"];
                staff.LastName = loginQuery["LastName"];
                staff.Username = loginQuery["username"];
                staff.UserID = loginQuery["UserID"];
                return staff;
            }
            else
            {
                return null;
            }
           
        }
    }
}