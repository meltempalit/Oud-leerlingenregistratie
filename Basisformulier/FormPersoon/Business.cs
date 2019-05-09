using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPersoon
{
    class Business
    {
        private Persistence _pers;
        private List<KlassePersoon> _persoon;
        public List<KlassePersoon> persoon
        {
            get { return _persoon; }
            set { _persoon = value; }
        }

        public Business()
        {
            _pers = new Persistence();
            persoon = _pers.getPersonenFromDB();
        }

       public List<string> getPersonen()
        {
            List<string> result = new List<string>();

            foreach (KlassePersoon item in _persoon)
            {
                result.Add(item.ToString());
            }
            return result;

        }
        public void voegPersoon(string naam, string fnaam, string geboorte, string email, string telo, string afstjaar, string richting)
        {
            KlassePersoon p = new KlassePersoon(naam, fnaam, geboorte, email, telo, afstjaar, richting);

            _pers.addPersoon(p);
        }
    }

    
}
