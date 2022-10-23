using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Data_OneForm_ToOther
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.text1;
            label3.Text = Form1.text2;
            label3.Text = Form1.text3;
            label4.Text = Form1.text4;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
