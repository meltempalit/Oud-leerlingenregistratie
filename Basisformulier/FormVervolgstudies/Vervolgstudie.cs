using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVervolgstudies
{
    class Vervolgstudie
    {
        private string strSchool, strRichting, strDiploma, strAfstudeerjaar;

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
        public Vervolgstudie(string pstrSchool, string pstrRichting, string pstrDiploma, string pstrAfstudeerjaar)
        {
            strAfstudeerjaar = pstrAfstudeerjaar;
            strDiploma = pstrDiploma;
            strRichting = pstrRichting;
            strSchool = pstrSchool;
        }
        public override string ToString()
        {
            return "School? Naam: " + strSchool + Environment.NewLine +
                "Welke richting heeft u daar gevolgd? : " + strRichting + Environment.NewLine +
                "Welk Diploma kreeg u daarbij? : " + strDiploma + Environment.NewLine + 
                "Wat was uw afstudeerjaar (dd/mm/yyyy)? : " + strAfstudeerjaar;
        }
    }
}
