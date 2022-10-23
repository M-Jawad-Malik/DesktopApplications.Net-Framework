using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace VerifyEmailPattern
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {   if (textBox1.Text == String.Empty)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Empty TextBox, Enter Your Name");}
            else{
                errorProvider1.Clear();}}
        private void textBox2_MouseLeave(object sender, EventArgs e)
        {    if (textBox2.Text == String.Empty)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Empty TextBox, Enter Your Enail");
            }
            else
            {
                errorProvider2.Clear();
            }}
        private void button1_Click(object sender, EventArgs e)
        {if (textBox1.Text != String.Empty && Regex.IsMatch(textBox2.Text, pattern)==true)
            {
                MessageBox.Show("You have Login Successfully!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear(); }
            else {
                MessageBox.Show("Error In Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
