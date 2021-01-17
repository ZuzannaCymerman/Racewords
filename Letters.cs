using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Racewords
{
    /// <summary>
    /// Klasa dziedzicząca po klasie Label. Są niej wszystkie utworzone labele. 
    /// </summary>
    public class Letters : Label
    {
        /// <summary>
        /// Konstruktor klasy Letters.
        /// </summary>
        public Letters(){ }
        /// <summary>
        /// Zmienna służąca do zmiany tekstu literki na losową.
        /// </summary>
        public static bool text = false;
        /// <summary>
        /// Losowa liczba.
        /// </summary>
        static Random r = new Random();
       
        /// <summary>
        /// Inicjalizacja położenia literki losowo u góry pola gry.
        /// </summary>
        /// <param name="point"></param>
        /// <returns>położenie literki</returns>
        public static Point LetterLocation(Point point)
        { 
            point.X = r.Next(0, 1024);
            point.Y = r.Next(-1280, 0);
            return point;
        }

        /// <summary>
        /// Funkcja opisująca ruch literki zależny od wybranej szybkości. Gdy literka dotrze do końca pola gry, następuje wywołanie funkcji LetterLocation.
        /// </summary>
        /// <param name="point">położenie literki</param>
        /// <param name="letterspeed">szybkość spadania literki</param>
        /// <returns>położenie literki</returns>
        public Point LetterMovement(Point point, int letterspeed)
        {
            if (point.Y >=1280)
               {
                  text = true;
                  point = LetterLocation(point);  
               }
            else
              {
                  point.Y += (letterspeed);
              }
                return point;   
        }
 
        /// <summary>
        /// Zmiana tekstu literki na losowy.
        /// </summary>
        /// <param name="lettertext">tekst literki</param>
        /// <param name="letters">tablica literek</param>
        /// <returns>tekst literki</returns>
        public string TextChange(string lettertext, string[] letters)
        {
            if (text == true)
            {
                lettertext = letters[r.Next(0, letters.Length)];
                text = false;
            }
            return lettertext;

        }

        /// <summary>
        /// Funckja łącząca LetterMovement i TextChange.
        /// </summary>
        /// <param name="letterspeed">szybkość spadania literek</param>
        /// <param name="letters">tablica literek</param>
        public void LettersMovement(int letterspeed, string[] letters)
        {
            this.Location = LetterMovement(this.Location, letterspeed);
            this.Text = TextChange(this.Text, letters);
        }

        /// <summary>
        /// Funkcja inicjalizująca położenie literek na podstawie funkcji LetterLocation.
        /// </summary>
        /// <param name="letters">tablica literek</param>
        public  void InitializeLetter(string[] letters)
        {
            this.Location = LetterLocation(this.Location);
            this.Text = letters[r.Next(0, letters.Length)];
            this.Location = LetterLocation(this.Location);
        }
    }
}
