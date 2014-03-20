using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LakbayRilesPH.Controller
{
    public class StationList {
        public static List<StationDetails> createStations()
        {
            List<StationDetails> list = new List<StationDetails>();
            StationDetails temp;

            temp = new StationDetails();
            temp.idName = "Baclaran";
            temp.stationName = "BACLARAN";
            temp.top = "505px";
            temp.left = "63px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Edsa";
            temp.stationName = "EDSA";
            temp.top = "481px";
            temp.left = "113px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Libertad";
            temp.stationName = "LIBERTAD";
            temp.top = "456px";
            temp.left = "161px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "GilPuyat";
            temp.stationName = "GIL PUYAT";
            temp.top = "432px";
            temp.left = "211px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "VitoCruz";
            temp.stationName = "VITO CRUZ";
            temp.top = "408px";
            temp.left = "259px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Quirino";
            temp.stationName = "QUIRINO";
            temp.top = "384px";
            temp.left = "307px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "PedroGil";
            temp.stationName = "PEDRO GIL";
            temp.top = "359px";
            temp.left = "357px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "UNAve";
            temp.stationName = "U.N. AVENUE";
            temp.top = "335px";
            temp.left = "406px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Central";
            temp.stationName = "CENTRAL";
            temp.top = "309px";
            temp.left = "455px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Carriedo";
            temp.stationName = "CARRIEDO";
            temp.top = "285px";
            temp.left = "504px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "DJose";
            temp.stationName = "DOROTEO JOSE";
            temp.top = "261px";
            temp.left = "552px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Bambang";
            temp.stationName = "BAMBANG";
            temp.top = "236px";
            temp.left = "602px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Tayuman";
            temp.stationName = "TAYUMAN";
            temp.top = "212px";
            temp.left = "650px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Blumentritt";
            temp.stationName = "BLUMENTRITT";
            temp.top = "188px";
            temp.left = "699px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "AbadSantos";
            temp.stationName = "ABAD SANTOS";
            temp.top = "163px";
            temp.left = "748px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "RPapa";
            temp.stationName = "R. PAPA";
            temp.top = "139px";
            temp.left = "796px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "5thAvenue";
            temp.stationName = "5TH AVENUE";
            temp.top = "114px";
            temp.left = "846px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Monumento";
            temp.stationName = "MONUMENTO";
            temp.top = "89px";
            temp.left = "895px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Balintawak";
            temp.stationName = "BALINTAWAK";
            temp.top = "65px";
            temp.left = "944px";
            list.Add(temp);

            temp = new StationDetails();
            temp.idName = "Roosevelt";
            temp.stationName = "ROOSEVELT";
            temp.top = "41px";
            temp.left = "993px";
            list.Add(temp);

            return list;
        }
    }
}