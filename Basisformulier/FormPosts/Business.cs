using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPosts
{
    class Business
    {
        private Persistence _pers;

        private List<Post> _post;
        public List<Post> post
        {
            get { return _post; }
            set { _post = value; }
        }

        public Business()
        {
            _pers = new Persistence();
            _post = _pers.getPostsFromDB();
        }

        public List<string> getPosts()
        {
            List<string> result = new List<string>();

            foreach(Post item in _post)
            {
                result.Add(item.ToString());
            }
            return result;
        }

        public void voegToe(string ervaring, string mededeling, string herinnering)
        {
            Post p = new Post(ervaring, mededeling, herinnering);

            _pers.addPost(p);
        }
    }
}
