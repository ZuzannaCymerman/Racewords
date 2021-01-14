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

    public partial class Form1 : Gameplay
    {
        Dictionary<string, string> word = new Dictionary<string, string>(){
            {"C H A T", "K O T"},
            {"N U I T", "N O C"},
            {"L A I T", "M L E K O"},
            {"C H I E N", "P I E S" },
            {"C H I C", "W D Z I Ę K" }
        };

        string[] letters = { "L", "A", "I", "T", "C", "H", "I", "E", "N", "U", };
        string[] letterstranslation = { "K", "O", "P", "S", "W", "M", "N", "C", "D", "I", "Ę", "Z", "E", "L", "T" };
        int speed = 5;
        int letterspeed = 6;
        string bump = "";
        int points = 0;
        int i = 0;
        int k = 0;
        int lives = 3;
        int level = 0;
        string collect = "";
        int skodaspeed = 35;
        public Form1()
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

        private void CollectWord(Letters Letter)
        {
            string key = word.ElementAt(k).Key;
            string value = word.ElementAt(k).Value;
            string title = "";
            string levellabeltext = "";

            if (level == 0)
            {
                levellabeltext = "Pierwszy poziom. Zbierz francuskie słowo.";
                title = key + " - " + value;
                collect = key;
            }
            else if (level == 1)
            {
                levellabeltext = "Drugi poziom. Zbierz polskie słowo.";
                title = key;
                collect = value;
                k = 0;
                letterspeed = 6;
            }
            else if (level == 2)
            {
                levellabeltext = "Drugi poziom. Zbierz francuskie słowo ze słuchu.";
                title = "";
                collect = key;

            }
            this.LevelLabel.Text = levellabeltext;
            Title.Text = title;
            Points.Text = "Punkty: " + points;
            Life.Text = "Życia: " + lives;
            SkodaInteraction(Letter, key);   
        }

        //Skoda Gameplay
        private void SkodaInteraction(Letters Letter, string key)
        {
           
            if (Skoda.Bounds.IntersectsWith(Letter.Bounds))
            {
               
                bump = Letter.Text;
                if (bump == collect.Split(' ')[i])
                {
                    
                    Word.Text = Word.Text + collect.Split(' ')[i];
                    if (i == collect.Split(' ').Length - 1)
                    {
                        i = 0;
                        points++;
                        k++;
                        Word.Text = null;
                        letterspeed++;
                        if (points == 1)
                        {
                            level++;

                            points = 0;
                            playSimpleSound(key.ToLower().Replace(" ",""));
                        }
                    }
                    else
                    {
                        i++;
                    }
                    Letter.InitializeLetter(letters);
                    Letter.LettersMovement(letterspeed, letters);

                }
                else if (bump != collect.Split(' ')[i])
                {
                    if (lives != 0)
                    {
                        lives--;
                        Letter.InitializeLetter(letters);
                        Letter.LettersMovement(letterspeed, letters);
                    }
                    else if (lives == 0)
                    {
                        Letter.BackColor = Color.Red;
                        Letter.ForeColor = Color.White;
                        Word.Text = "Koniec gry";
                        timer1.Enabled = false;
                    }

                }

            }
        }

        private void playSimpleSound(string nazwa)
        {
            SoundPlayer simpleSound = new SoundPlayer($@"C:\Users\Zuzanna\Desktop\Racewords\Racewords\sounds\{nazwa}.wav");
            simpleSound.Play();
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
