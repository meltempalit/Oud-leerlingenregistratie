using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormPersoon
{
    class Persistence
    {
        private string _connection;
        MySqlConnection conn;

        public Persistence()
        {
            _connection = "server=localhost;Password='Test123';user id=root;database=oudleerlingen";
            conn = new MySqlConnection(_connection);
        }

        public List<KlassePersoon> getPersonenFromDB()
        {
            List<KlassePersoon> lijst = new List<KlassePersoon>();

            MySqlCommand cmd = new MySqlCommand("select*from personen", conn);

            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                KlassePersoon p = new KlassePersoon(dataReader["naam"].ToString(), dataReader["familienaam"].ToString(), dataReader["geboortedatum"].ToString(), dataReader["e_mail"].ToString(), dataReader["telefoonnummer"].ToString(), dataReader["afstudeerjaar"].ToString(), dataReader["richting_slcb"].ToString());
                lijst.Add(p);
            }


            conn.Close();
            return lijst;
        }

        public void addPersoon(KlassePersoon item)
        {
            MySqlCommand cmd = new MySqlCommand("insert into personen (naam, familienaam, geboortedatum, e_mail, telefoonnummer, afstudeerjaar, richting_slcb) values('" + item.naam + "','" + item.familienaam + "','" + item.geboorte + "','" + item.email + "','" + item.telefoon + "','" + item.afstudeerj + "','" + item.richting+ "' )", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
