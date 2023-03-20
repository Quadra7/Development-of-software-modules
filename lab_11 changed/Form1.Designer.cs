namespace lesson_02022023
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Moon = new System.Windows.Forms.PictureBox();
            this.Earth = new System.Windows.Forms.PictureBox();
            this.Sun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sun)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Moon
            // 
            this.Moon.BackColor = System.Drawing.Color.Transparent;
            this.Moon.Image = global::lesson_02022023.Properties.Resources.moon;
            this.Moon.Location = new System.Drawing.Point(324, 158);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(56, 54);
            this.Moon.TabIndex = 3;
            this.Moon.TabStop = false;
            // 
            // Earth
            // 
            this.Earth.BackColor = System.Drawing.Color.Transparent;
            this.Earth.Image = global::lesson_02022023.Properties.Resources.earth;
            this.Earth.Location = new System.Drawing.Point(218, 110);
            this.Earth.Name = "Earth";
            this.Earth.Size = new System.Drawing.Size(100, 102);
            this.Earth.TabIndex = 1;
            this.Earth.TabStop = false;
            // 
            // Sun
            // 
            this.Sun.BackColor = System.Drawing.Color.Transparent;
            this.Sun.Image = global::lesson_02022023.Properties.Resources.sun;
            this.Sun.Location = new System.Drawing.Point(12, 12);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(200, 200);
            this.Sun.TabIndex = 0;
            this.Sun.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Earth);
            this.Controls.Add(this.Sun);
            this.Name = "Form2";
            this.Text = "Лаб. раб. №11 гр. 107з2 Монич Александр";
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Sun;
        private System.Windows.Forms.PictureBox Earth;
        private System.Windows.Forms.PictureBox Moon;
    }
}