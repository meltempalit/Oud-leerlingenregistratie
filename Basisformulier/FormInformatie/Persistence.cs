﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FormInformatie
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

        public List<PersoonInfo> getPersonenFromDB()
        {
            List<PersoonInfo> lijst = new List<PersoonInfo>();

            MySqlCommand cmd = new MySqlCommand("select*from personen", conn);

            conn.Open();

            MySqlDataReader dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                PersoonInfo p = new PersoonInfo(Convert.ToInt32(dataReader["idPersonen"]), dataReader["naam"].ToString(), dataReader["familienaam"].ToString(), dataReader["geboortedatum"].ToString(), dataReader["e_mail"].ToString(), dataReader["telefoonnummer"].ToString(), dataReader["afstudeerjaar"].ToString(), dataReader["richting_slcb"].ToString());
                lijst.Add(p);
            }


            conn.Close();
            return lijst;
        }

        public List<PostInfo> getPostsFromDB()
        {
            List<PostInfo> lijst = new List<PostInfo>();

            MySqlCommand cmd = new MySqlCommand("select * from posts", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                PostInfo p = new PostInfo(Convert.ToInt32(dataReader["idposts"]), dataReader["ervaringen"].ToString(), dataReader["delen"].ToString(), dataReader["herinneringen_slcb"].ToString());
                lijst.Add(p);
            }

            conn.Close();
            return lijst;
        }
        
    }

}
