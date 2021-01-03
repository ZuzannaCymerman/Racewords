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

    public partial class Form1 : Form
    {
        Dictionary<string, string> word = new Dictionary<string, string>(){
            {"C H A T", "K O T"},
            {"N U I T", "N O C"},
            {"L A I T", "M L E K O"},
            {"C H I E N", "P I E S" },
            {"C H I C", "W D Z I Ę K" }
        };

        string[] letters = { "L", "A" , "I", "T", "C", "H","I", "E", "N", "U", };
        string[] letterstranslation = { "K", "O", "P", "S", "W", "M", "N", "C", "D", "I", "Ę", "Z", "E", "L" };
        int speed = 5;
        int letterspeed = 6;
        string bump = "";
        int points = 0;
        int i = 0;
        int k = 0;
        int lives = 3;
        int level = 0;
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

        private void CollectWord(Label Letter)
        {
            string key = key = word.ElementAt(k).Key; ;          
            string value = value = word.ElementAt(k).Value;
            string collect = "";
            string title = "";
            string levellabeltext = "";
            if (level == 0)
            {
                levellabeltext = "First level. Collect the french word";
                title = key + " - " + value;
                collect = key;
               
            }
            else if (level == 1)
            {
                levellabeltext = "Second level. Collect the translation";
                title = key;
                collect = value;
                k = 0;
            }
            LevelLabel.Text = levellabeltext;
            Title.Text = title;
            Points.Text ="Points: "+ points;
            Life.Text = "Lives: " + lives;
            
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
                            if (points == 5)
                            {
                                level++;
                            }
                        }
                        else
                        {
                            i++;
                        }
                        Letters.InitializeLetter(Letter, letters);
                        Letters.LettersMovement(Letter, letterspeed, letters);

                    }
                    else if (bump != collect.Split(' ')[i])
                    {
                        if (lives != 0)
                        {
                            lives--;
                            Letters.InitializeLetter(Letter, letters);
                            Letters.LettersMovement(Letter, letterspeed, letters);
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


        //Gameplay
        private void GamePlayAll()
        {
            CollectWord(Letter1);
            CollectWord(Letter2);
            CollectWord(Letter3);
            CollectWord(Letter4);
            CollectWord(Letter5);
            CollectWord(Letter6);
            CollectWord(Letter7);
            CollectWord(Letter8);
            CollectWord(Letter9);
            CollectWord(Letter10);



        }
        private void Lines()
        {
            pictureBox1.Top = Movement.MoveSingleLine(pictureBox1.Top, speed);
            pictureBox2.Top = Movement.MoveSingleLine(pictureBox2.Top, speed);
            pictureBox3.Top = Movement.MoveSingleLine(pictureBox3.Top, speed);
            pictureBox4.Top = Movement.MoveSingleLine(pictureBox4.Top, speed);
            pictureBox5.Top = Movement.MoveSingleLine(pictureBox5.Top, speed);
        }
        private void LetterMovementAll()
        {

            if (level == 1)
            {
                letters = letterstranslation;
            }
           
            Letters.LettersMovement(Letter1, letterspeed+1, letters);
            Letters.LettersMovement(Letter2, letterspeed, letters);
            Letters.LettersMovement(Letter3, letterspeed-1, letters);
            Letters.LettersMovement(Letter4, letterspeed, letters);
            Letters.LettersMovement(Letter5, letterspeed+3, letters);
            Letters.LettersMovement(Letter6, letterspeed, letters);
            Letters.LettersMovement(Letter7, letterspeed, letters);
            Letters.LettersMovement(Letter8, letterspeed+1, letters);
            Letters.LettersMovement(Letter9, letterspeed, letters);
            Letters.LettersMovement(Letter10, letterspeed, letters);

        }
        private void InitializeAll()
        {
           if (level == 1)
            {
                letters = letterstranslation;
            }

            Letters.InitializeLetter(Letter1, letters);
            Letters.InitializeLetter(Letter2, letters);
            Letters.InitializeLetter(Letter3, letters);
            Letters.InitializeLetter(Letter4, letters);
            Letters.InitializeLetter(Letter5, letters);
            Letters.InitializeLetter(Letter6, letters);
            Letters.InitializeLetter(Letter7, letters);
            Letters.InitializeLetter(Letter8, letters);
            Letters.InitializeLetter(Letter9, letters);
            Letters.InitializeLetter(Letter10, letters);

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

        private void Skoda_Click_1(object sender, EventArgs e)
        {

        }

        private void LevelLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
