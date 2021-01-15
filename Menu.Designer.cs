
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
            this.Start.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start.Location = new System.Drawing.Point(87, 36);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(159, 56);
            this.Start.TabIndex = 1;
            this.Start.Text = "START GAME";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}