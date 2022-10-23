using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Page
{
    public partial class loadingpg : Form
    {
        private int tick;
        public loadingpg()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick += 1000;
            if(label2.Text.Length!=16)
            {
                label2.Text += ".".ToString();
            }
            if(tick==6000)
            {
                this.Close();
            }
        }
    }
}
