using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Login_Form
{
    public partial class Form1 : Form
    {
        string conect = ConfigurationManager.ConnectionStrings["conect"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch(check)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                case false:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conect);
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                try { 
               
                string query = "select * from LOGIN_TBL where usrm=@username and pass=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    textBox1.Clear();
                    textBox2.Clear();
                    if (dr.HasRows == true)
                    {
                        MessageBox.Show("Sign In Successfully", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Passowrd", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 
                    con.Close();
                }
                
                catch(Exception ce)
                {
                    con.Close();
                    MessageBox.Show(ce.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill Both Boxes", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Brown;
            button1.ForeColor = Color.Cyan;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
            button1.ForeColor = Color.Black;

        }
    }
}
