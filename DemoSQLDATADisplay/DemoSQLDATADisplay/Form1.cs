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
namespace DemoSQLDATADisplay
{
    public partial class Form1 : Form
    {
        string connect = @"Data Source=localhost;Initial Catalog=Company;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlcnct=new SqlConnection(connect))
            {
                sqlcnct.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from employee", sqlcnct);
                DataTable dtbl = new DataTable();
                SqlDataAdapter sqlda1 = new SqlDataAdapter("select emp_id,first_name,salary from employee", sqlcnct);
                DataTable dtbl1 = new DataTable();
                sqlda1.Fill(dtbl1);
                sqlda.Fill(dtbl);
                //method 1 Direct Method
                dgv1.DataSource = dtbl;
                //Method 2 DG Column
                dgv2.DataSource = dtbl1;
                
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlcnct = new SqlConnection(connect))
            {
                sqlcnct.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select * from employee", sqlcnct);
                DataTable dtbl = new DataTable();
                SqlDataAdapter sqlda1 = new SqlDataAdapter("select emp_id,first_name,salary from employee where emp_id='"+textBox1.Text.Trim()+"'", sqlcnct);
                DataTable dtbl1 = new DataTable();
                sqlda1.Fill(dtbl1);
                sqlda.Fill(dtbl);
                //method 1 Direct Method
                dgv1.DataSource = dtbl;
                //Method 2 DG Column
                dgv2.DataSource = dtbl1;
            }
        }
    }
}
