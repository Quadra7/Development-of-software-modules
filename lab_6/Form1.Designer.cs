namespace lesson_02022023
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.buttonThird = new System.Windows.Forms.Button();
            this.buttonFourth = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Items.AddRange(new object[] {
            "10111011101100001010",
            "489324327498032",
            "Some, text here. Hello!",
            "Hello! Cat, dog, hippo and lion go home: text \"Hello\"?\'",
            "10101010"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 225);
            this.listBox1.TabIndex = 0;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(12, 256);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(97, 35);
            this.buttonFirst.TabIndex = 1;
            this.buttonFirst.Text = "Задание №1";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(356, 256);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(97, 35);
            this.buttonSecond.TabIndex = 2;
            this.buttonSecond.Text = "Задание №2";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // buttonThird
            // 
            this.buttonThird.Location = new System.Drawing.Point(12, 325);
            this.buttonThird.Name = "buttonThird";
            this.buttonThird.Size = new System.Drawing.Size(97, 35);
            this.buttonThird.TabIndex = 3;
            this.buttonThird.Text = "Задание №3";
            this.buttonThird.UseVisualStyleBackColor = true;
            this.buttonThird.Click += new System.EventHandler(this.buttonThird_Click);
            // 
            // buttonFourth
            // 
            this.buttonFourth.Location = new System.Drawing.Point(356, 325);
            this.buttonFourth.Name = "buttonFourth";
            this.buttonFourth.Size = new System.Drawing.Size(97, 35);
            this.buttonFourth.TabIndex = 4;
            this.buttonFourth.Text = "Задание №4";
            this.buttonFourth.UseVisualStyleBackColor = true;
            this.buttonFourth.Click += new System.EventHandler(this.buttonFourth_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 386);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 423);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonFourth);
            this.Controls.Add(this.buttonThird);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №6 гр. 107з2 Монич Александр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button buttonThird;
        private System.Windows.Forms.Button buttonFourth;
        private System.Windows.Forms.Label labelResult;
    }
}

