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
namespace DATAGRIDVIEW
{
    
    public partial class Form1 : Form
    {
        SqlConnection conect = new SqlConnection("Data Source=localhost;Initial Catalog=RACIA;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            conect.Open();
            string query = "select usrnm as 'User Name',pass as 'Password' from loginifo";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
            conect.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["User Name"].Value.ToString();
                textBox2.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                conect.Open();
                string query = "Select * from loginifo where usrnm='" + textBox1.Text.Trim() + "'and pass ='" + textBox2.Text.Trim() + "';";
                SqlCommand cmd = new SqlCommand(query, conect);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    MessageBox.Show("Succefully Login!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Incorrect Password or User Name...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conect.Close();
            }
            else
            {
                MessageBox.Show("Entries Empty...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
