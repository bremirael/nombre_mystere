using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace nombreMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Quitter_Appli(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Nouveau_Joueur(object sender, RoutedEventArgs e)
        {
            FormCreationJoueur f = new FormCreationJoueur();
            f.Show();
        }

        private void Visu_Joueur(object sender, RoutedEventArgs e)
        {
            VisuJoueur visu = new VisuJoueur();
            visu.Show();
        }

        private void Visu_Score(object sender, RoutedEventArgs e)
        {
            DataPartie.Visibility = System.Windows.Visibility.Visible;

            try
            {
                Bdd bdd = new Bdd();
                MySqlCommand cmd = new MySqlCommand("SELECT joueur.nom AS nom, " +
                                                          " partie.partie_jouees AS partie_jouees, " +
                                                          " partie.score AS score, " +
                                                          " partie.nb_coups AS nb_coups " +                              
                                                    "FROM partie " + 
                                                    "INNER JOIN joueur ON joueur.id = partie.id_joueur ", bdd.GetCnx());
                Console.WriteLine(cmd);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                DataPartie.DataContext = ds;
                bdd.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Nouvelle_Partie(object sender, RoutedEventArgs e)
        {
            FormIdentification fi = new FormIdentification();
            fi.Show();
        }
    }
}
