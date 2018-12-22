using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lijst
{
    class Persistence
    {
        private string _connectionstring;
        MySqlConnection conn;

        public Persistence()
        {
            _connectionstring = "server=localhost;user id=root;database=oudleerlingen;Password='Test123';";
            conn = new MySqlConnection(_connectionstring);
        }

        public List<LijstOudleerling> GetOudleerlingenFromDB()
        {
            List<LijstOudleerling> lijst = new List<LijstOudleerling>();

            MySqlCommand cmd = new MySqlCommand("select * from oudleerlingen.personen", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                LijstOudleerling o = new LijstOudleerling(Convert.ToInt32(dataReader["idPersonen"]), dataReader["naam"].ToString(), dataReader["familienaam"].ToString());
                lijst.Add(o);
            }

            conn.Close();

            return lijst;

        }

    }
}
