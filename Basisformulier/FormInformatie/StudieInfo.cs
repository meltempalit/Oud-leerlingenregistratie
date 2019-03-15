using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormInformatie
{
    class StudieInfo
    {

        private string strSchool, strRichting, strDiploma, strAfstudeerjaar;
        int intID;

        public string School
        {
            get { return strSchool; }
            set { strSchool = value; }
        }
        public string Richting
        {
            get { return strRichting; }
            set { strRichting = value; }
        }
        public string Diploma
        {
            get { return strDiploma; }
            set { strDiploma = value; }
        }
        public string Afstudeerjaar
        {
            get { return strAfstudeerjaar; }
            set { strAfstudeerjaar = value; }
        }
        public int id
        {
            get { return intID; }
            set { intID = value; }
        }
        public StudieInfo(string pstrSchool, string pstrRichting, string pstrDiploma, string pstrAfstudeerjaar)
        {
            strAfstudeerjaar = pstrAfstudeerjaar;
            strDiploma = pstrDiploma;
            strRichting = pstrRichting;
            strSchool = pstrSchool;
        }
        public override string ToString()
        {
            return "OUD-LEERLING ID: " + intID + Environment.NewLine + "School vervolgstudies: " + Environment.NewLine + strSchool + Environment.NewLine +
                 "Richting vervolgstudies: " + Environment.NewLine + strRichting + Environment.NewLine +
                 "Behaald diploma: " + Environment.NewLine + strDiploma + Environment.NewLine + Environment.NewLine+ 
                 "Afstudeerjaar: " + Environment.NewLine + strAfstudeerjaar + Environment.NewLine + Environment.NewLine;
        }
    }
}
