using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormPosts
{
    class Persistence
    {
        private string _connectionstring;
        MySqlConnection conn;

        public Persistence()
        {
            _connectionstring = "server=localhost;Password='Test123';user id=root;database=oudleerlingen";
            conn = new MySqlConnection(_connectionstring);
        }

        public List<Post> getPostsFromDB()
        {
            List<Post> lijst = new List<Post>();

            MySqlCommand cmd = new MySqlCommand("select * from posts",conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                Post p = new Post(dataReader["ervaringen"].ToString(), dataReader["delen"].ToString(), dataReader["herinneringen_slcb"].ToString());
                lijst.Add(p);
           }

            conn.Close();
            return lijst;
        }
        public void addPost(Post item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into posts (ervaringen, delen, herinneringen_slcb) values('" + item.ervaring + "','" + item.mededeling + "','" + item.herinnering+"')",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
