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
            this.Table = new System.Windows.Forms.DataGridView();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonSecond = new System.Windows.Forms.Button();
            this.buttonThird = new System.Windows.Forms.Button();
            this.buttonFourth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeColumns = false;
            this.Table.AllowUserToResizeRows = false;
            this.Table.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Table.ColumnHeadersHeight = 20;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Table.ColumnHeadersVisible = false;
            this.Table.Location = new System.Drawing.Point(12, 12);
            this.Table.MultiSelect = false;
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidth = 20;
            this.Table.RowTemplate.Height = 90;
            this.Table.ShowCellErrors = false;
            this.Table.ShowCellToolTips = false;
            this.Table.ShowEditingIcon = false;
            this.Table.ShowRowErrors = false;
            this.Table.Size = new System.Drawing.Size(708, 640);
            this.Table.TabIndex = 0;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(729, 12);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(120, 42);
            this.buttonFirst.TabIndex = 1;
            this.buttonFirst.Text = "Задание №1";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonSecond
            // 
            this.buttonSecond.Location = new System.Drawing.Point(855, 12);
            this.buttonSecond.Name = "buttonSecond";
            this.buttonSecond.Size = new System.Drawing.Size(120, 42);
            this.buttonSecond.TabIndex = 2;
            this.buttonSecond.Text = "Задание №2";
            this.buttonSecond.UseVisualStyleBackColor = true;
            this.buttonSecond.Click += new System.EventHandler(this.buttonSecond_Click);
            // 
            // buttonThird
            // 
            this.buttonThird.Location = new System.Drawing.Point(731, 60);
            this.buttonThird.Name = "buttonThird";
            this.buttonThird.Size = new System.Drawing.Size(120, 42);
            this.buttonThird.TabIndex = 3;
            this.buttonThird.Text = "Задание №5";
            this.buttonThird.UseVisualStyleBackColor = true;
            this.buttonThird.Click += new System.EventHandler(this.buttonThird_Click);
            // 
            // buttonFourth
            // 
            this.buttonFourth.Location = new System.Drawing.Point(855, 60);
            this.buttonFourth.Name = "buttonFourth";
            this.buttonFourth.Size = new System.Drawing.Size(120, 42);
            this.buttonFourth.TabIndex = 4;
            this.buttonFourth.Text = "Задание №6";
            this.buttonFourth.UseVisualStyleBackColor = true;
            this.buttonFourth.Click += new System.EventHandler(this.buttonFourth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(727, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFourth);
            this.Controls.Add(this.buttonThird);
            this.Controls.Add(this.buttonSecond);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.Table);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №8 гр. 107з2 Монич Александр";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonSecond;
        private System.Windows.Forms.Button buttonThird;
        private System.Windows.Forms.Button buttonFourth;
        private System.Windows.Forms.Label label1;
    }
}

