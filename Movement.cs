using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Racewords
{
    public class Movement
    {
       
        public static int MoveSingleLine(int top, int speed)
        {
            if (top >= 1240)
            {
                top = -220;
            }
            else
            {
                top += speed;
            }
            return top;
        }

        public static int MoveLetter(int top, int speed)
        {
            return 0; 
        }
    }
}