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
    public class Gameplay : Form
    {

        Dictionary<string, string> word = new Dictionary<string, string>(){
            {"C H A T", "K O T"},
            {"N U I T", "N O C"},
            {"L A I T", "M L E K O"},
            {"C H I E N", "P I E S" },
            {"C H I C", "W D Z I Ę K" }
        };
        //"K", "O", "P", "S", "W", "M", "D",
        public static Random r = new Random();
        public string[] letters;
        public string[] lettersfrench= { "L", "A", "I", "T", "C", "H", "I", "E", "N", "U" };
        public string[] letterspolish = { "L", "I", "T", "I", "E", "N", "Ę", "Z", "K", "O", "P", "S", "W", "M", "D", "C" };
        public int speed = 5;
        public int letterspeed = 6;
        public string bump = "";
        public int points = 0;
        public int i = 0;
        public int lives = 3;
        public int level = 0;
        public string collect = "";
        public int skodaspeed = 35;
        public PictureBox Car;
        public Letters WordLabel;
        public Timer timer;
        public string title = "";
        public string levellabeltext = "";
        private string directory = System.IO.Path.GetDirectoryName(Application.StartupPath).Replace("bin","");
        public static int random = r.Next(0, 4);
        public static int k = random;
        public int l = random;
        public int pointsmax = 3;

        public void GamePlay(Letters Letter)
        {
             string key = word.ElementAt(k).Key;
             string value = word.ElementAt(k).Value;

            if (level == 0)
            {
                letters = lettersfrench;
                levellabeltext = "Pierwszy poziom. Zbierz francuskie słowo.";
                title = key + " - " + value;
                collect = key;
            }
            else if (level == 1)
            {
                levellabeltext = "Drugi poziom. Zbierz polskie słowo.";
                letters = letterspolish;
                title = key;
                collect = value;
                letterspeed = 6;
            }
            else if (level == 2)
            {
                letters = lettersfrench;
                levellabeltext = "Trzeci poziom. Zbierz francuskie słowo ze słuchu.";
                title = "";
                collect = key;
                letterspeed = 6;
            }

            CarInteraction(Letter, key);
        }

        private void CarInteraction(Letters Letter, string key)
        {

            if (Car.Bounds.IntersectsWith(Letter.Bounds))
            {
                bump = Letter.Text;
               
                if (bump == collect.Split(' ')[i])
                {
                   // PlaySimpleSound("point");
                    WordLabel.Text = WordLabel.Text + collect.Split(' ')[i];

                    if (i == collect.Split(' ').Length - 1)
                    {
                        
                        i = 0;
                        points++;
                        if (k != 4) k++;
                        else k = 0;   
                        WordLabel.Text = null;
                        letterspeed++;
                       
                        if (points<pointsmax) PlaySimpleSound(word.ElementAt(k).Key.ToLower().Replace(" ", ""));

                        if (points == pointsmax)
                        {
                            k = l;
                            level++;
                            points = 0;
                            PlaySimpleSound(word.ElementAt(k).Key.ToLower().Replace(" ", ""));

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
                    PlaySimpleSound("bump");
                    if (lives != 0)
                    {
                        lives--;
                        Letter.InitializeLetter(letters);
                        Letter.LettersMovement(letterspeed, letters);
                    }
                    else if (lives == 0)
                    {
                        PlaySimpleSound("bump");
                        PlaySimpleSound(key.ToLower().Replace(" ", ""));
                        Letter.BackColor = Color.Red;
                        Letter.ForeColor = Color.White;
                        WordLabel.Text = "Koniec gry";
                        timer.Enabled = false;
                    }
                }
            }
        }

        private void PlaySimpleSound(string nazwa)
        {
            SoundPlayer simpleSound = new SoundPlayer($@"{directory}sounds\{nazwa}.wav");
            simpleSound.Play();
        }

        
    }
}
