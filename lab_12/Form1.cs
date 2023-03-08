using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace lesson_02022023
{
    public partial class Form1 : Form
    {
        //
        // Classes
        //
        class Dot
        {
            public int x, y;
            public int r, g, b;
            public Dot(int posx, int posy, int cr, int cg, int cb)
            {
                x = posx;
                y = posy;
                r = cr;
                g = cg;
                b = cb;
            }
        }
        //
        // Variables
        //
        Graphics g;
        Bitmap pic;
        Point prevPoint, currPoint;
        Random rnd = new Random();
        Dot[] dots = new Dot[1000];
        Pen PenColor = new Pen(Color.Black, 1);
        public Form1()
        {
            InitializeComponent();
            g = Graphics.FromImage(pictureBox1.Image);
        }
        //
        // PictureBox
        //
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint.X = e.X;
            prevPoint.Y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currPoint.X = e.X;
                currPoint.Y = e.Y;
                g.DrawLine(PenColor, prevPoint, currPoint);
                prevPoint.X = currPoint.X;
                prevPoint.Y = currPoint.Y;
                pictureBox1.Invalidate();
            }
        }
        //
        // This method change Pen width
        //
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            PenColor.Width = Convert.ToInt16(numericUpDown1.Value);
        }
        //
        // Buttons, which change Pen color
        //
        private void buttonRed_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Red;
        }
        private void Orange_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Orange;
        }
        private void buttonYellow_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Yellow;
        }
        private void buttonLime_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Lime;
        }
        private void buttonBlue_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Blue;
        }
        private void buttonFuchsia_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Fuchsia;
        }
        private void buttonAqua_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Aqua;
        }
        private void buttonBlueViolet_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.BlueViolet;
        }
        private void buttonBlack_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Black;
        }
        private void buttonGreen_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Green;
        }
        private void buttonGray_Click(object sender, EventArgs e)
        {
            PenColor.Color = Color.Gray;
        }
        //
        // Button, which make 1000 dots on pic
        //
        private void buttonThousand_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                dots[i] = new Dot(rnd.Next(0, pictureBox1.Width), rnd.Next(0, pictureBox1.Height), rnd.Next(255), rnd.Next(255), rnd.Next(255));
                g.DrawString(".", new Font("Times New Roman", 24), new SolidBrush(Color.FromArgb(dots[i].r, dots[i].g, dots[i].b)), dots[i].x, dots[i].y);
            }
            pictureBox1.Invalidate();
        }
        //
        // Buttons within OpenFileDialog
        //
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                int width = image.Width;
                int height = image.Height;
                if (width > pictureBox1.Width || height > pictureBox1.Height)
                {
                    MessageBox.Show("Max size of picture is 800x500", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                pictureBox1.Width = width; pictureBox1.Height = height;
                pic = new Bitmap(image, width, height);
                pictureBox1.Image = pic;
                g = Graphics.FromImage(pictureBox1.Image);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.Filter = "Bitmap File(*.bmp)|*.bmp|GIF File(*.gif)|*.gif|JPEG File(*.jpg)|*.jpg|PNG File(*.png)|*.png";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                Image image = pictureBox1.Image;
                pic = new Bitmap(image, pictureBox1.Width, pictureBox1.Height);
                string filename = savedialog.FileName;
                string strFilExtn = filename.Remove(0, filename.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        pic.Save(filename, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        pic.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        pic.Save(filename, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        pic.Save(filename, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        pic.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
