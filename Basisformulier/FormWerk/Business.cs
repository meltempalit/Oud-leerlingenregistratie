using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormWerk
{
    class Business
    {
        private Persistence _pers;

        private List<Werk> _werk;
        public List<Werk> Werk
        {
            get { return _werk; }
            set { _werk = value; }
        }

        public Business()
        {
            _pers = new Persistence();
            _werk = _pers.getWerkenFromDB();
        }

        public List<string> getWerken()
        {
            List<string> result = new List<string>();

            foreach (Werk item in _werk)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public void voegToe(string job, string bedrijf, string beginjaar, string land)
        {
            Werk w = new Werk(job, bedrijf, beginjaar, land);

            _pers.addWerk(w);
        }
    }
}
