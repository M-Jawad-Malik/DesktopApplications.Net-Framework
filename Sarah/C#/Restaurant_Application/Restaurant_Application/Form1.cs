using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            SidePanel.Height = button1.Height;
            firstCustomControl1.BringToFront();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            firstCustomControl1.BringToFront();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            secondCustomControl1.BringToFront();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
           
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;

         
         }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void btn2_ML(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Black;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void secondCustomControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
