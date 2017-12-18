using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nombreMystere
{
    public class Partie : Bdd
    {
        private int partie_jouees;
        private int score;
        private int nb_coups;
        private string nomJoueur;

        public int Partie_jouees { get => partie_jouees; set => partie_jouees = value; }
        public int Score { get => score; set => score = value; }
        public int Nb_coups { get => nb_coups; set => nb_coups = value; }
        public string NomJoueur { get => nomJoueur; set => nomJoueur = value; }

        public Partie()
        {

        }

        public int GetNbMystere()
        {
            Random random = new Random();
            int nbMystere = random.Next(500);
            return nbMystere;
        }

        public void UpdatePartie(int id, int partie_jouees, int score, int nb_coups)
        {
            try
            {
                string query = "UPDATE partie SET " +
                               "partie_jouees = " + partie_jouees +
                               ", score = " + score +
                               ", nb_coups = " + nb_coups +
                               " WHERE id_joueur = " + id;
                MySqlCommand cmd = new MySqlCommand(query, base.GetCnx());
                cmd.ExecuteNonQuery();
                base.CloseConnection();
            }
            catch (MySqlException e)
            {
                MessageBox.Show("erreur : " + e.ErrorCode);
            }
        }


        public int SelectScore(int id)
        {
            int scoreMax = 0;
            string query = "SELECT score FROM partie WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(query, base.GetCnx());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                scoreMax   = Convert.ToInt32(reader["score"]);
            }
            base.CloseConnection();
            return scoreMax;
        }

        public int SelectNbCoups(int id)
        {
            int nb_coups_max = 0;
            string query = "SELECT nb_coups FROM partie WHERE id = " + id;
            MySqlCommand cmd = new MySqlCommand(query, base.GetCnx());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                nb_coups_max = Convert.ToInt32(reader["nb_coups"]);
            }
            base.CloseConnection();
            return nb_coups_max;
        }
    }
}
