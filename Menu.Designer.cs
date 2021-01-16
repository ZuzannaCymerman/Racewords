
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
            this.SuspendLayout();
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Green.Location = new System.Drawing.Point(612, 58);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(72, 20);
            this.Green.TabIndex = 0;
            this.Green.Text = "Zielona";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Green;
            this.Start.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start.Location = new System.Drawing.Point(96, 144);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(295, 95);
            this.Start.TabIndex = 1;
            this.Start.Text = "START GAME";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Yellow
            // 
            this.Yellow.AutoSize = true;
            this.Yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Yellow.Location = new System.Drawing.Point(612, 99);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(60, 20);
            this.Yellow.TabIndex = 2;
            this.Yellow.Text = "Żółta";
            this.Yellow.UseVisualStyleBackColor = true;
            this.Yellow.CheckedChanged += new System.EventHandler(this.Yellow_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Red.Location = new System.Drawing.Point(612, 144);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(86, 20);
            this.Red.TabIndex = 3;
            this.Red.Text = "Czerwona";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // StartText
            // 
            this.StartText.AutoSize = true;
            this.StartText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartText.Location = new System.Drawing.Point(108, 72);
            this.StartText.Name = "StartText";
            this.StartText.Size = new System.Drawing.Size(37, 18);
            this.StartText.TabIndex = 4;
            this.StartText.Text = "start";
            this.StartText.Click += new System.EventHandler(this.StartText_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}