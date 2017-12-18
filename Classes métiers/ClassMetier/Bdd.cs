using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace nombreMystere
{

    public class Bdd
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Constructeur
        public Bdd()
        {
            this.InitConnection();
        }

        // Méthode pour initialiser la connexion
        private void InitConnection()
        {
            server = "localhost";
            database = "nombre_mystere";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetCnx()
        {
            try
            {
                connection.Open();
     
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter à la base de données");
                        break;

                    case 1045:
                        MessageBox.Show("Le couple identifiant / mot de passe n'existe pas, veuillez ressayer");
                        break;
                }
            }
            return connection;
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}