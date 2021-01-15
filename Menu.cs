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
    public partial class Menu : Form
    {
        Image SkodaGreen =  
        public Menu()
        {
            InitializeComponent();
        }

        private void Green_CheckedChanged(object sender, EventArgs e)
        {
           
        }
      
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Game new_game = new Game();
            new_game.Show();
            this.Hide();
            new_game.FormClosed += new FormClosedEventHandler(new_game_FormClosed);
        }

        void new_game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Green.Checked = false;
            this.Show();

        }
    }
}
