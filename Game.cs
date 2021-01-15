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

    public partial class Game : Gameplay
    {
      
        public Game()
        {
            InitializeComponent();
            InitializeAll();   
        }

        //Main
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            LetterMovementAll();
            Lines();
            GamePlayAll();
        }


        //Keyboard 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Skoda.Left += -this.skodaspeed;
            }
            if (e.KeyCode == Keys.Right)
            {
                Skoda.Left += this.skodaspeed;
            }
            if (e.KeyCode == Keys.Up)
            {
                Skoda.Top += -this.skodaspeed;
            }
            if (e.KeyCode == Keys.Down)
            {

                Skoda.Top += this.skodaspeed;
            }
        }

        private void CollectWord(Letters Letter)
        {
            GamePlay(Letter);
            LevelLabel.Text = levellabeltext;
            Title.Text = title;
            Points.Text = "Punkty: " + points;
            Life.Text = "Życia: " + lives;
        }

      
        //Gameplay
        private void GamePlayAll()
        {
            for (int i = 0; i < lettertab.Length; i++)
            { CollectWord(lettertab[i]); }
        }
        private void Lines()
        {
            for (int i = 0; i < linestab.Length; i++)
            { linestab[i].MoveLine(speed); }
        }

        //Letters Movement
        private void LetterMovementAll()
        {
            if (level == 1)
            {
                letters = letterstranslation;
            }

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

        //Letters Initialization
        private void InitializeAll()
        {
            if (level == 1)
            {
                letters = letterstranslation;
            }
            for (int i = 0; i < lettertab.Length; i++)
            { lettertab[i].InitializeLetter(letters); ; }

        }


        //Components
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
    }

}
