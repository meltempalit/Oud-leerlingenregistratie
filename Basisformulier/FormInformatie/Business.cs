using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormInformatie
{
    class Business : Persistence
    {
        private Persistence _pers;
        private List<PersoonInfo> _persoon;
        public List<PersoonInfo> persoon
        {
            get { return _persoon; }
            set { _persoon = value; }
        }

        private List<PostInfo> _post;
        public List<PostInfo> post
        {
            get { return _post; }
            set { _post = value; }
        }

        public Business()
        {
            _pers = new Persistence();
            _persoon = _pers.getPersonenFromDB();
            _post = _pers.getPostsFromDB();
        }

        public List<string> getPersonen()
        {
            List<string> result = new List<string>();

            foreach (PersoonInfo item in _persoon)
            {
                result.Add(item.ToString());
            }
            return result;

        }
        public List<string> getPosts()
        {
            List<string> result = new List<string>();

            foreach (PostInfo item in _post)
            {
                result.Add(item.ToString());
            }
            return result;
        }
    }
}
