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

        string[] literki = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "I", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        int speed = 5;
        int letterspeed = 6;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeAll();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            InteractionAll();
            LetterMovementAll();
            Lines();
        }

        private void Skoda_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
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

        private void InteractionAll()
        {
            Interaction(Letter1);
            Interaction(Letter2);
            Interaction(Letter3);
            Interaction(Letter4);
        }
        private void Interaction(System.Windows.Forms.Label Letter)
        {

            if (Skoda.Bounds.IntersectsWith(Letter.Bounds))
            {
                Letter.ForeColor = System.Drawing.Color.Green;
            }

        }
        private void Lines()
        {
            pictureBox1.Top = Movement.MoveSingleLine(pictureBox1.Top, speed);
            pictureBox2.Top = Movement.MoveSingleLine(pictureBox2.Top, speed);
            pictureBox3.Top = Movement.MoveSingleLine(pictureBox3.Top, speed);
            pictureBox4.Top = Movement.MoveSingleLine(pictureBox4.Top, speed);
            pictureBox5.Top = Movement.MoveSingleLine(pictureBox5.Top, speed);
        }
        private void LetterMovementAll()
        {
            LetterMovement(Letter1);
            LetterMovement(Letter2);
            LetterMovement(Letter3);
            LetterMovement(Letter4);
        }
        private void LetterMovement(System.Windows.Forms.Label Letter)
        {
            Letter.Location = Letters.LetterMovement(Letter.Location, letterspeed);
            Letter.ForeColor = Letters.ColorChange(Letter.ForeColor);
            Letter.Text = Letters.TextChange(Letter.Text, literki);
        }
        private void InitializeAll()
        {
            InitializeLetter(Letter1);
            InitializeLetter(Letter2);
            InitializeLetter(Letter3);
            InitializeLetter(Letter4);
        }
        private void InitializeLetter(System.Windows.Forms.Label Letter)
        {
            Letter.Location = Letters.LetterLocation(Letter.Location);
            Letter.Text = literki[r.Next(0, literki.Length)];
            Letter.Location = Letters.LetterLocation(Letter.Location);
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
        private void Letter1_Click_1(object sender, EventArgs e)
        {

        }

        private void Letter2_Click(object sender, EventArgs e)
        {

        }

        private void Letter3_Click(object sender, EventArgs e)
        {

        }

        private void Letter4_Click(object sender, EventArgs e)
        {

        }
        private void Word_Click(object sender, EventArgs e)
        {

        }

    }
}
