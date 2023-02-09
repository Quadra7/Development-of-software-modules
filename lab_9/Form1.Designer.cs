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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxXk = new System.Windows.Forms.TextBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "Function #1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Function #2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(633, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(651, 12);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(121, 43);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Построить график";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxX0
            // 
            this.textBoxX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX0.Location = new System.Drawing.Point(12, 407);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 29);
            this.textBoxX0.TabIndex = 2;
            // 
            // textBoxXk
            // 
            this.textBoxXk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXk.Location = new System.Drawing.Point(192, 407);
            this.textBoxXk.Name = "textBoxXk";
            this.textBoxXk.Size = new System.Drawing.Size(100, 29);
            this.textBoxXk.TabIndex = 3;
            // 
            // textBoxDx
            // 
            this.textBoxDx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDx.Location = new System.Drawing.Point(361, 407);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(100, 29);
            this.textBoxDx.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(672, 407);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 29);
            this.textBoxB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "X0:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Xk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(357, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dx:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(668, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "A:";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(672, 317);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 29);
            this.textBoxA.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(669, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxDx);
            this.Controls.Add(this.textBoxXk);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №9 гр. 107з2 Монич Александр";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxXk;
        private System.Windows.Forms.TextBox textBoxDx;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label5;
    }
}

