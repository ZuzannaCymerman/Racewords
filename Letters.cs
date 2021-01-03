using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Racewords
{
    class Letters
    {
        public static  bool color = false;
        public static bool text = false;
        static Random r = new Random();

        //Location
        public static System.Drawing.Point LetterLocation(Point point)
        { 
            point.X = r.Next(0, 1024);
            point.Y = r.Next(-1280, 0);
            return point;
        }

        //Movement
        public static System.Drawing.Point LetterMovement(Point point, int speed)
        {
            if (point.Y >=1280)
               {
                  color = true;
                  text = true;
                  point.Y = r.Next(-1280,0);
                  point.X = r.Next(0, 1024);    
               }
            else
              {
                  point.Y += (speed);
              }
                return point;   
        }

       

        //Text
        public static string TextChange(string lettertext, string[] letters)
        {
            if (text == true)
            {
                lettertext = letters[r.Next(0, letters.Length)];
                text = false;
            }
            return lettertext;

        }

        public static void LettersMovement(Label Letter, int letterspeed, string[] letters)
        {
            Letter.Location = LetterMovement(Letter.Location, letterspeed);
            Letter.Text = TextChange(Letter.Text, letters);
        }

        public static void InitializeLetter(Label Letter, string[] letters)
        {
            Letter.Location = Letters.LetterLocation(Letter.Location);
            Letter.Text = letters[r.Next(0, letters.Length)];
            Letter.Location = Letters.LetterLocation(Letter.Location);
        }
    }
}
