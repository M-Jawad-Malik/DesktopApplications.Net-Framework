using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hover_btn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

            label1.Text = "Mouse is on the button";
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.Red;
            button1.Font = new Font("Century ", 14);

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Mouse is not on the button";
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button1.Font = new Font("Century", 9);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString("dd-MM-yyyy hh:mm:ss tt"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString();
            //label3.Text = dt.ToLongDateString();
            //label3.Text = dt.ToShortDateString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
