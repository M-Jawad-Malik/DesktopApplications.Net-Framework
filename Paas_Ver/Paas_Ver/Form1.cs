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
namespace Paas_Ver
{
    public partial class Form1 : Form
    {
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Enter your email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your email";
                textBox1.ForeColor = Color.DarkGray;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter your password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter your password";
                textBox2.ForeColor = Color.DarkGray;
            }
        }

      

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true || Regex.IsMatch(textBox1.Text, pattern) == false)
            {
                MessageBox.Show("Write Email correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBox2.Text.Length >= 8)
                {
                    if (!(textBox2.Text.Any(c => char.IsLetter(c)) && textBox2.Text.Any(c => char.IsDigit(c)) && textBox2.Text.Any(c => char.IsPunctuation(c))))
                    {
                        MessageBox.Show("Not a Strong Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Resgistered Succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("There must be 8 Character Passowrd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
