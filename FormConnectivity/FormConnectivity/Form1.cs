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


namespace FormConnectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data source=unknown;Initial Catalog=fruitshop;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("select * from items", con);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            dataGridView1.DataSource = dtbl;


           
        }
    }
}
