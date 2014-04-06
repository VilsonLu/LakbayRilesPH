using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.Data;

namespace LakbayRilesPH.ClassFiles
{
    public class LineUpdate
    {
        public static string GetLineCode()
        {
            var db = Database.Open("SQLAzureConnection");
            var query = "SELECT TOP 1 CodeName, StatusTime FROM LineStatus s, Code c WHERE s.Status = c.CodeID ORDER BY StatusTime DESC";
            var result = db.QuerySingle(query);
            var lineCode = result["CodeName"].Trim();

            if (lineCode == "Red")
            {
                lineCode = "background-color:#c0392b";
            }
            else if (lineCode == "Yellow")
            {
                lineCode = "background-color:#f39c12";
            }
            else
            {
                return "";
            }
            return lineCode;
        }
    }
}