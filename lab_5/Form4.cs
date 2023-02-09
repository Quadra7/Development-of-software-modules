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
    public partial class Form4 : Form
    {
        Random rnd = new Random();
        public Form4()
        {
            InitializeComponent();
        }
        //
        // Panels
        //
        private void panelFirst_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Width = 30;
            tb.BackColor = Color.Violet;
            tb.Location= new Point(rnd.Next(1,panelSecond.Width), rnd.Next(panelSecond.Height));
            panelSecond.Controls.Add(tb);
        }
        private void panelSecond_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Width = 30;
            tb.BackColor = Color.Violet;
            tb.Location = new Point(rnd.Next(1, panelThird.Width), rnd.Next(panelThird.Height));
            panelThird.Controls.Add(tb);
        }

        private void panelThird_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox tb = new TextBox();
            tb.Width = 30;
            tb.BackColor = Color.Violet;
            tb.Location = new Point(rnd.Next(1, panelFirst.Width), rnd.Next(panelFirst.Height));
            panelFirst.Controls.Add(tb);
        }
    }
}
