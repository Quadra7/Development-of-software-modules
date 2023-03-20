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
        //
        // Sun
        //
        int SunRadius = 100;
        //
        // Earth
        //
        int EarthAngle = 0;
        int EarthRadius = 50;
        int EarthCenterX, EarthCenterY;
        //
        // Moon
        //
        int MoonAngle = 0;
        int MoonRadius = 25;
        int MoonCenterX, MoonCenterY;
        //
        // Forms
        //
        public Form1()
        {
            InitializeComponent();
            Sun.Location = new Point(this.Width / 2 - 100, this.Height / 2 - 100);
        }
        //
        // Timers
        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            //
            // Earth
            //
            EarthAngle += 1;
            EarthCenterX = (this.Width / 2) + (int)((EarthRadius + SunRadius + 100) * Math.Cos(EarthAngle * Math.PI / 180));
            EarthCenterY = (this.Height / 2) + (int)((EarthRadius + SunRadius + 100) * Math.Sin(EarthAngle * Math.PI / 180));
            Earth.Left = EarthCenterX - EarthRadius;
            Earth.Top = EarthCenterY - EarthRadius;
            //
            // Moon
            //
            MoonAngle += 12;
            MoonCenterX = EarthCenterX + (int)((EarthRadius + 50) * Math.Cos(MoonAngle * Math.PI / 180));
            MoonCenterY = EarthCenterY + (int)((EarthRadius + 50) * Math.Sin(MoonAngle * Math.PI / 180));
            Moon.Left = MoonCenterX - MoonRadius;
            Moon.Top = MoonCenterY - MoonRadius;
        }
    }
}
