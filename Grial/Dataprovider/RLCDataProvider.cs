using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace UXDivers.Artina.Grial.Dataprovider
{
    public class RLCDataProvider
    {
        public static List<RLC> _rlcList;
        public static Dictionary<string, string> RatingBGColors = new Dictionary<string, string>() {
            { "Red", "#E60028" },
            { "Orange", "#ef694b" },
            { "Green", "#35bd5b" },
        };


        public static List<RLC> RLCList
        {
            get
            {
                if (_rlcList == null)
                    InitializeRiskSamples();
                return _rlcList;
            }
        }

        public static string TileBGColor = "#f9f9f9";

        public static List<RLC> GetAllRLCs()
        {
            if (_rlcList == null)
                InitializeRiskSamples();
            return _rlcList;
        }

        private static void InitializeRiskSamples()
        {

            _rlcList = new List<RLC>();
            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "ABN AMRO BANK N.V.",
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf19c',
                    Rating = "3",
                    Country = "NETHERLANDS",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 728227,
                         StringTrcType = TrcType.LC,
                             DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                                                        //,
                                                        //    new Situation
                                                    //{
                                                    // LimitAmount = 600000,
                                                    // OutstandingAmount = 228227,
                                                    // TenorType = "3m,6m"
                                                    //},
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },
                        new Situation
                        {
                         LimitAmount = 900000,
                         OutstandingAmount = 628227,
                         StringTrcType = TrcType.LG,
                          DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 900000,
                                    OutstandingAmount = 628227,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 800000,
                                    OutstandingAmount = 528227,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 700000,
                                    OutstandingAmount = 428227,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 600000,
                                            OutstandingAmount = 328227,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                         new Situation
                        {
                         LimitAmount = 800000,
                         OutstandingAmount = 528227,
                         StringTrcType = TrcType.Unspecific,
                          DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 800000,
                                    OutstandingAmount = 528227,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 700000,
                                    OutstandingAmount = 428227,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 600000,
                                    OutstandingAmount = 328227,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 400000,
                                            OutstandingAmount = 228227,
                                            TenorType = "3m,6m"
                                }
                              },
                        }


                    }



                }
            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(RatingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "AB SEB BANKAS",
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf19c',
                    Rating = "3-",
                    Country = "LITHUANIA",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 10000000,
                         OutstandingAmount = 8900000,
                         StringTrcType = TrcType.LC,
                         DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 10000000,
                                    OutstandingAmount = 8900000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 8000000,
                                    OutstandingAmount = 6000000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 7000000,
                                    OutstandingAmount = 4000000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 4000000,
                                            OutstandingAmount = 2000000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                        new Situation
                        {
                         LimitAmount = 0,
                         OutstandingAmount = 0,
                         StringTrcType = TrcType.LG,
                               DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 8000000,
                                    OutstandingAmount = 6900000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 7000000,
                                    OutstandingAmount = 5000000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 6000000,
                                    OutstandingAmount = 4000000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 5000000,
                                            OutstandingAmount = 3000000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                        new Situation
                        {
                         LimitAmount = 5000000,
                         OutstandingAmount = 819000,
                         StringTrcType = TrcType.Unspecific,
                              DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 6000000,
                                    OutstandingAmount = 4900000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 6000000,
                                    OutstandingAmount = 4900000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 6000000,
                                    OutstandingAmount = 4900000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 6000000,
                                            OutstandingAmount = 4900000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },


                    },



                }
            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "ABU DHABI COMMERCIAL BANK",
                    BackgroundImage = SampleData.DashboardImagesList[3],
                    Icon = '\uf19c',
                    Rating = "4",
                    Country = "UNITED ARAB EMIRATES",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 528227,
                         StringTrcType = TrcType.LC,
                          DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 1000000,
                                    OutstandingAmount = 528227,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 800000,
                                    OutstandingAmount = 400000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 600000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                        new Situation
                        {
                         LimitAmount = 800000,
                         OutstandingAmount = 500000,
                         StringTrcType = TrcType.LG,
                               DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 800000,
                                    OutstandingAmount = 500000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 800000,
                                    OutstandingAmount = 328227,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 600000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                                //,
                                // new Situation
                                //{
                                //    LimitAmount = 500000,
                                //            OutstandingAmount = 300000,
                                //            TenorType = "6m,1y"
                                //}
                              },
                        },

                        new Situation
                        {
                         LimitAmount = 5000000,
                         OutstandingAmount = 819000,
                         StringTrcType = TrcType.Unspecific,
                              DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                    },
                }
            );


            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "BANQUE CANTONALE DE GENEVE",
                    BackgroundImage = SampleData.DashboardImagesList[5],
                    Icon = '\uf19c',
                    Rating = "5",
                    Country = "SWITZERLAND",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 500000,
                         OutstandingAmount = 300000,
                         StringTrcType = TrcType.LC,
                             DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },

                        new Situation
                        {
                         LimitAmount = 500000,
                         OutstandingAmount = 300000,
                         StringTrcType = TrcType.LG,
                             DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },

                        new Situation
                        {
                         LimitAmount = 500000,
                         OutstandingAmount = 300000,
                         StringTrcType = TrcType.Unspecific,
                             DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                                            },

                }
            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "BANK AUDI FRANCE",
                    BackgroundImage = SampleData.DashboardImagesList[1],
                    Icon = '\uf19c',
                    Rating = "7",
                    Country = "FRANCE",
                    LineSituation = new List<Situation>
                    {
                         new Situation
                        {
                         LimitAmount = 500000,
                         OutstandingAmount = 300000,
                         StringTrcType = TrcType.LC,
                             DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },

                        new Situation
                        {
                         LimitAmount = 500000,
                         OutstandingAmount = 300000,
                         StringTrcType = TrcType.LG,
                             DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                        new Situation
                        {
                         LimitAmount = 1500000,
                         OutstandingAmount = 283547,
                         StringTrcType = TrcType.Unspecific,
                            DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 1500000,
                                    OutstandingAmount = 800000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 1000000,
                                    OutstandingAmount = 700000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 900000,
                                    OutstandingAmount = 600000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 900000,
                                            OutstandingAmount = 600000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                                          },

                }
            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "BANK OF BARODA",
                    BackgroundImage = SampleData.DashboardImagesList[7],
                    Icon = '\uf19c',
                    Rating = "5-",
                    Country = "INDIA",
                    LineSituation = new List<Situation>
                    {
                         new Situation
                        {
                         LimitAmount = 500000,
                         OutstandingAmount = 300000,
                         StringTrcType = TrcType.LC,
                             DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },

                        new Situation
                        {
                         LimitAmount = 500000,
                         OutstandingAmount = 300000,
                         StringTrcType = TrcType.LG,
                             DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 500000,
                                    OutstandingAmount = 300000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 500000,
                                            OutstandingAmount = 300000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                         new Situation
                        {
                         LimitAmount = 1500000,
                         OutstandingAmount = 800000,
                         StringTrcType = TrcType.Unspecific,
                            DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 1500000,
                                    OutstandingAmount = 800000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 1000000,
                                    OutstandingAmount = 700000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 900000,
                                    OutstandingAmount = 600000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 900000,
                                            OutstandingAmount = 600000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },

                    },

                }
            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "BANCO DE CHILE",
                    BackgroundImage = SampleData.DashboardImagesList[8],
                    Icon = '\uf19c',
                    Rating = "5",
                    Country = "CHILE",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 1500000,
                         OutstandingAmount = 800000,
                         StringTrcType = TrcType.LC,
                          DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 1500000,
                                    OutstandingAmount = 800000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 1000000,
                                    OutstandingAmount = 700000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 900000,
                                    OutstandingAmount = 600000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 900000,
                                            OutstandingAmount = 600000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                        new Situation
                        {
                         LimitAmount = 1500000,
                         OutstandingAmount = 800000,
                         StringTrcType = TrcType.LG,
                          DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 1500000,
                                    OutstandingAmount = 800000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 1000000,
                                    OutstandingAmount = 700000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 900000,
                                    OutstandingAmount = 600000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 900000,
                                            OutstandingAmount = 600000,
                                            TenorType = "3m,6m"
                                }
                              },
                        }
                        ,
                         new Situation
                        {
                         LimitAmount = 1500000,
                         OutstandingAmount = 800000,
                         StringTrcType = TrcType.Unspecific,
                            DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 1500000,
                                    OutstandingAmount = 800000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 1000000,
                                    OutstandingAmount = 700000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 900000,
                                    OutstandingAmount = 600000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 900000,
                                            OutstandingAmount = 600000,
                                            TenorType = "3m,6m"
                                }
                              },
                        },

                    },


                }
            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "BNP PARIBAS",
                    BackgroundImage = SampleData.DashboardImagesList[0],
                    Icon = '\uf19c',
                    Rating = "3+",
                    Country = "FRANCE",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 20000000,
                         OutstandingAmount = 10825275,
                         StringTrcType = TrcType.LC,
                           DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 20000000,
                                    OutstandingAmount = 18825275,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 20000000,
                                    OutstandingAmount = 15825275,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 20000000,
                                    OutstandingAmount = 10825275,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 20000000,
                                            OutstandingAmount = 10825275,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                        new Situation
                        {
                         LimitAmount = 15000000,
                         OutstandingAmount = 9825275,
                         StringTrcType = TrcType.LG,
                           DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 15000000,
                                    OutstandingAmount = 9825275,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 15000000,
                                    OutstandingAmount = 9825275,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 15000000,
                                    OutstandingAmount = 9825275,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 15000000,
                                            OutstandingAmount = 9825275,
                                            TenorType = "3m,6m"
                                }
                              },
                        },
                        new Situation
                        {
                         LimitAmount = 11000000,
                         OutstandingAmount = 7825275,
                         StringTrcType = TrcType.Unspecific,
                           DetailedSituation = new List<Situation>
                            {
                                new Situation
                                {
                                    LimitAmount = 11000000,
                                    OutstandingAmount = 7000000,
                                    TenorType = "0,3d"
                                },
                                new Situation
                                {
                                    LimitAmount = 11000000,
                                    OutstandingAmount = 6000000,
                                    TenorType = "3d,1m"
                                },
                                new Situation
                                {
                                     LimitAmount = 11000000,
                                    OutstandingAmount = 6000000,
                                    TenorType = "1m,3m"
                                 },
                                new Situation
                                {
                                    LimitAmount = 11000000,
                                            OutstandingAmount = 6000000,
                                            TenorType = "3m,6m"
                                }
                              },
                        }
                        //,
                        //new Situation
                        //{
                        // LimitAmount = 10000000,
                        // OutstandingAmount = 5028227,
                        // StringTrcType = TrcType.UnspecificIR,
                        //   DetailedSituation = new List<Situation>
                        //    {
                        //        new Situation
                        //        {
                        //            LimitAmount = 10000000,
                        //            OutstandingAmount = 5028227,
                        //            TenorType = "0,3d"
                        //        },
                        //        new Situation
                        //        {
                        //            LimitAmount = 8000000,
                        //            OutstandingAmount = 4000000,
                        //            TenorType = "3d,1m"
                        //        },
                        //        new Situation
                        //        {
                        //             LimitAmount = 6000000,
                        //            OutstandingAmount = 3000000,
                        //            TenorType = "1m,3m"
                        //         },
                        //        new Situation
                        //        {
                        //            LimitAmount = 5000000,
                        //                    OutstandingAmount = 3000000,
                        //                    TenorType = "3m,6m"
                        //        }
                        //      },
                        //}
                    },

                }
            );
            _rlcList.Add(
               new RLC
               {
                   //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                   TileBGColor = Color.FromHex(TileBGColor),
                   Name = "BANK OF NANJING CO.,LTD",
                   BackgroundImage = SampleData.DashboardImagesList[6],
                   Icon = '\uf19c',
                   Rating = "5",
                   Country = "CHINA",
                   LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 728227,
                         StringTrcType = TrcType.LC,
                          DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                                                    //    ,
                                                    //        new Situation
                                                    //{
                                                    // LimitAmount = 600000,
                                                    // OutstandingAmount = 228227,
                                                    // TenorType = "3m,6m"
                                                    //},
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 728227,
                         StringTrcType = TrcType.LG,
                          DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                                                    //    ,
                                                    //        new Situation
                                                    //{
                                                    // LimitAmount = 600000,
                                                    // OutstandingAmount = 228227,
                                                    // TenorType = "3m,6m"
                                                    //},
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 728227,
                         StringTrcType = TrcType.Unspecific,
                          DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                                                    //    ,
                                                    //        new Situation
                                                    //{
                                                    // LimitAmount = 600000,
                                                    // OutstandingAmount = 228227,
                                                    // TenorType = "3m,6m"
                                                    //},
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },

                    },

               }
           );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "NATIXIS",
                    BackgroundImage = SampleData.DashboardImagesList[4],
                    Icon = '\uf19c',
                    Rating = "3",
                    Country = "FRANCE",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 40000000,
                         OutstandingAmount = 2453897,
                         StringTrcType = TrcType.LC,
                          DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                          }
                        },

                       new Situation
                        {
                         LimitAmount = 10000000,
                         OutstandingAmount = 453897,
                         StringTrcType = TrcType.LG,
                          DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                          }
                        },
                       new Situation
                        {
                         LimitAmount = 30000000,
                         OutstandingAmount = 353897,
                         StringTrcType = TrcType.Unspecific,
                          DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                          }
                        },
                    },

                }
            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "BANCO DE LA NACION",


                    BackgroundImage = SampleData.DashboardImagesList[3],
                    Icon = '\uf19c',
                    Rating = "5",
                    Country = "PERU",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 528227,
                         StringTrcType = TrcType.LC,
                               DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    }
                                                    //    ,
                                                    //        new Situation
                                                    //{
                                                    // LimitAmount = 600000,
                                                    // OutstandingAmount = 228227,
                                                    // TenorType = "3m,6m"
                                                    //},
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 728227,
                         StringTrcType = TrcType.LG,
                               DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "3m,6m"
                                                    }
                                                    //    ,
                                                    //        new Situation
                                                    //{
                                                    // LimitAmount = 600000,
                                                    // OutstandingAmount = 228227,
                                                    // TenorType = "3m,6m"
                                                    //},
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 728227,
                         StringTrcType = TrcType.Unspecific,
                               DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 728227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "3m,6m"
                                                    }
                                                    //    ,
                                                    //        new Situation
                                                    //{
                                                    // LimitAmount = 600000,
                                                    // OutstandingAmount = 228227,
                                                    // TenorType = "3m,6m"
                                                    //},
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        }
                        //,
                        //new Situation
                        //{
                        // LimitAmount = 1000000,
                        // OutstandingAmount = 728227,
                        // StringTrcType = TrcType.UnspecificIR,
                        //       DetailedSituation = new List<Situation>
                        //                        {
                        //                            new Situation
                        //                            {
                        //                             LimitAmount = 1000000,
                        //                             OutstandingAmount = 728227,
                        //                             TenorType = "0,3d"
                        //                            },
                        //                            new Situation
                        //                            {
                        //                             LimitAmount = 900000,
                        //                             OutstandingAmount = 528227,
                        //                             TenorType = "3d,1m"
                        //                            },
                        //                                new Situation
                        //                            {
                        //                             LimitAmount = 800000,
                        //                             OutstandingAmount = 428227,
                        //                             TenorType = "1m,3m"
                        //                            },
                        //                                new Situation
                        //                            {
                        //                             LimitAmount = 700000,
                        //                             OutstandingAmount = 328227,
                        //                             TenorType = "1m,3m"
                        //                            },
                        //                                    new Situation
                        //                            {
                        //                             LimitAmount = 600000,
                        //                             OutstandingAmount = 228227,
                        //                             TenorType = "3m,6m"
                        //                            },
                        //                                           new Situation
                        //                            {
                        //                             LimitAmount = 500000,
                        //                             OutstandingAmount = 128227,
                        //                             TenorType = "6m,1y"
                        //                            }


                        //                         },
                        //}
                    },
                }


            );

            _rlcList.Add(
                new RLC
                {
                    //IconColor = Color.FromHex(_ratingBGColors["Green"]),
                    TileBGColor = Color.FromHex(TileBGColor),
                    Name = "BANQUE CENTRALE POPULAIRE",
                    BackgroundImage = SampleData.DashboardImagesList[6],
                    Icon = '\uf19c',
                    Rating = "5+",
                    Country = "MOROCCO",
                    LineSituation = new List<Situation>
                    {
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 528227,
                         StringTrcType = TrcType.LC,
                             DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                       
                                                            new Situation
                                                    {
                                                     LimitAmount = 600000,
                                                     OutstandingAmount = 228227,
                                                     TenorType = "3m,6m"
                                                    }
                                                    //        ,
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 528227,
                         StringTrcType = TrcType.LG,
                             DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                            new Situation
                                                    {
                                                     LimitAmount = 600000,
                                                     OutstandingAmount = 228227,
                                                     TenorType = "3m,6m"
                                                    }
                                                    //        ,
                                                    //               new Situation
                                                    //{
                                                    // LimitAmount = 500000,
                                                    // OutstandingAmount = 128227,
                                                    // TenorType = "6m,1y"
                                                    //}


                                                 },
                        },
                        new Situation
                        {
                         LimitAmount = 1000000,
                         OutstandingAmount = 528227,
                         StringTrcType = TrcType.Unspecific,
                             DetailedSituation = new List<Situation>
                                                {
                                                    new Situation
                                                    {
                                                     LimitAmount = 1000000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "0,3d"
                                                    },
                                                    new Situation
                                                    {
                                                     LimitAmount = 900000,
                                                     OutstandingAmount = 528227,
                                                     TenorType = "3d,1m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 800000,
                                                     OutstandingAmount = 428227,
                                                     TenorType = "1m,3m"
                                                    },
                                                        new Situation
                                                    {
                                                     LimitAmount = 700000,
                                                     OutstandingAmount = 328227,
                                                     TenorType = "1m,3m"
                                                    },
                                                            new Situation
                                                    {
                                                     LimitAmount = 600000,
                                                     OutstandingAmount = 228227,
                                                     TenorType = "3m,6m"
                                                    },
                                                                   new Situation
                                                    {
                                                     LimitAmount = 500000,
                                                     OutstandingAmount = 128227,
                                                     TenorType = "6m,1y"
                                                    }


                                                 },
                        }
                        //,
                        //new Situation
                        //{
                        // LimitAmount = 900000,
                        // OutstandingAmount = 528227,
                        // StringTrcType = TrcType.UnspecificIR,
                        //     DetailedSituation = new List<Situation>
                        //                        {
                        //                            new Situation
                        //                            {
                        //                             LimitAmount = 900000,
                        //                             OutstandingAmount = 528227,
                        //                             TenorType = "0,3d"
                        //                            },
                        //                            new Situation
                        //                            {
                        //                             LimitAmount = 900000,
                        //                             OutstandingAmount = 528227,
                        //                             TenorType = "3d,1m"
                        //                            },
                        //                                new Situation
                        //                            {
                        //                             LimitAmount = 800000,
                        //                             OutstandingAmount = 428227,
                        //                             TenorType = "1m,3m"
                        //                            },
                        //                                new Situation
                        //                            {
                        //                             LimitAmount = 700000,
                        //                             OutstandingAmount = 328227,
                        //                             TenorType = "1m,3m"
                        //                            },
                        //                                    new Situation
                        //                            {
                        //                             LimitAmount = 600000,
                        //                             OutstandingAmount = 228227,
                        //                             TenorType = "3m,6m"
                        //                            },
                        //                                           new Situation
                        //                            {
                        //                             LimitAmount = 500000,
                        //                             OutstandingAmount = 128227,
                        //                             TenorType = "6m,1y"
                        //                            }


                        //                         },
                        //}
                    },

                }
            );

        }

    }
}
