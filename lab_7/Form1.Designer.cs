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
            this.listBoxFirstMassive = new System.Windows.Forms.ListBox();
            this.listBoxSecondMassive = new System.Windows.Forms.ListBox();
            this.buttonFillFirst = new System.Windows.Forms.Button();
            this.buttonChangeFirst = new System.Windows.Forms.Button();
            this.labelFirstMassive = new System.Windows.Forms.Label();
            this.labelSecondMassive = new System.Windows.Forms.Label();
            this.buttonFillSecond = new System.Windows.Forms.Button();
            this.buttonFillThird = new System.Windows.Forms.Button();
            this.buttonFillFourth = new System.Windows.Forms.Button();
            this.buttonChangeSecond = new System.Windows.Forms.Button();
            this.buttonChangeThird = new System.Windows.Forms.Button();
            this.buttonChangeFourth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFirstMassive
            // 
            this.listBoxFirstMassive.FormattingEnabled = true;
            this.listBoxFirstMassive.Location = new System.Drawing.Point(12, 46);
            this.listBoxFirstMassive.Name = "listBoxFirstMassive";
            this.listBoxFirstMassive.Size = new System.Drawing.Size(230, 316);
            this.listBoxFirstMassive.TabIndex = 0;
            // 
            // listBoxSecondMassive
            // 
            this.listBoxSecondMassive.FormattingEnabled = true;
            this.listBoxSecondMassive.Location = new System.Drawing.Point(290, 46);
            this.listBoxSecondMassive.Name = "listBoxSecondMassive";
            this.listBoxSecondMassive.Size = new System.Drawing.Size(230, 316);
            this.listBoxSecondMassive.TabIndex = 1;
            // 
            // buttonFillFirst
            // 
            this.buttonFillFirst.Location = new System.Drawing.Point(12, 381);
            this.buttonFillFirst.Name = "buttonFillFirst";
            this.buttonFillFirst.Size = new System.Drawing.Size(230, 28);
            this.buttonFillFirst.TabIndex = 2;
            this.buttonFillFirst.Text = "Заполнить (№1)";
            this.buttonFillFirst.UseVisualStyleBackColor = true;
            this.buttonFillFirst.Click += new System.EventHandler(this.buttonFillFirst_Click);
            // 
            // buttonChangeFirst
            // 
            this.buttonChangeFirst.Location = new System.Drawing.Point(290, 381);
            this.buttonChangeFirst.Name = "buttonChangeFirst";
            this.buttonChangeFirst.Size = new System.Drawing.Size(230, 28);
            this.buttonChangeFirst.TabIndex = 3;
            this.buttonChangeFirst.Text = "Изменить (№1)";
            this.buttonChangeFirst.UseVisualStyleBackColor = true;
            this.buttonChangeFirst.Click += new System.EventHandler(this.buttonChangeFirst_Click);
            // 
            // labelFirstMassive
            // 
            this.labelFirstMassive.AutoSize = true;
            this.labelFirstMassive.Location = new System.Drawing.Point(12, 20);
            this.labelFirstMassive.Name = "labelFirstMassive";
            this.labelFirstMassive.Size = new System.Drawing.Size(102, 13);
            this.labelFirstMassive.TabIndex = 4;
            this.labelFirstMassive.Text = "Исходный массив:";
            // 
            // labelSecondMassive
            // 
            this.labelSecondMassive.AutoSize = true;
            this.labelSecondMassive.Location = new System.Drawing.Point(287, 20);
            this.labelSecondMassive.Name = "labelSecondMassive";
            this.labelSecondMassive.Size = new System.Drawing.Size(113, 13);
            this.labelSecondMassive.TabIndex = 5;
            this.labelSecondMassive.Text = "Полученный массив:";
            // 
            // buttonFillSecond
            // 
            this.buttonFillSecond.Location = new System.Drawing.Point(12, 415);
            this.buttonFillSecond.Name = "buttonFillSecond";
            this.buttonFillSecond.Size = new System.Drawing.Size(230, 28);
            this.buttonFillSecond.TabIndex = 6;
            this.buttonFillSecond.Text = "Заполнить (№2)";
            this.buttonFillSecond.UseVisualStyleBackColor = true;
            this.buttonFillSecond.Click += new System.EventHandler(this.buttonFillSecond_Click);
            // 
            // buttonFillThird
            // 
            this.buttonFillThird.Location = new System.Drawing.Point(12, 449);
            this.buttonFillThird.Name = "buttonFillThird";
            this.buttonFillThird.Size = new System.Drawing.Size(230, 28);
            this.buttonFillThird.TabIndex = 7;
            this.buttonFillThird.Text = "Заполнить (№3)";
            this.buttonFillThird.UseVisualStyleBackColor = true;
            this.buttonFillThird.Click += new System.EventHandler(this.buttonFillThird_Click);
            // 
            // buttonFillFourth
            // 
            this.buttonFillFourth.Location = new System.Drawing.Point(12, 483);
            this.buttonFillFourth.Name = "buttonFillFourth";
            this.buttonFillFourth.Size = new System.Drawing.Size(230, 28);
            this.buttonFillFourth.TabIndex = 8;
            this.buttonFillFourth.Text = "Заполнить (№4)";
            this.buttonFillFourth.UseVisualStyleBackColor = true;
            this.buttonFillFourth.Click += new System.EventHandler(this.buttonFillFourth_Click);
            // 
            // buttonChangeSecond
            // 
            this.buttonChangeSecond.Location = new System.Drawing.Point(290, 415);
            this.buttonChangeSecond.Name = "buttonChangeSecond";
            this.buttonChangeSecond.Size = new System.Drawing.Size(230, 28);
            this.buttonChangeSecond.TabIndex = 9;
            this.buttonChangeSecond.Text = "Изменить (№2)";
            this.buttonChangeSecond.UseVisualStyleBackColor = true;
            this.buttonChangeSecond.Click += new System.EventHandler(this.buttonChangeSecond_Click);
            // 
            // buttonChangeThird
            // 
            this.buttonChangeThird.Location = new System.Drawing.Point(290, 449);
            this.buttonChangeThird.Name = "buttonChangeThird";
            this.buttonChangeThird.Size = new System.Drawing.Size(230, 28);
            this.buttonChangeThird.TabIndex = 10;
            this.buttonChangeThird.Text = "Изменить (№3)";
            this.buttonChangeThird.UseVisualStyleBackColor = true;
            this.buttonChangeThird.Click += new System.EventHandler(this.buttonChangeThird_Click);
            // 
            // buttonChangeFourth
            // 
            this.buttonChangeFourth.Location = new System.Drawing.Point(290, 484);
            this.buttonChangeFourth.Name = "buttonChangeFourth";
            this.buttonChangeFourth.Size = new System.Drawing.Size(230, 28);
            this.buttonChangeFourth.TabIndex = 11;
            this.buttonChangeFourth.Text = "Изменить (№4)";
            this.buttonChangeFourth.UseVisualStyleBackColor = true;
            this.buttonChangeFourth.Click += new System.EventHandler(this.buttonChangeFourth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 524);
            this.Controls.Add(this.buttonChangeFourth);
            this.Controls.Add(this.buttonChangeThird);
            this.Controls.Add(this.buttonChangeSecond);
            this.Controls.Add(this.buttonFillFourth);
            this.Controls.Add(this.buttonFillThird);
            this.Controls.Add(this.buttonFillSecond);
            this.Controls.Add(this.labelSecondMassive);
            this.Controls.Add(this.labelFirstMassive);
            this.Controls.Add(this.buttonChangeFirst);
            this.Controls.Add(this.buttonFillFirst);
            this.Controls.Add(this.listBoxSecondMassive);
            this.Controls.Add(this.listBoxFirstMassive);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №7 гр. 107з2 Монич Александр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFirstMassive;
        private System.Windows.Forms.ListBox listBoxSecondMassive;
        private System.Windows.Forms.Button buttonFillFirst;
        private System.Windows.Forms.Button buttonChangeFirst;
        private System.Windows.Forms.Label labelFirstMassive;
        private System.Windows.Forms.Label labelSecondMassive;
        private System.Windows.Forms.Button buttonFillSecond;
        private System.Windows.Forms.Button buttonFillThird;
        private System.Windows.Forms.Button buttonFillFourth;
        private System.Windows.Forms.Button buttonChangeSecond;
        private System.Windows.Forms.Button buttonChangeThird;
        private System.Windows.Forms.Button buttonChangeFourth;
    }
}

