using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWerk
{
    class Werk
    {
        private string strJob, strBedrijf, strBeginjaar, strLand;

        public string Job
        {
            get { return strJob; }
            set { strJob = value; }
        }
        public string Bedrijf
        {
            get { return strBedrijf; }
            set { strBedrijf = value; }
        }
        public string Beginjaar
        {
            get { return strBeginjaar; }
            set { strBeginjaar = value; }
        }
        public string Land
        {
            get { return strLand; }
            set { strLand = value; }
        }
        public Werk(string pstrjob, string pstrBedrijf, string pstrBeginjaar, string pstrLand)
        {
            strJob = pstrjob;
            strBedrijf = pstrBedrijf;
            strBeginjaar = pstrBeginjaar;
            strLand = pstrLand;
        }
        public override string ToString()
        {
            return "Wat voor werk heeft u? " + strJob + Environment.NewLine +
                "Voor welk bedrijf werkt u? " + strBedrijf + Environment.NewLine +
                "Wanneer bent u daar beginnen werken? " + strBeginjaar + Environment.NewLine +
                "In welk land werkt u? " + strLand;
        }
    }
}
