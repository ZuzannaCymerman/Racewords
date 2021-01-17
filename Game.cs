using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Racewords
{
    /// <summary>
    /// Pole gry.
    /// </summary>
    public partial class Game : Gameplay
    {
        /// <summary>
        /// Inicjalizacja obiektów.
        /// </summary>
        public Game()
        {

            InitializeComponent();
            this.lettertab = new Letters[] { this.Letter1, this.Letter2, this.Letter3, this.Letter4, this.Letter5, this.Letter6, this.Letter7, this.Letter8, this.Letter9, this.Letter10, this.Letter11 };
            this.linestab = new Movement[] { this.pictureBox1, this.pictureBox2, this.pictureBox3, this.pictureBox4, this.pictureBox5 };
            this.Car = this.Skoda;
            this.WordLabel = this.Word;
            this.timer = this.timer1;
            letters = lettersfrench;
            InitializeAll();   
        }

        /// <summary>
        /// Nieskończona pętla gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            LetterMovementAll();
            Lines();
            GamePlayAll();
        }


        /// <summary>
        /// Obsługa klawiatury.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Skoda.Left += -skodaspeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                Skoda.Left += skodaspeed;
            }
            if (e.KeyCode == Keys.Up)
            {
                Skoda.Top += -skodaspeed;
            }
            if (e.KeyCode == Keys.Down)
            {

                Skoda.Top += skodaspeed;
            }
        }
        /// <summary>
        /// Wywołanie funkcji GamePlay oraz przypisanie wartości do labeli.
        /// </summary>
        /// <param name="Letter">litera</param>
        private void CollectWord(Letters Letter)
        {
            GamePlay(Letter);
            LevelLabel.Text = levellabeltext;
            Title.Text = title;
            Points.Text = "Punkty: " + points;
            Life.Text = "Życia: " + lives;
        }

      
        /// <summary>
        /// Wywoływanie gry dla każdej z literek.
        /// </summary>
        private void GamePlayAll()
        {
            for (int i = 0; i < lettertab.Length; i++)
            { CollectWord(lettertab[i]); }
        }
        /// <summary>
        /// Ruch ulicy.
        /// </summary>
        private void Lines()
        {
            for (int i = 0; i < linestab.Length; i++)
            { linestab[i].MoveLine(speed); }
        }
        /// <summary>
        /// Ruch wszystkich literek.
        /// </summary>
        private void LetterMovementAll()
        {
           

            for (int i = 0; i < lettertab.Length; i++)
            {
                if (i < lettertab.Length / 3)
                { lettertab[i].LettersMovement(letterspeed, letters); }
                else if (i >= lettertab.Length / 3 & i < 2 * lettertab.Length / 3)
                { lettertab[i].LettersMovement(letterspeed + 1, letters); }
                else if (i >= 2 * lettertab.Length / 3)
                { lettertab[i].LettersMovement(letterspeed - 1, letters); }
            }
        }

        /// <summary>
        /// Inicjalizacja położenia literek.
        /// </summary>
        private void InitializeAll()
        {
            for (int i = 0; i < lettertab.Length; i++)
            { lettertab[i].InitializeLetter(letters); ; }

        }


        /// <summary>
        /// Funckje obiektów formularza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Skoda_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void pictureBox5_Click(object sender, EventArgs e) { }
        private void Letter1_Click_1(object sender, EventArgs e) { }
        private void Letter2_Click(object sender, EventArgs e) { }
        private void Letter3_Click(object sender, EventArgs e) { }
        private void Letter4_Click(object sender, EventArgs e) { }
        private void Word_Click(object sender, EventArgs e) { }
        private void Letter5_Click(object sender, EventArgs e) { }
        private void Title_Click(object sender, EventArgs e) { }
        private void Letter6_Click(object sender, EventArgs e) { }
        private void Letter7_Click(object sender, EventArgs e) { }
        private void Letter8_Click(object sender, EventArgs e) { }
        private void Letter9_Click(object sender, EventArgs e) { }
        private void Points_Click(object sender, EventArgs e) { }
        private void Letter10_Click(object sender, EventArgs e) { }
        private void Skoda_Click_1(object sender, EventArgs e) { }
        private void LevelLabel_Click(object sender, EventArgs e) { }

        private void Letter11_Click(object sender, EventArgs e)
        {

        }
    }

}
