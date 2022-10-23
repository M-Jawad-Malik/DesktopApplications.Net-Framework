using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Preodic_Table
{
    public partial class Form1 : Form
    {
        private int _tick = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick += 1000;
            if (label2.Text.Length != 21)
            {
                label2.Text += ".".ToString();
            }
            if (_tick == 6000)
            {
                this.Close();
            }
        }
    }
}
