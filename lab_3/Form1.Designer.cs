
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.buttonThird = new System.Windows.Forms.Button();
            this.buttonFourth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(51, 9);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(148, 19);
            this.labelX.TabIndex = 0;
            this.labelX.Text = "Введите значение X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(51, 48);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(147, 19);
            this.labelY.TabIndex = 1;
            this.labelY.Text = "Введите значение Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(205, 6);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 26);
            this.textBoxX.TabIndex = 3;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(204, 45);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 26);
            this.textBoxY.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(51, 92);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(245, 19);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат выполнения программы:";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(55, 114);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(248, 163);
            this.richTextBoxResult.TabIndex = 7;
            this.richTextBoxResult.Text = "";
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(51, 283);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(252, 23);
            this.buttonFirst.TabIndex = 8;
            this.buttonFirst.Text = "Уравнение №1";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(51, 312);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(252, 23);
            this.buttonSecond.TabIndex = 9;
            this.buttonSecond.Text = "Уравнение №2";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // buttonThird
            // 
            this.buttonThird.Location = new System.Drawing.Point(51, 341);
            this.buttonThird.Name = "buttonThird";
            this.buttonThird.Size = new System.Drawing.Size(252, 23);
            this.buttonThird.TabIndex = 10;
            this.buttonThird.Text = "Уравнение №3";
            this.buttonThird.UseVisualStyleBackColor = true;
            this.buttonThird.Click += new System.EventHandler(this.buttonThird_Click);
            // 
            // buttonFourth
            // 
            this.buttonFourth.Location = new System.Drawing.Point(51, 370);
            this.buttonFourth.Name = "buttonFourth";
            this.buttonFourth.Size = new System.Drawing.Size(252, 23);
            this.buttonFourth.TabIndex = 11;
            this.buttonFourth.Text = "Уравнение №4";
            this.buttonFourth.UseVisualStyleBackColor = true;
            this.buttonFourth.Click += new System.EventHandler(this.buttonFourth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 406);
            this.Controls.Add(this.buttonFourth);
            this.Controls.Add(this.buttonThird);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №3 гр. 107з2 Монич Александр";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button buttonThird;
        private System.Windows.Forms.Button buttonFourth;
    }
}

