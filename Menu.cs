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
    /// <summary>
    ///Formularz Menu. Jest wywoływany jako pierwszy w Program.cs 
    /// </summary>
    public partial class Menu : Form
    {   /// <summary>
        ///Obrazek żółtej Skody. 
        /// </summary>
        Image SkodaYellow = global::Racewords.Properties.Resources.Skoda_yellow;
        /// <summary>
        /// Obrazek zielonej Skody.
        /// </summary>
        Image SkodaGreen = global::Racewords.Properties.Resources.Skoda_green;
        /// <summary>
        /// Obrazek czerwonej Skody.
        /// </summary>
        Image SkodaRed = global::Racewords.Properties.Resources.Skoda;
        /// <summary>
        /// Zmienna, do której przypisywany jest obrazek Skody.
        /// </summary>
        Image SkodaImage;
        /// <summary>
        /// Zmienna, do której przypisywana jest wybrana wartość prędkości.
        /// </summary>
        int inputspeed;
        /// <summary>
        /// Zmienna sprawdzająca, czy wybrana została prędkość.
        /// </summary>
        bool changed = false;
        /// <summary>
        /// Inicjalizacja obiektów.
        /// </summary>

        public Menu()
        {
            InitializeComponent();

        }
            private void Menu_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funkcja, która określa, co się dzieje ponaciśnięciu przycisku START GAME. Tworzony jest wtedy nowy obiekt typ Game oraz jest wyświetlany wraz ze schowaniem się Menu. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            
            if ((Green.Checked || Yellow.Checked || Red.Checked)&changed)
            {
                
                Game new_game = new Game();
                new_game.Skoda.Image = SkodaRed;
                new_game.Skoda.Image = SkodaImage;
                new_game.letterspeed = inputspeed;
                new_game.initletterspeed = inputspeed;
                new_game.Show();
                this.Hide();
                Green.Checked = false;
                Yellow.Checked = false;
                Red.Checked = false;
                new_game.FormClosed += new FormClosedEventHandler(new_game_FormClosed);
                      
            }
            else if (!(Green.Checked || Yellow.Checked || Red.Checked))
            {
                StartText.Text = "Nie wybrałeś koloru Skody.";
            }
            else if (changed == false)
            {
                StartText.Text = "Nie wybrałeś prędkości.";
            }

        }  
        /// <summary>
        /// Funkcja określająca, co się dzieje po zamknięciu okna gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void new_game_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Green.Checked || Yellow.Checked || Red.Checked)
            {
                StartText.Text = "Kliknij START GAME, by rozpocząć ponownie.";
            }
            this.Show();

        }
        /// <summary>
        /// Na wybór koloru żółtego, obrazek Skody zmieniany jest na żółty.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Yellow_CheckedChanged(object sender, EventArgs e)
        {
            SkodaImage = SkodaYellow;
        }
        /// <summary>
        /// Na wybór koloru zielonego, obrazek Skody zmieniany jest na zielony.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Green_CheckedChanged(object sender, EventArgs e)
        {
            SkodaImage = SkodaGreen;
        }
        /// <summary>
        /// Na wybór koloru czerwonego, obrazek Skody zmieniany jest na czerwony.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Red_CheckedChanged(object sender, EventArgs e)
        {
            SkodaImage = SkodaRed;
        }

        private void StartText_Click(object sender, EventArgs e)
        {

        }
       /// <summary>
       /// Przypisanie do zmiennej "inputspeed" wybranej prędkości.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed = true;
        
            inputspeed = comboBox1.SelectedIndex + 1;

        }

 
    }
}
