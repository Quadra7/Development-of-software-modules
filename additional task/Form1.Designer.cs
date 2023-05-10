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
            this.labelCode = new System.Windows.Forms.Label();
            this.TextSource = new System.Windows.Forms.RichTextBox();
            this.TextResult = new System.Windows.Forms.RichTextBox();
            this.labelYourText = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.NumericShift = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericShift)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.Color.Black;
            this.labelCode.Font = new System.Drawing.Font("Arial Black", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelCode.ForeColor = System.Drawing.Color.White;
            this.labelCode.Location = new System.Drawing.Point(428, 9);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(257, 42);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Шифр Цезаря";
            // 
            // TextSource
            // 
            this.TextSource.BackColor = System.Drawing.Color.White;
            this.TextSource.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextSource.ForeColor = System.Drawing.Color.Black;
            this.TextSource.Location = new System.Drawing.Point(12, 90);
            this.TextSource.Name = "TextSource";
            this.TextSource.Size = new System.Drawing.Size(500, 300);
            this.TextSource.TabIndex = 1;
            this.TextSource.Text = "";
            // 
            // TextResult
            // 
            this.TextResult.BackColor = System.Drawing.Color.White;
            this.TextResult.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.TextResult.ForeColor = System.Drawing.Color.Black;
            this.TextResult.Location = new System.Drawing.Point(622, 90);
            this.TextResult.Name = "TextResult";
            this.TextResult.ReadOnly = true;
            this.TextResult.Size = new System.Drawing.Size(500, 300);
            this.TextResult.TabIndex = 2;
            this.TextResult.Text = "";
            // 
            // labelYourText
            // 
            this.labelYourText.AutoSize = true;
            this.labelYourText.BackColor = System.Drawing.Color.Black;
            this.labelYourText.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYourText.ForeColor = System.Drawing.Color.White;
            this.labelYourText.Location = new System.Drawing.Point(12, 64);
            this.labelYourText.Name = "labelYourText";
            this.labelYourText.Size = new System.Drawing.Size(106, 23);
            this.labelYourText.TabIndex = 3;
            this.labelYourText.Text = "Ваш текст:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Black;
            this.labelResult.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.White;
            this.labelResult.Location = new System.Drawing.Point(618, 64);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(107, 23);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Результат:";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.Black;
            this.buttonEncrypt.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.ForeColor = System.Drawing.Color.White;
            this.buttonEncrypt.Location = new System.Drawing.Point(12, 434);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(246, 93);
            this.buttonEncrypt.TabIndex = 5;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.Color.Black;
            this.buttonDecrypt.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecrypt.ForeColor = System.Drawing.Color.White;
            this.buttonDecrypt.Location = new System.Drawing.Point(266, 434);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(246, 93);
            this.buttonDecrypt.TabIndex = 6;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // NumericShift
            // 
            this.NumericShift.BackColor = System.Drawing.Color.Black;
            this.NumericShift.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericShift.ForeColor = System.Drawing.Color.White;
            this.NumericShift.Location = new System.Drawing.Point(696, 459);
            this.NumericShift.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumericShift.Name = "NumericShift";
            this.NumericShift.Size = new System.Drawing.Size(83, 37);
            this.NumericShift.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Arial Black", 19.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(558, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сдвиг:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumericShift);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelYourText);
            this.Controls.Add(this.TextResult);
            this.Controls.Add(this.TextSource);
            this.Controls.Add(this.labelCode);
            this.Name = "Form1";
            this.Text = "Дополнительное задание гр. 107з2 Монич Александр";
            ((System.ComponentModel.ISupportInitialize)(this.NumericShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.RichTextBox TextSource;
        private System.Windows.Forms.RichTextBox TextResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label labelYourText;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.NumericUpDown NumericShift;
        private System.Windows.Forms.Label label5;
    }
}

