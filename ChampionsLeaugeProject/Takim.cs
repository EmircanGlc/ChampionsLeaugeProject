using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeaugeProject
{
    class Takim
    {
        private string takimIsmi;
        private string takimUlke;

        public Takim ( string isim,string ulke)
        {
            takimIsmi = isim;
            takimUlke = ulke;
        }

        public string TeamName 
        {
            get
            {
                return takimIsmi;
            }
            set
            {
                takimIsmi = value; //Burası formda ayarlanacak.
            }     
        }
        public string TeamCountry {
            get
            {
                return takimUlke;
            }
            set
            {
                takimUlke = value;
            }
        }
        public override string ToString()
        {
            return takimIsmi+ "-" + takimUlke; //Takım ismini ve ülkesini loadda döndürelim.
                           //Burada override yaptım çünkü bir ülkeden birden çok takım turnuvada yer alabilir.
        }
    }
}
