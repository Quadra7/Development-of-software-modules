
namespace lesson_02022023
{
    partial class Form4
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
            this.panelFirst = new System.Windows.Forms.Panel();
            this.panelSecond = new System.Windows.Forms.Panel();
            this.panelThird = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFirst
            // 
            this.panelFirst.BackColor = System.Drawing.Color.Blue;
            this.panelFirst.Location = new System.Drawing.Point(12, 30);
            this.panelFirst.Name = "panelFirst";
            this.panelFirst.Size = new System.Drawing.Size(305, 213);
            this.panelFirst.TabIndex = 0;
            this.panelFirst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelFirst_MouseClick);
            // 
            // panelSecond
            // 
            this.panelSecond.BackColor = System.Drawing.Color.Red;
            this.panelSecond.Location = new System.Drawing.Point(452, 30);
            this.panelSecond.Name = "panelSecond";
            this.panelSecond.Size = new System.Drawing.Size(274, 175);
            this.panelSecond.TabIndex = 1;
            this.panelSecond.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelSecond_MouseClick);
            // 
            // panelThird
            // 
            this.panelThird.BackColor = System.Drawing.Color.Green;
            this.panelThird.Location = new System.Drawing.Point(190, 292);
            this.panelThird.Name = "panelThird";
            this.panelThird.Size = new System.Drawing.Size(477, 150);
            this.panelThird.TabIndex = 1;
            this.panelThird.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelThird_MouseClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 499);
            this.Controls.Add(this.panelThird);
            this.Controls.Add(this.panelSecond);
            this.Controls.Add(this.panelFirst);
            this.Name = "Form4";
            this.Text = "Лаб. раб. №5 гр. 107з2 Монич Александр";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFirst;
        private System.Windows.Forms.Panel panelSecond;
        private System.Windows.Forms.Panel panelThird;
    }
}