using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUploading
{
    public partial class Form1 : Form
    {
        Image file;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG|*.JPG;*.jpg;*.jpeg|PNG|*.PNG;*.png";
            if(f.ShowDialog()==DialogResult.OK)
            {
                file = Image.FromFile(f.FileName);
                pictureBox1.Image = file;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG|*.JPG;*.jpg;*.jpeg|PNG|*.PNG;*.png";
            if(f.ShowDialog()==DialogResult.OK)
            {
                file.Save(f.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
