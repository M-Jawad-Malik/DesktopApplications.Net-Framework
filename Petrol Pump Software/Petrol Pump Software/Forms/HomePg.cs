using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Pump_Software.Forms
{
    public partial class HomePg : Form
    {

        mainpg mp = new mainpg();
        Image image = Image.FromFile(@"F:\Petrol.jpg");
        public HomePg()
        {
            InitializeComponent();
            //Bitmap bmp = new Bitmap(image);
            //Opacity(ref bmp);
            //pictureBox2.Image = (Image)bmp;
        }

        private void HomePg_Load(object sender, EventArgs e)
        {

        }
        private void Opacity(ref Bitmap image)
        {
            for (int w = 0; w < image.Width; w++)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    Color c = image.GetPixel(w, h);
                    if (c != Color.Transparent) /*<- it only change colours different than transparency color.*/
                    {
                        Color newC = Color.FromArgb(c.A / 2, c.R / 2, c.G / 2, c.B/2); /*<- this gives real opacity.*/
                        image.SetPixel(w, h, newC);
                    }
                }
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
