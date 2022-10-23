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
using System.Threading;
namespace Loading_Page
{
    public partial class Form2 : Form
    {
        Thread th;

        SqlConnection conect = new SqlConnection("Data Source = localhost; Initial Catalog = PMS; Integrated Security = True");
        public Form2()
        {
            InitializeComponent();
            txtb2.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" login successful");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void txtb1_MouseEnter(object sender, EventArgs e)
        {
            if (txtb1.Text == "Username")
            {
                txtb1.Text = "";
            }
        }

        private void txtb2_MouseEnter(object sender, EventArgs e)
        {
            if (txtb2.Text == "Password")
            {
                txtb2.Text = "";
            }
            txtb2.UseSystemPasswordChar = true;
        }

        private void txtb1_MouseLeave(object sender, EventArgs e)
        {
            if(txtb1.Text=="")
            {
                txtb1.Text = "Username";
            }
        }

        private void txtb2_MouseLeave(object sender, EventArgs e)
        {
            if (txtb2.Text == "")
            {
                txtb2.Text = "Password";
                txtb2.UseSystemPasswordChar = false;
            }
            
        }

        private void txtb2_MouseDown(object sender, MouseEventArgs e)
        {
            txtb2.UseSystemPasswordChar = true;
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string query = "Select * from logininfo where usrnm='" + txtb1.Text.Trim() + "'and pass='" + txtb2.Text.Trim() + "'";
            conect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Close();
                conect.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();




            }

            else
            {
                conect.Close();
                MessageBox.Show("Username or Password Incorrect!");
            }
        }

        private void opennewform()
        {
           Application.Run(new HomePg());
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
