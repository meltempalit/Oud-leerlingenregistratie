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

        private List<StudieInfo> _studie;
        public List<StudieInfo> studie
        {
            get { return _studie; }
            set { _studie = value; }
        }

        private List<WerkInfo> _werk;
        public List<WerkInfo> werk
        {
            get { return _werk; }
            set { _werk = value; }
        }

        public Business()
        {
            _pers = new Persistence();
            _persoon = _pers.getPersonenFromDB();
            _post = _pers.getPostsFromDB();
            _studie = _pers.getStudiesFromDB();
            _werk = _pers.getWerkenFromDB();
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

        public List<string> getStudies()
        {
            List<string> result = new List<string>();

            foreach (StudieInfo item in _studie)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public List<string> getWerken()
        {
            List<string> result = new List<string>();

            foreach (WerkInfo item in _werk)
            {
                result.Add(item.ToString());
            }
            return result;

        }
    }
}
