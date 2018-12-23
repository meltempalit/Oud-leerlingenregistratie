using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPosts
{
    class Post
    {
        private string strErvaring, strHerinnering, strMededeling;

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
        public Post(string ervaring, string mededeling, string herinnering)
        {
            strErvaring = ervaring;
            strMededeling = mededeling;
            strHerinnering = herinnering;
        }

        public override string ToString()
        {
            return "Ervaringen? loopbaan: " + strErvaring + Environment.NewLine +
                "Herinneringen aan Sint-Lievenscollege Business: " + strHerinnering + Environment.NewLine +
                "Mededeling: " + strMededeling;


        }

    }
}
