using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Process.Start("http://www.google.com");
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void radMultiColumnComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb1.Text != "")
            {
                cmb1.Items.Add(cmb1.Text);
            }
            else
            {
                MessageBox.Show("No Item Entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmb1.Items.Remove(cmb1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count; ;
            count = cmb1.Items.Count;
            label1.Text = count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmb1.Items.Clear();
        }
    }
}
