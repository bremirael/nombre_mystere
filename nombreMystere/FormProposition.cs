using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace nombreMystere
{
    public partial class FormProposition : Form
    {
        private int nbMystere;
        private int nbCoups = 1;
        private int nbParties = 1;
        private int score = 100;
        private int id;

        public FormProposition(int id)
        {
            InitializeComponent();
            Partie partie = new Partie();
            this.nbMystere = partie.GetNbMystere();
            this.id = id;
            System.Windows.MessageBox.Show(this.nbMystere.ToString());
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void propositionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Partie p = new Partie();
            int nbChoice = Int32.Parse(propositionBox.Text);
            // MessageBox.Show(this.nbCoups.ToString());
            if (nbChoice > this.nbMystere)
            {
                System.Windows.MessageBox.Show("Le nombre choisi est plus grand que le nombre mystère");
                this.nbCoups++;
            }
            else if (nbChoice < this.nbMystere)
            {
                System.Windows.MessageBox.Show("Le nombre choisi est plus petit que le nombre mystère");
                this.nbCoups++;
            }
            else if (nbChoice <= 0 || nbChoice > 500)
            {
                System.Windows.MessageBox.Show("Veuillez choisir un nombre supérieur à 0 et inférieur à 500");
                this.nbCoups++;
            }
            else if (nbChoice == this.nbMystere)
            {
                System.Windows.MessageBox.Show("Vous avez gagné !! Le nombre mystère était : " + this.nbMystere.ToString());
                if (System.Windows.MessageBox.Show("Voulez-vous continuer la partie ?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    int meilleurNbCoups = 0;
                    int meilleurScore = 0;
                    meilleurNbCoups = p.SelectNbCoups(this.id);
                    System.Windows.MessageBox.Show(meilleurNbCoups.ToString());

                    if (this.nbCoups > meilleurNbCoups)
                    {
                        
                        this.score = this.score - this.nbCoups;
                        meilleurScore = p.SelectScore(this.id);
                        if (this.score > meilleurScore)
                        {
                            p.UpdatePartie(this.id, this.nbParties, this.score, meilleurNbCoups);
                        }
                        else
                        {
                            p.UpdatePartie(this.id, this.nbParties, meilleurScore, meilleurNbCoups);
                        }
                    }
                    else
                    {
                        this.score = this.score - this.nbCoups;
                        meilleurScore = p.SelectScore(this.id);
                        if (this.score > meilleurScore)
                        {
                            p.UpdatePartie(this.id, this.nbParties, this.score, this.nbCoups);
                        }
                        else
                        {
                            this.score = meilleurScore;
                            p.UpdatePartie(this.id, this.nbParties, this.score, this.nbCoups);
                        }
                    }
                }
                else
                {
                    // On incrémente une nouvelle partie et on récréer un nombre mystère afin de relancer une nouvelle partie
                    this.nbParties++;
                    this.nbMystere = p.GetNbMystere();
                    System.Windows.MessageBox.Show(this.nbMystere.ToString());
                    
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
