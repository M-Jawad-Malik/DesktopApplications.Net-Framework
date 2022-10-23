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
    public partial class Form1 : Form
    {
        public static string text1;
        public static string text2;
        public static string text3;
        public static string text4;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text1 = textBox1.Text;
            text2 = textBox2.Text;
            text3 = textBox3.Text;
            text4 = textBox4.Text;
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
