using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nombreMystere
{
    public partial class FormCreationJoueur : Form
    {
        public FormCreationJoueur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();

            String nom = nomBox.Text;
            String login = loginBox.Text;

            string query = "INSERT INTO nombre_mystere.joueur(nom, login) VALUES('"+nom+"','"+login+"')";

            MySqlCommand cmd = new MySqlCommand(query, bdd.GetCnx());
            cmd.ExecuteNonQuery();
          
            long id = cmd.LastInsertedId;

            MessageBox.Show(id.ToString());

            bdd.CloseConnection();
            
                string query2 = "INSERT INTO nombre_mystere.partie(partie_jouees, score, nb_coups, id_joueur) " +
                                "VALUES(0, 0, 0, "+id+")";
                MySqlCommand cmd2 = new MySqlCommand(query2, bdd.GetCnx());

            if (cmd2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Nouveau Joueur créé");
                bdd.CloseConnection();
            }
            else
            {
                MessageBox.Show("Le joueur n'est pas dans la table des scores");
            }

        }
    }
}
