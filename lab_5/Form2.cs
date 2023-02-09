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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //
        // Forms
        //
        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Button bt = new Button();
            TextBox tb = new TextBox();

            if (e.X < this.Width / 2)
            {
                bt.Width = 100;
                bt.Height = 50;
                bt.Location = e.Location;
                bt.BackColor = Color.Coral;
                bt.Text = $"{e.Location}";
                Controls.Add(bt);
            }
            else
            {
                tb.Width = 100;
                tb.Height = 50;
                tb.Location = e.Location;
                tb.BackColor = Color.AntiqueWhite;
                Controls.Add(tb);
            }
        }
    }
}
