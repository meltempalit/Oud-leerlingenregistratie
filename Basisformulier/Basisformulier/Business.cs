using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basisformulier
{
    class Business
    {
        private Persistence _pers;
        private List<Oudleerling> _oudleerlingen;

        public List<Oudleerling> oudleerlingen
        {
            get { return _oudleerlingen; }
            set { _oudleerlingen = value; }
        }

        public Business()
        {
            _pers = new Persistence();
            _oudleerlingen = _pers.GetOudleerlingenFromDB();
        }

        public List<string> getOudleerlingen()
        {
            List<string> result = new List<string>();

            foreach(Oudleerling item in _oudleerlingen)
            {
                result.Add(item.ToString());
            }

            return result;
        }

    }
}
