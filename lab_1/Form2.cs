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
        private void Form2_Load(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
            labelText.Text = "Начало работы";
        }
        //
        // Buttons
        //
        private void buttonHello_Click(object sender, EventArgs e)
        {
            labelText.Text = "Привет";
        }
        private void buttonGoodbye_Click(object sender, EventArgs e)
        {
            labelText.Text = "До свидания";
        }
    }
}
