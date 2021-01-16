using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racewords
{
    public partial class Menu : Form
    {
        Image SkodaYellow = global::Racewords.Properties.Resources.Skoda_yellow;
        Image SkodaGreen = global::Racewords.Properties.Resources.Skoda_green;
        Image SkodaRed = global::Racewords.Properties.Resources.Skoda;
        Image SkodaImage;

        public Menu()
        {
            InitializeComponent();

        }
            private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            if (Green.Checked || Yellow.Checked || Red.Checked)
            {
                
                Game new_game = new Game();
                new_game.Skoda.Image = SkodaRed;
                new_game.Skoda.Image = SkodaImage;
                new_game.Show();
                this.Hide();
                new_game.FormClosed += new FormClosedEventHandler(new_game_FormClosed);
                      
            }
            else
            {
                StartText.Text = "Nie wybrałeś koloru Skody.";
            }
        }   
        void new_game_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Green.Checked || Yellow.Checked || Red.Checked)
            {
                StartText.Text = "Kliknij START GAME, by rozpocząć ponownie.";
            }
            this.Show();

        }

        private void Yellow_CheckedChanged(object sender, EventArgs e)
        {
            SkodaImage = SkodaYellow;
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            SkodaImage = SkodaGreen;
        }

        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            SkodaImage = SkodaRed;
        }

        private void StartText_Click(object sender, EventArgs e)
        {

        }
    }
}
