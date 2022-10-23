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
namespace Email_Ver
{
    public partial class Form1 : Form
    {
        string pattern= "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)==true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Please Write your name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox2.Text,pattern)==false)
            {
                //textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Email pattern is not correct");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || Regex.IsMatch(textBox2.Text, pattern) == false)
            {
                MessageBox.Show("Fill the Form completely and correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Welcome", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();



            }
            //if (textBox1.Text.Any(c => char.IsLetter(c)) && textBox1.Text.Any(c => char.IsDigit(c)) && textBox1.Text.Any(c => char.IsPunctuation(c)))
            //{
            //    MessageBox.Show("Not");
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
