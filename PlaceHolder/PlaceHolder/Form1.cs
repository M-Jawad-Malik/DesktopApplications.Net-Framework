using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceHolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your name";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter your email")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter your email";
                textBox2.ForeColor = Color.DarkGray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
