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
namespace Data_Insertion
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please fill the Box");
            }
           else  if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please fill the Box");
            }

            else if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider3.SetError(comboBox1, "Please fill the Box");
            }

            else if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Please fill the Box");
            }
            else
            {
                SqlConnection con = new SqlConnection(conect);
                if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && comboBox1.Text != string.Empty && textBox4.Text != string.Empty)
                {
                    try
                    {
                        string q = "Select * from customer where C_ID=@cid";
                        SqlCommand cmd1 = new SqlCommand(q, con);
                        cmd1.Parameters.AddWithValue("@cid", textBox1.Text);
                        con.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == true)
                        {
                            MessageBox.Show(textBox1.Text + "Record Exist..", "Succesful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(textBox1.Text + "No Record Exist..", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            con.Close();
                            string query = "insert into customer values(@cid,@cname,@cgender,@cadd)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@cid", textBox1.Text);
                            cmd.Parameters.AddWithValue("@cname", textBox2.Text);
                            cmd.Parameters.AddWithValue("@cgender", comboBox1.SelectedItem);
                            cmd.Parameters.AddWithValue("@cadd", textBox4.Text);

                            con.Open();
                            int a = cmd.ExecuteNonQuery();
                            if (a > 0)
                            {
                                textBox1.Text = string.Empty;
                                textBox2.Text = string.Empty;
                                comboBox1.Text = string.Empty;
                                textBox4.Text = string.Empty;
                                MessageBox.Show("Added Succesfully", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Not Added", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        
                        con.Close();

                    }
                    catch (Exception ce)
                    {
                        con.Close();
                        MessageBox.Show(ce.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please Fill all the Boxes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Please fill the Box");
            }
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(textBox2, "Please fill the Box");
            }
            {
                errorProvider2.Clear();
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                comboBox1.Focus();
                errorProvider3.SetError(comboBox1, "Please fill the Box");
            }
            {
                errorProvider3.Clear();
            }
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text) == true)
            {
                textBox4.Focus();
                errorProvider4.SetError(textBox4, "Please fill the Box");
            }
            {
                errorProvider4.Clear();
            }
        }
    }
}
