
namespace Racewords
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Green = new System.Windows.Forms.CheckBox();
            this.Start = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.CheckBox();
            this.Red = new System.Windows.Forms.CheckBox();
            this.StartText = new System.Windows.Forms.Label();
            this.chooseSkoda = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Silver;
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Green.ForeColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(561, 155);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(72, 20);
            this.Green.TabIndex = 0;
            this.Green.Text = "Zielona";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Green;
            this.Start.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start.Location = new System.Drawing.Point(40, 120);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(342, 100);
            this.Start.TabIndex = 1;
            this.Start.Text = "START GAME";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.BackColor = System.Drawing.Color.Silver;
            this.Yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Yellow.ForeColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(561, 195);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(60, 20);
            this.Yellow.TabIndex = 2;
            this.Yellow.Text = "Żółta";
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.CheckedChanged += new System.EventHandler(this.Yellow_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Silver;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Red.ForeColor = System.Drawing.Color.DarkRed;
            this.Red.Location = new System.Drawing.Point(561, 240);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(86, 20);
            this.Red.TabIndex = 3;
            this.Red.Text = "Czerwona";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // StartText
            // 
            this.StartText.AutoSize = true;
            this.StartText.BackColor = System.Drawing.Color.Teal;
            this.StartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartText.Location = new System.Drawing.Point(14, 64);
            this.StartText.Name = "StartText";
            this.StartText.Size = new System.Drawing.Size(777, 24);
            this.StartText.TabIndex = 4;
            this.StartText.Text = "Aby rozpocząć grę, wciśnij przycisk START GAME. By wrócić do menu, zamknij okno z" +
    " grą.";
            this.StartText.Click += new System.EventHandler(this.StartText_Click);
            // 
            // chooseSkoda
            // 
            this.chooseSkoda.AutoSize = true;
            this.chooseSkoda.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.chooseSkoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chooseSkoda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chooseSkoda.Location = new System.Drawing.Point(515, 110);
            this.chooseSkoda.Name = "chooseSkoda";
            this.chooseSkoda.Size = new System.Drawing.Size(191, 24);
            this.chooseSkoda.TabIndex = 5;
            this.chooseSkoda.Text = "Wybierz kolor Skody: ";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.title.ForeColor = System.Drawing.Color.DarkRed;
            this.title.Location = new System.Drawing.Point(274, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(246, 39);
            this.title.TabIndex = 6;
            this.title.Text = "RACEWORDS";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(803, 294);
            this.Controls.Add(this.title);
            this.Controls.Add(this.chooseSkoda);
            this.Controls.Add(this.StartText);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Green);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Green;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.CheckBox Yellow;
        private System.Windows.Forms.CheckBox Red;
        private System.Windows.Forms.Label StartText;
        private System.Windows.Forms.Label chooseSkoda;
        private System.Windows.Forms.Label title;
    }
}