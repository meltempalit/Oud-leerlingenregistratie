using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormInformatie
{
    class WerkInfo
    {
        private string strJob, strBedrijf, strBeginjaar, strLand;
        private int intId;

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
        public int ID
        {
            get { return intId; }
            set { intId = value; }
        }
        public WerkInfo(int pintID, string pstrjob, string pstrBedrijf, string pstrBeginjaar, string pstrLand)
        {
            intId = pintID;
            strJob = pstrjob;
            strBedrijf = pstrBedrijf;
            strBeginjaar = pstrBeginjaar;
            strLand = pstrLand;
        }
        public override string ToString()
        {
            return "OUD-LEERLING ID: " + intId + Environment.NewLine + "Naam huidig beroep: " + Environment.NewLine + strJob + Environment.NewLine + Environment.NewLine +
                "Huidig bedrijf: " + Environment.NewLine + strBedrijf + Environment.NewLine + Environment.NewLine +
                "Startjaar werk: " + Environment.NewLine + strBeginjaar + Environment.NewLine + Environment.NewLine +
                "Vestiging bedrijf: " + Environment.NewLine + strLand+
                 Environment.NewLine + Environment.NewLine;
        }
    }
}
