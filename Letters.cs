using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racewords
{
    class Letters
    {
        public static  bool color = false;
        public static bool text = false;
        static Random r = new Random();

        //Location
        public static System.Drawing.Point LetterLocation(System.Drawing.Point point)
        { 
            point.X = r.Next(0, 1024);
            point.Y = r.Next(-1280, 0);
            return point;
        }

        //Movement
        public static System.Drawing.Point LetterMovement(System.Drawing.Point point, int speed)
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

        //Color
        public static System.Drawing.Color ColorChange(System.Drawing.Color textcolor)
        {
            if (color == true)
            {
                textcolor = System.Drawing.Color.Black;
                color = false;
            }
            return textcolor;
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
        

    }
}
