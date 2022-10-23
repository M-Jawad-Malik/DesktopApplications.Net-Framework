using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FazleRabbi
{
    public partial class ProPur : UserControl
    {
        SqlConnection conect = new SqlConnection("Data Source = localhost; Initial Catalog = RACIA; Integrated Security = True");
        public ProPur()
        {
            InitializeComponent();
            this.generl_combobox();
        }

        public void addnew_Click(object sender, EventArgs e)
        {
            
        }

        private void txtb1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ProPur_Load(object sender, EventArgs e)
        {
            
        }
        Label addlabel(int i)
        {
            Label l = new Label();

            l.ForeColor = Color.Black;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Name = "Label" + i.ToString();
            
            l.Font = new Font("Century", 12, FontStyle.Regular);
            l.Width = 154;
            l.Height = 18;
            l.Margin = new Padding(20,0,0,2);
            if(i==1||i==4||i==7||i==10)
            {
                l.Text = "Enter Product Name" ;
            }
           else if (i == 2 || i == 5 || i == 8 || i == 11)
            {
                l.Text  = "Enter Company Name";
            }
           else  if (i == 3 || i == 6 || i == 9 || i == 12)
            {
                l.Text  = "Enter category or Model";
            }
            return l;
        }
        TextBox addtxtb(int i)
        {
            TextBox txtb = new TextBox();
            txtb.Name = "txtb" + i.ToString();
            txtb.ForeColor = Color.Black;
            txtb.BackColor = Color.White;
            txtb.Font = new Font("Century", 12, FontStyle.Regular);
            txtb.Width = 208;
            txtb.Height = 26;
            txtb.Margin = new Padding(40,5,5,5);
            return txtb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        public void generl_combobox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            conect.Open();
            //Combobox1//
            string query = "Select Distinct(PrdctNm) from NewPro";
            SqlCommand cmd = new SqlCommand(query, conect);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["PrdctNm"].ToString());


            }
            conect.Close();
            //Combobox1//
        }
        public void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            //Combobox2// 
            conect.Open();
            string query1 = "Select Distinct(PrdctCmpny) from NewPro where PrdctNm='" + comboBox1.Text + "';";
            SqlCommand cmd1 = new SqlCommand(query1, conect);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBox2.Items.Add(dr1["PrdctCmpny"].ToString());

            }
            conect.Close();
           
            //Combobox2//

        }
        public void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            //Combobox3//
            conect.Open();
            string query2 = "Select Distinct(PrdctCtgry) from NewPro where PrdctNm='" +comboBox1.Text + "'and PrdctCmpny ='" + comboBox2.Text + "';";
            SqlCommand cmd2 = new SqlCommand(query2, conect);
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                comboBox3.Items.Add(dr2["PrdctCtgry"].ToString());


            }
            conect.Close();
            //Combobox3//
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
