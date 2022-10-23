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
namespace Petrol_Pump_Software.Forms
{
    public partial class LoginPg : Form
    {
        Thread th;
        SqlConnection conect = new SqlConnection("Data Source = localhost; Initial Catalog = PMS; Integrated Security = True");
        public LoginPg()
        {
            InitializeComponent();
        }

        private void LoginPg_Load(object sender, EventArgs e)
        {

        }

        private void txtb1_Enter(object sender, EventArgs e)
        {
            if (txtb1.Text == "Enter Username")
            {
                txtb1.Text = "";
                txtb1.FocusedBorderColor = Color.FromArgb(100, 88, 255);
            }
        }

        private void txtb1_Leave(object sender, EventArgs e)
        {
            if (txtb1.Text == "")
            {
                txtb1.Text = "Enter Username";
                txtb1.BorderColor = Color.CornflowerBlue;
            }
        }

        private void txtb2_Enter(object sender, EventArgs e)
        {
            if (txtb2.Text == "Enter Password")
            {
                txtb2.Text = "";
                txtb2.FocusedBorderColor = Color.FromArgb(100, 88, 255);
            }
            txtb2.UseSystemPasswordChar = true;
        }

        private void txtb2_Leave(object sender, EventArgs e)
        {
            if (txtb2.Text == "")
            {
                txtb2.Text = "Enter Password";
                txtb2.BorderColor = Color.CornflowerBlue;
                txtb2.UseSystemPasswordChar = false;
            }
            
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
    }
}
