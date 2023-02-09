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
    public partial class Form3 : Form
    {
        Random rnd = new Random();
        public Form3()
        {
            InitializeComponent();
        }
        //
        // Forms
        //
        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox tb = new TextBox();
            tb.BackColor = Color.Aquamarine;
            tb.Location = new Point(rnd.Next(1,panel1.Width), rnd.Next(1,panel1.Height));
            panel1.Controls.Add(tb);
        }
        //
        // Panels
        //
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button bt = new Button();
            bt.Width = 10;
            bt.Height = 10;
            bt.Location = e.Location;
            panel1.Controls.Add(bt);
        }
    }
}
