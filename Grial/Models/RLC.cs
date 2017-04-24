using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UXDivers.Artina.Grial
{
    public class RLC
    {
        public int Id { get; set; }
        string _name;
        public RLC(string name)
        {
            Name = name;
        }
        public RLC()
        {

        }
        public string Name
        {
            get {
                if(_name.Length > 17)
                {
                    return _name.Substring(0, 16) + "...";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                _name = value;
            }
        }
        public string StartLetter
        {
            get
            {
                return Name.Substring(0, 1).ToUpper();
            }
        }

        public string Country { get; set; }

        public Color BackgroundColor
        {
            get
            {
                if(Rating.Equals("3") || Rating.Equals("4") || Rating.Equals("5"))
                    return Color.FromHex(Dataprovider.RLCDataProvider.RatingBGColors["Orange"]);
                else if (Rating.Equals("3-") || Rating.Equals("5-"))
                    return Color.FromHex(Dataprovider.RLCDataProvider.RatingBGColors["Red"]);
                else
                    return Color.FromHex(Dataprovider.RLCDataProvider.RatingBGColors["Green"]);
            }
        }

        public string Rating { get; set; }

        public String BackgroundImage { get; set; }
        public Color RatingBackgroundColor { get { return IconColor; } }
        public Color TileBGColor { get; set; }
        public Color IconColor { get; set; }
        public List<Sample> SamplesList { get; set; }

        public char Icon { get; set; }

        public List<Situation> LineSituation { get; set; }
        public List<Situation> DetailedLineSituation { get; set; }

    }
}
