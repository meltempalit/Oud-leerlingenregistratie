using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Basisformulier
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

        public List<Oudleerling> GetOudleerlingenFromDB()
        {
            List<Oudleerling> lijst = new List<Oudleerling>();

            MySqlCommand cmd = new MySqlCommand("select * from oudleerlingen.personen",conn);
           
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            
            while (dataReader.Read())
            {
                Oudleerling o = new Oudleerling(Convert.ToInt32(dataReader["idPersonen"]), dataReader["naam"].ToString(), dataReader["familienaam"].ToString());
                lijst.Add(o);
            }

            conn.Close();

            return lijst;

        }

    }
}
