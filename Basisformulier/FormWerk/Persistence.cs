using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormWerk
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

        public List<Werk> getWerkenFromDB()
        {
            List<Werk> lijst = new List<Werk>();

            MySqlCommand cmd = new MySqlCommand("select * from werk", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Werk w = new Werk(dataReader["Job"].ToString(), dataReader["Bedrijf"].ToString(),
                    dataReader["Beginjaar"].ToString(), dataReader["Land"].ToString());
                lijst.Add(w);
            }

            conn.Close();
            return lijst;
        }
        public void addWerk(Werk item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into werk (Job, Bedrijf, Beginjaar, Land) values('" + item.Job + "','" + item.Bedrijf + "','" + item.Beginjaar + "' + '" + item.Land + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
