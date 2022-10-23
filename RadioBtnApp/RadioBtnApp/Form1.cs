using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBtnApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                MessageBox.Show("you have selected country: " + "" + radioButton1.Text);
            }
           else if (radioButton2.Checked == true)
            {
                MessageBox.Show("you have selected country: " + "" + radioButton2.Text);
            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("you have selected country: " + "" + radioButton3.Text);
            }
            else
            {
                MessageBox.Show("Plz select country ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                groupBox1.BackColor = Color.Red;
                groupBox1.ForeColor = Color.White;
            }

            else if (radioButton5.Checked == true)
            {
                groupBox1.BackColor = Color.Blue;
                groupBox1.ForeColor = Color.White;
            }
            else if (radioButton6.Checked == true)
            {
                groupBox1.BackColor = Color.Green;
                groupBox1.ForeColor = Color.White;
            }
            else
            {
                MessageBox.Show("Please select a Color ");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                this.BackColor = Color.Brown;
              
            }

            else if (radioButton8.Checked == true)
            {
                this.BackColor = Color.Purple;
           
            }
            else if (radioButton9.Checked == true)
            {
                this.BackColor = Color.Orange;
              
            }
            else
            {
                MessageBox.Show("Please select a Color ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
