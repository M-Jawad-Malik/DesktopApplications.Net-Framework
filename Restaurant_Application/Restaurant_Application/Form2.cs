using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Application
{
    public partial class Form2 : Form
    {
        private int _ticks=1000;
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks+=1000;
            if(label2.Text.Length!=20)
            {
                label2.Text += ".".ToString();

            }
            if (_ticks== 7000)
            {
                this.Close();
            }
        }
    }
}
