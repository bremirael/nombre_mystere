using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace nombreMystere
{
    /// <summary>
    /// Logique d'interaction pour VisuJoueur.xaml
    /// </summary>
    public partial class VisuJoueur : Window
    {
        public VisuJoueur()
        {
            InitializeComponent();
            Console.WriteLine("GLOOOOOOOOOOOOOOOOOOOOOOOOOO");
            List<Joueur> joueurs = new List<Joueur>();
            Console.WriteLine("tontonnnnnnnnn");
            ListJoueur list = new ListJoueur();
            Console.WriteLine("GLuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            joueurs = list.RecupListJoueur();
            Console.WriteLine("Glaaaaaaaaaaaaaaaaaaaaa");
            DataJoueur.ItemsSource = joueurs;
        }
    }
}
