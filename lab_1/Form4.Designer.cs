
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.buttonThird = new System.Windows.Forms.Button();
            this.buttonFourth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 29);
            this.textBox1.TabIndex = 0;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(12, 161);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(150, 90);
            this.buttonFirst.TabIndex = 1;
            this.buttonFirst.Text = "Начало работы";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(214, 161);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(150, 90);
            this.buttonSecond.TabIndex = 2;
            this.buttonSecond.Text = "Начало работы";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // buttonThird
            // 
            this.buttonThird.Location = new System.Drawing.Point(424, 161);
            this.buttonThird.Name = "buttonThird";
            this.buttonThird.Size = new System.Drawing.Size(150, 90);
            this.buttonThird.TabIndex = 3;
            this.buttonThird.Text = "Начало работы";
            this.buttonThird.UseVisualStyleBackColor = true;
            this.buttonThird.Click += new System.EventHandler(this.buttonThird_Click);
            // 
            // buttonFourth
            // 
            this.buttonFourth.Location = new System.Drawing.Point(638, 161);
            this.buttonFourth.Name = "buttonFourth";
            this.buttonFourth.Size = new System.Drawing.Size(150, 90);
            this.buttonFourth.TabIndex = 4;
            this.buttonFourth.Text = "Начало работы";
            this.buttonFourth.UseVisualStyleBackColor = true;
            this.buttonFourth.Click += new System.EventHandler(this.buttonFourth_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.buttonFourth);
            this.Controls.Add(this.buttonThird);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Лаб. раб. №1 гр. 107з2 Монич Александр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button buttonThird;
        private System.Windows.Forms.Button buttonFourth;
    }
}