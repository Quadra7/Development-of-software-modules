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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonLime = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonAqua = new System.Windows.Forms.Button();
            this.buttonBlueViolet = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonGray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThousand = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(12, 558);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 38);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(734, 558);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 38);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(68, 514);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 29);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::lesson_02022023.Properties.Resources.white;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(488, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Location = new System.Drawing.Point(518, 513);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(24, 24);
            this.Orange.TabIndex = 6;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(548, 513);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(24, 24);
            this.buttonYellow.TabIndex = 7;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonLime
            // 
            this.buttonLime.BackColor = System.Drawing.Color.Lime;
            this.buttonLime.Location = new System.Drawing.Point(578, 513);
            this.buttonLime.Name = "buttonLime";
            this.buttonLime.Size = new System.Drawing.Size(24, 24);
            this.buttonLime.TabIndex = 8;
            this.buttonLime.UseVisualStyleBackColor = false;
            this.buttonLime.Click += new System.EventHandler(this.buttonLime_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(608, 514);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(24, 24);
            this.buttonBlue.TabIndex = 9;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Fuchsia;
            this.button6.Location = new System.Drawing.Point(638, 513);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 24);
            this.button6.TabIndex = 10;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonFuchsia_Click);
            // 
            // buttonAqua
            // 
            this.buttonAqua.BackColor = System.Drawing.Color.Aqua;
            this.buttonAqua.Location = new System.Drawing.Point(668, 514);
            this.buttonAqua.Name = "buttonAqua";
            this.buttonAqua.Size = new System.Drawing.Size(24, 24);
            this.buttonAqua.TabIndex = 11;
            this.buttonAqua.UseVisualStyleBackColor = false;
            this.buttonAqua.Click += new System.EventHandler(this.buttonAqua_Click);
            // 
            // buttonBlueViolet
            // 
            this.buttonBlueViolet.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonBlueViolet.Location = new System.Drawing.Point(698, 513);
            this.buttonBlueViolet.Name = "buttonBlueViolet";
            this.buttonBlueViolet.Size = new System.Drawing.Size(24, 24);
            this.buttonBlueViolet.TabIndex = 12;
            this.buttonBlueViolet.UseVisualStyleBackColor = false;
            this.buttonBlueViolet.Click += new System.EventHandler(this.buttonBlueViolet_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(728, 513);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(24, 24);
            this.buttonBlack.TabIndex = 13;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Green;
            this.buttonGreen.Location = new System.Drawing.Point(758, 514);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(24, 24);
            this.buttonGreen.TabIndex = 14;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonGray
            // 
            this.buttonGray.BackColor = System.Drawing.Color.Gray;
            this.buttonGray.Location = new System.Drawing.Point(788, 514);
            this.buttonGray.Name = "buttonGray";
            this.buttonGray.Size = new System.Drawing.Size(24, 24);
            this.buttonGray.TabIndex = 15;
            this.buttonGray.UseVisualStyleBackColor = false;
            this.buttonGray.Click += new System.EventHandler(this.buttonGray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "size:";
            // 
            // buttonThousand
            // 
            this.buttonThousand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThousand.Location = new System.Drawing.Point(121, 558);
            this.buttonThousand.Name = "buttonThousand";
            this.buttonThousand.Size = new System.Drawing.Size(75, 38);
            this.buttonThousand.TabIndex = 17;
            this.buttonThousand.Text = "1000";
            this.buttonThousand.UseVisualStyleBackColor = true;
            this.buttonThousand.Click += new System.EventHandler(this.buttonThousand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(824, 608);
            this.Controls.Add(this.buttonThousand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGray);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonBlueViolet);
            this.Controls.Add(this.buttonAqua);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonLime);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Лаб. раб. №12 гр. 107з2 Монич Александр";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonLime;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonAqua;
        private System.Windows.Forms.Button buttonBlueViolet;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonGray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThousand;
    }
}