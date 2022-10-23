using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazleRabbi
{
    public partial class Form1 : Form
    {
        private int tick = 0;
        public Form1()
        {
            InitializeComponent();
            //this.pictureBox1.Image = Image.FromFile(@"C:\Users\Muhammad Jawad\Downloads\imgs\mc.png");
            //this.pictureBox2.Image = Image.FromFile(@"C:\Users\Muhammad Jawad\Downloads\imgs\mc.png");
            //picBoxprob.picoverlay(this.pictureBox1, this.pictureBox2);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick += 1000;
            if(label1.Text.Length!=21)
            {
                label1.Text += ".".ToString();
            }
            if(tick==5000)
            {
                this.Close();
            }
        }
    }
}
