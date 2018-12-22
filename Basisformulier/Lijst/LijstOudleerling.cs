using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lijst
{
    class LijstOudleerling
    {
        private string strNaam, strFamilienaam, strGeboortedatum, strEmail, strTel, strAfstudeerjaar, strRichting;
        private int intpersoonID, intwerkID, intvervolgstudiesID, intpostsID;

        public string naam
        {
            get { return strNaam; }
            set { strNaam = value; }
        }

        public string familienaam
        {
            get { return strFamilienaam; }
            set { strFamilienaam = value; }
        }
        public string geboortedatum
        {
            get { return strGeboortedatum; }
            set { strGeboortedatum = value; }
        }
        public string email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        public string telefoonnummer
        {
            get { return strTel; }
            set { strTel = value; }
        }
        public string afstudeerjaar
        {
            get { return strAfstudeerjaar; }
            set { strAfstudeerjaar = value; }
        }
        public string richitng
        {
            get { return strRichting; }
            set { strRichting = value; }
        }

        public int idPersoon
        {
            get { return intpersoonID; }
            set { intpersoonID = value; }
        }
        public int idPost
        {
            get { return intpostsID; }
            set { intpostsID = value; }
        }

        // constructor

        // construcor 1 voor listboxs

        public LijstOudleerling(int pid, string pnaam, string pfamn)
        {
            intpersoonID = pid;
            strNaam = pnaam;
            strFamilienaam = pfamn;
        }


        public override string ToString()
        {
            return intpersoonID + " " + strNaam + " " + strFamilienaam;
        }
    }
}
