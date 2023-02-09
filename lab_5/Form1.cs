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
        }
        //
        // Forms
        //
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
                Button bt = new Button();
                bt.Width = 100;
                bt.Height = 100;
                bt.Location = e.Location;
                bt.Text = $"{e.Location}";
                bt.BackColor = Color.Yellow;
                Controls.Add(bt);
        }
    }
}
