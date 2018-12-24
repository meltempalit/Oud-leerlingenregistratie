using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersoon
{
    class KlassePersoon
    {
        private int intID, idWerk, idVervolgstudies, idPosts;
        private string strNaam, strFamilienaam, strGeboortedatum, strEmail, strTel, strAfstudeerjaar, strRichting;

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

        public string geboorte
        {
            get { return strGeboortedatum; }
            set { strGeboortedatum = value; }
        }

        public string email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        public string telefoon
        {
            get { return strTel; }
            set { strTel = value; }
        }
        public string afstudeerj
        {
            get { return strAfstudeerjaar; }
            set { strAfstudeerjaar = value; }
        }
        public string richting
        {
            get { return strRichting; }
            set { strRichting = value; }
        }

        public int idPersoon
        {
            get { return intID; }
            set { intID = value; }
        }
        public int werkID
        {
            get { return idWerk; }
            set { idWerk = value; }
        }
        public int studiesID
        {
            get { return idVervolgstudies; }
            set { idVervolgstudies = value; }
        }
        public int postsID
        {
            get { return idPosts; }
            set { idPosts = value; }
        }

        public KlassePersoon(string naam, string fnaam, string geboorte, string email, string telo, string afstjaar, string richting)
        {
            strNaam = naam;
            strFamilienaam = fnaam;
            strGeboortedatum = geboorte;
            strEmail = email;
            strTel = telo;
            strAfstudeerjaar = afstjaar;
            strRichting = richting;

        }

        public override string ToString()
        {
            return strNaam + " " + strFamilienaam + ": " + Environment.NewLine +
            "Geboortedatum: " + strGeboortedatum + Environment.NewLine +
            "E-mail: " + strEmail + " Telefoonnummer: " + strTel + Environment.NewLine
            + strAfstudeerjaar + " " + strRichting;    
        }


    }
}
