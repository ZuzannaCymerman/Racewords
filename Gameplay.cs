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
    /// Główna klasa logiki gry. Tutaj zawarta jest cała interakcja samochodu z literką oraz zdefiniowane są poziomy.
    public class Gameplay : Form
    {
       /// <summary>
       /// Słownik słów.
       /// </summary>
        public Dictionary<string, string> word = new Dictionary<string, string>(){
            {"C H A T", "K O T"},
            {"N U I T", "N O C"},
            {"L A I T", "M L E K O"},
            {"C H I E N", "P I E S" },
            {"C H I C", "W D Z I Ę K" }
        };

        public static Random r = new Random();
        /// <summary>
        /// Zmienna, do której będzie potem przypisywane lettersfrench oraz letterspolish.
        /// </summary>
        public string[] letters;
        /// <summary>
        /// Tablica literek, z której korzysta później zmienna letters. Literki zapisane w tej tablicy spadają, gdy należy zebrać francuskie słowo. 
        /// </summary>
        public string[] lettersfrench= { "L", "A", "I", "T", "C", "H", "I", "E", "N", "U" };
        /// <summary>
        /// Analogicznie do lettersfrench. Te literki spadają, gdy należy zebrać polskie słowo.
        /// </summary>
        public string[] letterspolish = { "L", "I", "T", "I", "E", "N", "Ę", "Z", "K", "O", "P", "S", "W", "M", "D", "C" };
        /// <summary>
        /// Szybkość przesuwania ulicy.
        /// </summary>
        public int speed = 5;
        /// <summary>
        /// Szybkość spadania literek. Można ją wybrać z Menu.
        /// </summary>
        public int letterspeed;
        /// <summary>
        /// Początkowa wartość prędkości (powrót do niej przy nowym poziomie)
        /// </summary>
        public int initletterspeed;
        /// <summary>
        /// Zmienna odpowiadająca literce, na którą najedzie samochd.
        /// </summary>
        public string bump = "";
        /// <summary>
        /// Zmienna punktów. Każde pełne słowo => +1 punkt.
        /// </summary>
        public int points = 0;
        /// <summary>
        /// Miejsce literki w słowie. Po tej zmiennej iterowana jest tablica utworzona z danego klucza, lub wartości słowa ze słownika.
        /// </summary>
        public int i = 0;
        /// <summary>
        /// Zmienna żyć.
        /// </summary>
        public int lives = 5;
        /// <summary>
        /// Zmienna poziomu.
        /// </summary>
        public int level = 0;
        /// <summary>
        /// Zmienna słowa, które jest akurat zbierane.
        /// </summary>
        public string collect = "";
        /// <summary>
        ///Szybkość samochodu.
        /// </summary>
        public int skodaspeed = 35;
        /// <summary>
        /// Obiekt samochodu.
        /// </summary>
        public PictureBox Car;
        /// <summary>
        /// Obiekt label'a, który wyświetla zebrane literki.
        /// </summary>
        public bool WinGame = false;
        public Letters WordLabel;
        /// <summary>
        /// Obiekt timera.
        /// </summary>
        public Timer timer;
        /// <summary>
        /// Zmienna przypisywana do label'a Title znajdującego się w Game.cs. 
        /// </summary>
        public string title = "";
        /// <summary>
        /// Zmienna przypisywana do label'a Level znajdującego się w Game.cs.
        /// </summary>
        public string levellabeltext = "";
        /// <summary>
        /// Zmienna dająca aktualny folder plików. 
        /// </summary>
        private string directory = System.IO.Path.GetDirectoryName(Application.StartupPath).Replace("bin","");
       /// <summary>
       /// Zmienna służąca do losowania słowa ze słownika. "r" to obiekt klasy Random, który jest używany do znalezienia przypadkowej liczby z przedziału (0,4), czyli ilości słów w słowniku. 
       /// </summary>
        public static int random = r.Next(0, 4);
        /// <summary>
        /// Zmienna ustalająca, jakie aktualnie słowo ma być zbierane. Po zebraniu słowa jej wartość jest zwiększana o 1, co podowuje, że zbieranie jest kolejne słowo. 
        /// </summary>
        public static int k = random;
        /// <summary>
        /// Zapamiętanie początkowego słowa. Zmienna jest używana, by przy następnym poziomie zacząć od tego samego słowa.
        /// </summary>
        public int l = random;
        /// <summary>
        /// Ilość punktów, które należy zebrać, by przejść do następnego poziomu. 
        /// </summary>
        public int pointsmax = 3;
        /// <summary>
        /// Funkcja przechowująca logikę dla każdego poziomu. W środku znajdują się zmienne, do których przypisywana jest wartość klucza i wartości słowa w słowniku oraz jest opisane, co dzieje się w zależności od poziomu gry. Funkcja wywoływana jest dla każdej z literek, stąd parametr "Letter". W pierwszym poziomie gry zbierane jest francuskie słowo, w drugim polskie, a w trzecim zbierane jest francuskie słowo ze słuchu.
        /// </summary>
        /// <param name="Letter">litera</param>
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
                letterspeed = initletterspeed;
            }
            else if (level == 2)
            {
                letters = lettersfrench;
                levellabeltext = "Trzeci poziom. Zbierz francuskie słowo ze słuchu.";
                title = "";
                collect = key;
                letterspeed = initletterspeed;
            }

            CarInteraction(Letter);
        }
        /// <summary>
        /// Funkcja odpowiadająca za logikę sytuacji, gdy samochód uderza w literkę. Gdy sytuacja się wydarzy, sprawdzane jest, czy literka odpowiada tej, która miała być zebrana (odpowiednie miejsce w tablicy "collect.Split(" ")", czyli w rozdzieleniu stringa po spacji i stworzeniu z niego tablicy literek. Iteracja odbywa się po zmiennej "i"). Gdy zebrane jest całe słowo, zwiększa się ilość punktów, a gdy ilość punktów jest równa "pointmax", gracz przechodzi do następnego poziomu. Gdy samochód uderzy w złą literkę, zmienne "points" oraz "lives" są dekrementowane. Gdy zmienna "lives" osiągnie 0, gra się kończy.
        /// </summary>
        /// <param name="Letter">litera</param>
        private void CarInteraction(Letters Letter)
        {
            if (Car.Bounds.IntersectsWith(Letter.Bounds))
            {
                bump = Letter.Text;
               
                if (bump == collect.Split(' ')[i])
                {
                   PlaySimpleSound("point");
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
                            if (level == 2)
                            {
                                timer.Enabled = false;
                                WinGame = true;
                            }
                            else {
                                k = l;
                                level++;
                                points = 0;
                                PlaySimpleSound(word.ElementAt(k).Key.ToLower().Replace(" ", ""));
                            }
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
                        PlaySimpleSound(word.ElementAt(k).Key.ToLower().Replace(" ", ""));
                        Letter.BackColor = Color.Red;
                        Letter.ForeColor = Color.White;
                        WordLabel.Text = "Koniec gry";
                        timer.Enabled = false;
                    }
                }
            }
        }
        /// <summary>
        /// Funkcja służąca do odtworzenia dźwięku. Za część ścieżki do pliku odpowiada zmienna "directory". Odtwarzany jest plik o nazwie "nazwa".
        /// </summary>
        /// <param name="nazwa">nazwa pliku</param>
        private void PlaySimpleSound(string nazwa)
        {
      
            SoundPlayer simpleSound = new SoundPlayer($@"{directory}sounds\{nazwa}.wav");
            simpleSound.Play();
        }

        
    }
}
