using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadingPage1
{
    public partial class Form1 : Form
    {
        int tick = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left += 100;
            if(panel2.Left==600)
            {
                panel2.Left = 0;
            }
            tick += 500;
            if(tick==5000)
            {
                this.Close();
            }

        }
    }
}
