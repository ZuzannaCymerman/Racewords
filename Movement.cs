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
    /// <summary>
    /// Klasa opisująca zachowanie ruchu ulicy. Na ulicy znajduje się 5 linii tej klasy, która dziedziczy po klasie PictureBox.
    /// </summary>
    public class Movement : PictureBox
    {
     /// <summary>
     /// Konstruktor klasy Movement.
     /// </summary>
       public Movement(){ }
    /// <summary>
    /// Ruch linii.
    /// </summary>
    /// <param name="top">odległość od górnej krawędzi pola gry</param>
    /// <param name="speed">prędkość linii</param>
    /// <returns>odległość od górnej krawędzi pola gry</returns>
        public int MoveSingleLine(int top, int speed)
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
       /// <summary>
       /// Wywołanie funkcji MoveSingleLine i przypisanie jej do parametru Top danej linii.
       /// </summary>
       /// <param name="speed"></param>
        public void MoveLine(int speed)
        {
           this.Top = MoveSingleLine(this.Top, speed);
        }

       
    }
}