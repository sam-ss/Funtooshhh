using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UXDivers.Artina.Grial.Dataprovider
{
    #region Models
    public class BaseModel
    {
        public BaseModel()
        {
        }

        public string Title { get; set; }
        public string Details { get; set; }
        public int Id { get; set; }

    }
    public class AuthorizationLine : BaseModel
    {
        public string _risklegalCounterpart;
        public RiskItem SelectedItem = new RiskItem();
        public AuthorizationLine(string counterpart)
        {
            SelectedItem = RiskDataProvider.GetRisks().SingleOrDefault(x => x.Title == counterpart);
            this._risklegalCounterpart = counterpart;

        }
        public List<Situation> LineSituation { get; set; }

        internal AuthorizationLine Get()
        {
            return new AuthorizationLineRepository().GetData(_risklegalCounterpart);
        }
    }
   

    

    public class RiskItem : BaseModel
    {
        public string Country { get; set; }
        public string Rating { get; set; }
        public string RCTId { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
    }
    public class RiskDataProvider
    {
        public static List<RiskItem> GetRisks()
        {
            return new List<RiskItem>() {
                new RiskItem
                {
                    Title = "ABC LTD",
                    Country = "ITALY",
                    Rating = "11",
                    RCTId = "XYZ12",
                    Icon = "R3_8.png",
                    Color = "#c2185b"
                },
                new RiskItem
                {
                    Title = "XYZ PVT LTD",
                    Country = "USA",
                    Rating = "5",
                    RCTId = "XYZ13",
                    Icon = "R4_3.png",
                    Color = "#ad1358"

                },
                 new RiskItem
                {
                    Title = "PQR LTD",
                    Country = "ARUBA",
                    Rating = "11",
                    RCTId = "XYZ14",
                    Icon = "R4_3.png",
                    Color = "#473858"

                },
                new RiskItem
                {
                    Title = "MNO LTD",
                    Country = "FRANCE",
                    Rating = "5",
                    RCTId = "XYZ15",
                    Icon = "R3_8.png",
                    Color = "#564567"

                },
                 new RiskItem
                {
                    Title = "KJE LTD",
                    Country = "CHILI",
                    Rating = "11",
                    RCTId = "XYZ16",
                    Icon = "R4_3.png",
                    Color = "#5a5488"

                },
                new RiskItem
                {
                    Title = "TRRYYSS LTD",
                    Country = "JAPAN",
                    Rating = "5",
                    RCTId = "XYZ17",
                    Icon = "R3_8.png",
                    Color = "#4c74a7"

                },
                 new RiskItem
                {
                    Title = "GHJU LTD",
                    Country = "USA",
                    Rating = "11",
                    RCTId = "XYZ18",
                    Icon = "R3_8.png",
                    Color = "#4d99cd"
                },
                new RiskItem
                {
                    Title = "HSBC Bank",
                    Country = "CANADA",
                    Rating = "5",
                    RCTId = "ABB2148",
                    Icon = "R3_8.png",
                    Color = "#FF00FF"

                },
                 new RiskItem
                {
                    Title = "Credit Mutuel Arkea",
                    Country = "FRANCE",
                    Rating = "11",
                    RCTId = "ABB2149",
                    Icon = "R4_3.png",
                    Color = "#87CEFA"

                },
                new RiskItem
                {
                    Title = "DOHA BANK",
                    Country = "QATAR",
                    Rating = "5",
                    RCTId = "ABB21410",
                    Icon = "R3_8.png",
                    Color = "#6A5ACD"

                }

            };
        }
    }
    #endregion
    public class AuthorizationLineRepository
    {
        public AuthorizationLine GetData(String counterpart)
        {
            //var authline = new AuthorizationLine(counterpart);
            //authline.LineSituation = new List<Situation>();
            //var unspecificSituation = new Situation() { LimitAmount = 100000, OutstandingAmount = 4000, TrcType = Models.Enum.TrcType.Unspecific };
            //var LCSituation = new Situation() { LimitAmount = 100000, OutstandingAmount = 4000, TrcType = Models.Enum.TrcType.LC };
            //var LGSituation = new Situation() { LimitAmount = 100000, OutstandingAmount = 4000, TrcType = Models.Enum.TrcType.LG };
            //authline.LineSituation.Add(unspecificSituation);
            //authline.LineSituation.Add(LCSituation);
            //authline.LineSituation.Add(LGSituation);

            return AllLines().FirstOrDefault(l => l._risklegalCounterpart == counterpart);

        }


        private static List<AuthorizationLine> AllLines()
        {
            var allLines = new List<AuthorizationLine>();
            var counterparts = RiskDataProvider.GetRisks();
            foreach (var counterpart in counterparts)
            {
                var Limit = new Random();
                var lmin = 1111111;
                var lmax = 9999999;

                var omin = 0;
                var omax = 9999999;
                var random = new Random();
                var lineSituation = new List<Situation>();
                lineSituation.Add(new Situation() { StringTrcType = TrcType.LC, LimitAmount = random.Next(lmin, lmax), OutstandingAmount = random.Next(omin, omax) });
                lineSituation.Add(new Situation() { StringTrcType = TrcType.LG, LimitAmount = random.Next(lmin, lmax), OutstandingAmount = random.Next(omin, omax) });

                lineSituation.Add(new Situation() { StringTrcType = TrcType.UnspecificIR, LimitAmount = random.Next(lmin, lmax), OutstandingAmount = random.Next(omin, omax) });

                lineSituation.Add(new Situation() { StringTrcType = TrcType.LG, LimitAmount = random.Next(lmin, lmax), OutstandingAmount = random.Next(omin, omax) });

                allLines.Add(new AuthorizationLine(counterpart.Title) { LineSituation = lineSituation });
            }
            return allLines;
        }
    }
}
