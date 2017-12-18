using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombreMystere
{
    public class ListJoueur : Bdd
    {


        public ListJoueur() { }

        public List<Joueur> RecupListJoueur()
        {
            List<Joueur> joueur = new List<Joueur>();
            string query = "SELECT * FROM Joueur";

            MySqlCommand cmd = new MySqlCommand(query, base.GetCnx());

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Joueur j = new Joueur
                {
                    Nom = reader["nom"].ToString(),
                    Login = reader["login"].ToString()
                };
                joueur.Add(j);
            }
            return joueur;
        }

        /*public List<Partie> RecupListPartie()
        {
            List<Partie> partie = new List<Partie>();
            string query = "SELECT joueur.nom AS nom, " +
                                 " partie.partie_jouees AS partie_jouees, " +
                                 " partie.score AS score, " +
                                 " partie.nb_coups AS nb_coups " +
                           "FROM partie " +
                           "INNER JOIN joueur ON joueur.id = partie.id_joueur ";
            MySqlCommand cmd = new MySqlCommand(query, base.GetCnx());

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Partie p = new Partie
                {
                    NomJoueur = reader["nom"].ToString(),
                    Partie_jouees = Convert.ToInt32(reader["partie_jouees"]),
                    Score = Convert.ToInt32(reader["score"]),
                    Nb_coups = Convert.ToInt32(reader["nb_coups"])
                };
                partie.Add(p);
            }
            return partie;
        } */
    }
}
