using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lijst
{
    class Business
    {
        private Persistence _pers;
        private List<LijstOudleerling> _oudleerlingen;

        public List<LijstOudleerling> oudleerlingen
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

            foreach (LijstOudleerling item in _oudleerlingen)
            {
                result.Add(item.ToString());
            }

            return result;
        }

    }
}
