
namespace Racewords
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Letter2 = new Letters();
            this.Letter1 = new Letters();
            this.Letter3 = new Letters();
            this.Word = new Letters();
            this.Letter4 = new Letters();
            this.Letter5 = new Letters();
            this.Title = new Letters();
            this.Letter6 = new Letters();
            this.Letter7 = new Letters();
            this.Letter8 = new Letters();
            this.Letter9 = new Letters();
            this.Points = new Letters();
            this.Letter10 = new Letters();
            this.lettertab = new Letters[] { this.Letter1, this.Letter2, this.Letter3, this.Letter4, this.Letter5, this.Letter6, this.Letter7, this.Letter8, this.Letter9, this.Letter10};
            this.Life = new Letters();
            this.LevelLabel = new Letters();
            this.Skoda = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new Movement();
            this.pictureBox1 = new Movement();
            this.pictureBox5 = new Movement();
            this.pictureBox2 = new Movement();
            this.pictureBox3 = new Movement();
            this.linestab = new Movement[] { this.pictureBox1, this.pictureBox2, this.pictureBox3, this.pictureBox4, this.pictureBox5 };
            this.Car = this.Skoda;
            this.WordLabel = this.Word;
            this.timer = this.timer1;
            ((System.ComponentModel.ISupportInitialize)(this.Skoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Letter2
            // 
            this.Letter2.AutoSize = true;
            this.Letter2.BackColor = System.Drawing.Color.Transparent;
            this.Letter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter2.Location = new System.Drawing.Point(914, 152);
            this.Letter2.Name = "Letter2";
            this.Letter2.Size = new System.Drawing.Size(40, 42);
            this.Letter2.TabIndex = 7;
            this.Letter2.Text = "L";
            this.Letter2.Click += new System.EventHandler(this.Letter2_Click);
            // 
            // Letter1
            // 
            this.Letter1.AutoSize = true;
            this.Letter1.BackColor = System.Drawing.Color.Transparent;
            this.Letter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter1.Location = new System.Drawing.Point(341, 187);
            this.Letter1.Name = "Letter1";
            this.Letter1.Size = new System.Drawing.Size(40, 42);
            this.Letter1.TabIndex = 8;
            this.Letter1.Text = "L";
            this.Letter1.Click += new System.EventHandler(this.Letter1_Click_1);
            // 
            // Letter3
            // 
            this.Letter3.AutoSize = true;
            this.Letter3.BackColor = System.Drawing.Color.Transparent;
            this.Letter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter3.Location = new System.Drawing.Point(492, 400);
            this.Letter3.Name = "Letter3";
            this.Letter3.Size = new System.Drawing.Size(40, 42);
            this.Letter3.TabIndex = 9;
            this.Letter3.Text = "L";
            this.Letter3.Click += new System.EventHandler(this.Letter3_Click);
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.BackColor = System.Drawing.Color.White;
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Word.Location = new System.Drawing.Point(520, 104);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(0, 55);
            this.Word.TabIndex = 10;
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // Letter4
            // 
            this.Letter4.AutoSize = true;
            this.Letter4.BackColor = System.Drawing.Color.Transparent;
            this.Letter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter4.Location = new System.Drawing.Point(1138, 353);
            this.Letter4.Name = "Letter4";
            this.Letter4.Size = new System.Drawing.Size(40, 42);
            this.Letter4.TabIndex = 11;
            this.Letter4.Text = "L";
            this.Letter4.Click += new System.EventHandler(this.Letter4_Click);
            // 
            // Letter5
            // 
            this.Letter5.AutoSize = true;
            this.Letter5.BackColor = System.Drawing.Color.Transparent;
            this.Letter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter5.Location = new System.Drawing.Point(179, 390);
            this.Letter5.Name = "Letter5";
            this.Letter5.Size = new System.Drawing.Size(40, 42);
            this.Letter5.TabIndex = 12;
            this.Letter5.Text = "L";
            this.Letter5.Click += new System.EventHandler(this.Letter5_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(489, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(152, 55);
            this.Title.TabIndex = 13;
            this.Title.Text = "label1";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Letter6
            // 
            this.Letter6.AutoSize = true;
            this.Letter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter6.Location = new System.Drawing.Point(179, 113);
            this.Letter6.Name = "Letter6";
            this.Letter6.Size = new System.Drawing.Size(40, 42);
            this.Letter6.TabIndex = 14;
            this.Letter6.Text = "L";
            this.Letter6.Click += new System.EventHandler(this.Letter6_Click);
            // 
            // Letter7
            // 
            this.Letter7.AutoSize = true;
            this.Letter7.BackColor = System.Drawing.Color.Transparent;
            this.Letter7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter7.Location = new System.Drawing.Point(507, 497);
            this.Letter7.Name = "Letter7";
            this.Letter7.Size = new System.Drawing.Size(40, 42);
            this.Letter7.TabIndex = 15;
            this.Letter7.Text = "L";
            // 
            // Letter8
            // 
            this.Letter8.AutoSize = true;
            this.Letter8.BackColor = System.Drawing.Color.Transparent;
            this.Letter8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter8.Location = new System.Drawing.Point(1033, 63);
            this.Letter8.Name = "Letter8";
            this.Letter8.Size = new System.Drawing.Size(40, 42);
            this.Letter8.TabIndex = 16;
            this.Letter8.Text = "L";
            this.Letter8.Click += new System.EventHandler(this.Letter8_Click);
            // 
            // Letter9
            // 
            this.Letter9.AutoSize = true;
            this.Letter9.BackColor = System.Drawing.Color.Transparent;
            this.Letter9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter9.Location = new System.Drawing.Point(872, 463);
            this.Letter9.Name = "Letter9";
            this.Letter9.Size = new System.Drawing.Size(40, 42);
            this.Letter9.TabIndex = 17;
            this.Letter9.Text = "L";
            this.Letter9.Click += new System.EventHandler(this.Letter9_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Points.Location = new System.Drawing.Point(1053, -4);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(210, 55);
            this.Points.TabIndex = 18;
            this.Points.Text = "Points: 0";
            this.Points.Click += new System.EventHandler(this.Points_Click);
            // 
            // Letter10
            // 
            this.Letter10.AutoSize = true;
            this.Letter10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter10.Location = new System.Drawing.Point(249, 686);
            this.Letter10.Name = "Letter10";
            this.Letter10.Size = new System.Drawing.Size(40, 42);
            this.Letter10.TabIndex = 19;
            this.Letter10.Text = "L";
            this.Letter10.Click += new System.EventHandler(this.Letter10_Click);
            // 
          
            // Life
            // 
            this.Life.AutoSize = true;
            this.Life.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Life.Location = new System.Drawing.Point(0, -4);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(189, 55);
            this.Life.TabIndex = 20;
            this.Life.Text = "Lives: 0";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LevelLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LevelLabel.Location = new System.Drawing.Point(389, -4);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(100, 37);
            this.LevelLabel.TabIndex = 22;
            this.LevelLabel.Text = "label1";
            this.LevelLabel.Click += new System.EventHandler(this.LevelLabel_Click);
            // 
            // Skoda
            // 
            this.Skoda.BackColor = System.Drawing.Color.Transparent;
            this.Skoda.Image = global::Racewords.Properties.Resources.Skoda;
            this.Skoda.Location = new System.Drawing.Point(656, 497);
            this.Skoda.Name = "Skoda";
            this.Skoda.Size = new System.Drawing.Size(107, 192);
            this.Skoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skoda.TabIndex = 21;
            this.Skoda.TabStop = false;
            this.Skoda.Click += new System.EventHandler(this.Skoda_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(640, 933);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 220);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(639, -220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 220);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(640, 63);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 220);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(640, 353);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 220);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(640, 642);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 220);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(LevelLabel);
            this.Controls.Add(Skoda);
            this.Controls.Add(Life);
            this.Controls.Add(Points);
            this.Controls.Add(Title);
            this.Controls.Add(Word);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(Letter2);
            this.Controls.Add(Letter8);
            this.Controls.Add(Letter4);
            this.Controls.Add(Letter7);
            this.Controls.Add(Letter3);
            this.Controls.Add(Letter1);
            this.Controls.Add(Letter6);
            this.Controls.Add(Letter5);
            this.Controls.Add(Letter9);
            this.Controls.Add(Letter10);
            this.Controls.Add(pictureBox5);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(pictureBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Skoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Movement pictureBox1;
        private Movement pictureBox2;
        private Movement pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Movement pictureBox4;
        private Movement pictureBox5;
        private Letters Letter2;
        private Letters Letter1;
        private Letters Letter3;
        private Letters Word;
        private Letters Letter4;
        private Letters Letter5;
        private Letters Title;
        private Letters Letter6;
        private Letters Letter7;
        private Letters Letter8;
        private Letters Letter9;
        private Letters Points;
        private Letters Letter10;
        private Letters Life;
        public System.Windows.Forms.PictureBox Skoda;
        private Letters LevelLabel;
        private Letters[] lettertab;
        private Movement[] linestab;



    }
}

