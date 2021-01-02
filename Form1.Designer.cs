
namespace Racewords
{
    partial class Form1
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
            this.Skoda = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Letter2 = new System.Windows.Forms.Label();
            this.Letter1 = new System.Windows.Forms.Label();
            this.Letter3 = new System.Windows.Forms.Label();
            this.Word = new System.Windows.Forms.Label();
            this.Letter4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Skoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Skoda
            // 
            this.Skoda.BackColor = System.Drawing.Color.Transparent;
            this.Skoda.Image = global::Racewords.Properties.Resources.Skoda;
            this.Skoda.Location = new System.Drawing.Point(750, 258);
            this.Skoda.Name = "Skoda";
            this.Skoda.Size = new System.Drawing.Size(182, 333);
            this.Skoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Skoda.TabIndex = 5;
            this.Skoda.TabStop = false;
            this.Skoda.Click += new System.EventHandler(this.Skoda_Click);
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
            // Letter2
            // 
            this.Letter2.AutoSize = true;
            this.Letter2.BackColor = System.Drawing.Color.Transparent;
            this.Letter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter2.Location = new System.Drawing.Point(914, 152);
            this.Letter2.Name = "Letter2";
            this.Letter2.Size = new System.Drawing.Size(36, 39);
            this.Letter2.TabIndex = 7;
            this.Letter2.Text = "L";
            this.Letter2.Click += new System.EventHandler(this.Letter2_Click);
            // 
            // Letter1
            // 
            this.Letter1.AutoSize = true;
            this.Letter1.BackColor = System.Drawing.Color.Transparent;
            this.Letter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter1.Location = new System.Drawing.Point(341, 187);
            this.Letter1.Name = "Letter1";
            this.Letter1.Size = new System.Drawing.Size(36, 39);
            this.Letter1.TabIndex = 8;
            this.Letter1.Text = "L";
            this.Letter1.Click += new System.EventHandler(this.Letter1_Click_1);
            // 
            // Letter3
            // 
            this.Letter3.AutoSize = true;
            this.Letter3.BackColor = System.Drawing.Color.Transparent;
            this.Letter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter3.Location = new System.Drawing.Point(492, 400);
            this.Letter3.Name = "Letter3";
            this.Letter3.Size = new System.Drawing.Size(36, 39);
            this.Letter3.TabIndex = 9;
            this.Letter3.Text = "L";
            this.Letter3.Click += new System.EventHandler(this.Letter3_Click);
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.BackColor = System.Drawing.Color.Transparent;
            this.Word.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Word.Location = new System.Drawing.Point(572, 5);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(152, 55);
            this.Word.TabIndex = 10;
            this.Word.Text = "label1";
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // Letter4
            // 
            this.Letter4.AutoSize = true;
            this.Letter4.BackColor = System.Drawing.Color.Transparent;
            this.Letter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Letter4.Location = new System.Drawing.Point(1138, 353);
            this.Letter4.Name = "Letter4";
            this.Letter4.Size = new System.Drawing.Size(36, 39);
            this.Letter4.TabIndex = 11;
            this.Letter4.Text = "L";
            this.Letter4.Click += new System.EventHandler(this.Letter4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.Skoda);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Letter1);
            this.Controls.Add(this.Letter3);
            this.Controls.Add(this.Letter2);
            this.Controls.Add(this.Letter4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Skoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox Skoda;
        private System.Windows.Forms.Label Letter2;
        private System.Windows.Forms.Label Letter1;
        private System.Windows.Forms.Label Letter3;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.Label Letter4;
    }
}

