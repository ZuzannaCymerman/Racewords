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
    public partial class Form1 : Form
    {
        int speed = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Top = Movement.MoveSingleLine(pictureBox1.Top, speed);
            pictureBox2.Top = Movement.MoveSingleLine(pictureBox2.Top, speed);
            pictureBox3.Top = Movement.MoveSingleLine(pictureBox3.Top, speed);
            pictureBox4.Top = Movement.MoveSingleLine(pictureBox4.Top, speed);
            pictureBox5.Top = Movement.MoveSingleLine(pictureBox5.Top, speed);
        }

        private void Skoda_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                Skoda.Left += -10;
            }
            if (e.KeyCode == Keys.Right)
            {
                Skoda.Left += 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                Skoda.Top += -10;
            }
            if (e.KeyCode == Keys.Down)
            {
               
                Skoda.Top += 10;
            }
        }
    }
}
