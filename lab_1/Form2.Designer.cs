
namespace lesson_02022023
{
    partial class Form2
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
            this.buttonHello = new System.Windows.Forms.Button();
            this.buttonGoodbye = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonHello
            // 
            this.buttonHello.Location = new System.Drawing.Point(12, 348);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(180, 90);
            this.buttonHello.TabIndex = 0;
            this.buttonHello.Text = "Привет";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.buttonHello_Click);
            // 
            // buttonGoodbye
            // 
            this.buttonGoodbye.Location = new System.Drawing.Point(239, 348);
            this.buttonGoodbye.Name = "buttonGoodbye";
            this.buttonGoodbye.Size = new System.Drawing.Size(180, 90);
            this.buttonGoodbye.TabIndex = 1;
            this.buttonGoodbye.Text = "До свидания";
            this.buttonGoodbye.UseVisualStyleBackColor = true;
            this.buttonGoodbye.Click += new System.EventHandler(this.buttonGoodbye_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(12, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(108, 55);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Text";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonGoodbye);
            this.Controls.Add(this.buttonHello);
            this.Name = "Form2";
            this.Text = "Лаб. раб. №1 гр. 107з2 Монич Александр";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Button buttonGoodbye;
        private System.Windows.Forms.Label labelText;
    }
}