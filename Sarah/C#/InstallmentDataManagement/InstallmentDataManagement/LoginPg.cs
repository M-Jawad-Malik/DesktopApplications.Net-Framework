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


namespace FazleRabbi
{
    public partial class LoginPg : Form
    {
        Thread th;
        public LoginPg()
        {
            InitializeComponent();

        }
  

        private void LoginPg_Load(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Enter Username")
            {
                textBox1.Text = "";
            }
            

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
       
            if(textBox2.Text=="Enter Password")
            {
                textBox2.Text = "";
            }
            textBox2.UseSystemPasswordChar = true;
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "Enter Username";
            }
       

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text=="")
            {
                textBox2.Text = "Enter Password";
                textBox2.UseSystemPasswordChar = false;
            }
            
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_MouseHover_1(object sender, EventArgs e)
        {
            btnlogin.ActiveFillColor = ColorTranslator.FromHtml("#DDF311");

            btnlogin.ActiveForecolor=Color.SeaGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to close it!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
          if(result==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = RACIA; Integrated Security = True");
            string query = "Select * from loginifo where usrnm='" + textBox1.Text.Trim() + "'and pass='" + textBox2.Text.Trim() + "'";
            connection.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                this.Close();
                connection.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();




            }
            
            else
            {
                MessageBox.Show("Username or Password Incorrect!");
            }
            
        }

        private void opennewform()
        {
            Application.Run(new Homepg());
        }
    }
}
