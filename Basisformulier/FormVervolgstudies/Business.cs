using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormVervolgstudies
{
    class Business
    {
        private Persistence _pers;

        private List<Vervolgstudie> _vervolgstudie;
        public List<Vervolgstudie> Vervolgstudie
        {
            get { return _vervolgstudie; }
            set { _vervolgstudie = value; }
        }

        public Business()
        {
            _pers = new Persistence();
            _vervolgstudie = _pers.getVervolgstudiesFromDB();
        }

        public List<string> getVervolgstudies()
        {
            List<string> result = new List<string>();

            foreach (Vervolgstudie item in _vervolgstudie)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public void voegToe(string school, string richting, string diploma, string afstudeerjaar)
        {
            Vervolgstudie v = new Vervolgstudie(school, richting, diploma, afstudeerjaar);

            _pers.addVervolgstudie(v);
        }
    }
}
