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
    public partial class FormIdentification : Form
    {
        public FormIdentification()
        {
            InitializeComponent();
        }

        private void JouerBtn_Click(object sender, EventArgs e)
        {
            /***
             * Nous avons mis le champ login à unique. 
             * Comme ça nous sommes sûr qu'il n'y ait pas 
             * de login en double
             ***/
            Bdd bdd = new Bdd();
            String nom = nomIdBox.Text;
            String login = loginIdBox.Text;
            int id = 0;
            bool valid = false;

            string query = "SELECT * FROM joueur WHERE login = '" + login + "'";

            MySqlCommand cmd = new MySqlCommand(query, bdd.GetCnx());

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (nom == reader["nom"].ToString() && login == reader["login"].ToString())
                {
                    valid = true;
                    id = Convert.ToInt32(reader["id"]);
                }
            }
            if (valid == true)
            {
                FormProposition fp = new FormProposition(id);
                fp.Show();
            }
            else
            {
                MessageBox.Show("Le joueur n'existe pas, veuillez en créer au préalable et vous identifiez de nouveau");
            }
        }
    }
}
