using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombreMystere
{
    public class Joueur
    {
        private string nom;
        private string login;

        public string Nom { get => nom; set => nom = value; }
        public string Login { get => login; set => login = value; }


        public Joueur(string nom, string login)
        {
            this.Nom = nom;
            this.Login = login;
        }

        public Joueur(string nom)
        {
            this.Nom = nom;
        }

        public Joueur()
        {
        }

        public override string ToString()
        {
            return  Nom + " " + Login;
        }
    }

}
