using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormVervolgstudies
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

        public List<Vervolgstudie> getVervolgstudiesFromDB()
        {
            List<Vervolgstudie> lijst = new List<Vervolgstudie>();

            MySqlCommand cmd = new MySqlCommand("select * from vervolgstudies", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Vervolgstudie v = new Vervolgstudie(dataReader["School_na_SLCB"].ToString(), dataReader["Richting"].ToString(),
                    dataReader["Diploma"].ToString(), dataReader["Afstudeerjaar"].ToString());
                lijst.Add(v);
            }

            conn.Close();
            return lijst;
        }
        public void addVervolgstudie(Vervolgstudie item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into vervolgstudies (School_na_SLCB, Richting, Diploma, Afstudeerjaar) values('" + item.School + "','" + item.Richting + "','" + item.Diploma + "' , '" + item.Afstudeerjaar + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
