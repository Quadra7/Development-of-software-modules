using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_02022023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(@"..\..\sky.jpg");
            pictureBox1.BackgroundImage = new Bitmap(@"..\..\first.png");
            pictureBox1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap(@"..\..\second.png");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top--;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.BackgroundImage = new Bitmap(@"..\..\first.png");
            pictureBox1.Location = new Point(277, 92);
        }
    }
}
