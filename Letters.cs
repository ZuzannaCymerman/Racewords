using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Racewords
{
    public class Letters : Label
    {
        public Letters(){ }

        public static  bool color = false;
        public static bool text = false;
        static Random r = new Random();
       
        //Initial Location
        public static Point LetterLocation(Point point)
        { 
            point.X = r.Next(0, 1024);
            point.Y = r.Next(-1280, 0);
            return point;
        }

        //Movement
        public Point LetterMovement(Point point, int speed)
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
        public string TextChange(string lettertext, string[] letters)
        {
            if (text == true)
            {
                lettertext = letters[r.Next(0, letters.Length)];
                text = false;
            }
            return lettertext;

        }

        //Letter Movement
        public void LettersMovement(int letterspeed, string[] letters)
        {
            this.Location = LetterMovement(this.Location, letterspeed);
            this.Text = TextChange(this.Text, letters);
        }

        //Letter Initialization
        public  void InitializeLetter(string[] letters)
        {
            this.Location = Letters.LetterLocation(this.Location);
            this.Text = letters[r.Next(0, letters.Length)];
            this.Location = Letters.LetterLocation(this.Location);
        }
    }
}
