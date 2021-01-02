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

        public static System.Drawing.Point LetterLocation(System.Drawing.Point point)
        { 
            point.X = r.Next(0, 1024);
            point.Y = r.Next(-1280, 0);
            return point;
        }
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
        public static System.Drawing.Color ColorChange(System.Drawing.Color color2)
        {
            if (color == true)
            {
                color2 = System.Drawing.Color.Black;
                color = false;
            }
            return color2;
        }
        public static string TextChange(string text2, string[] literki)
        {
            if (text == true)
            {
                text2 = literki[r.Next(0, literki.Length)];
                text = false;
            }
            return text2;

        }
        

    }
}
