using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                //MessageBox.Show("Fill the Name Box!");
                errorProvider1.SetError(this.textBox1, "Please fill the Name !! ");
            }          
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Focus();
                //MessageBox.Show("Fill the Age Box!");
                errorProvider2.SetError(this.textBox2, "Please fill the age !! ");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Please Fill Required Field!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
