using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormInformatie 
{
    

    class PostInfo 
    {
        private string strErvaring, strHerinnering, strMededeling;
        int intID;
        public string ervaring
        {
            get { return strErvaring; }
            set { strErvaring = value; }
        }

        public string herinnering
        {
            get { return strHerinnering; }
            set { strHerinnering = value; }
        }

        public string mededeling
        {
            get { return strMededeling; }
            set { strMededeling = value; }
        }

        public int id
        { get { return intID; }
            set { intID = value; }
        }
        public PostInfo(int id, string ervaring, string mededeling, string herinnering)
        {
            intID = id;
            strErvaring = ervaring;
            strMededeling = mededeling;
            strHerinnering = herinnering;
        }


        public override string ToString()
        {
            return "OUD-LEERLING ID: " + intID +  Environment.NewLine + "Ervaringen? loopbaan: " + Environment.NewLine + strErvaring + Environment.NewLine + Environment.NewLine +
                "Herinneringen aan Sint-Lievenscollege Business: " + Environment.NewLine + strHerinnering + Environment.NewLine + Environment.NewLine +
                "Mededeling: " + Environment.NewLine + strMededeling + Environment.NewLine + Environment.NewLine;


        }
    }
}
