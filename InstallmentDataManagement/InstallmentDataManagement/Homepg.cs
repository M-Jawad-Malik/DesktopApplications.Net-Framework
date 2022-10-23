using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazleRabbi
{
    
    public partial class Homepg : Form
    {
        public mainPg mp = new mainPg();
        public Homepg()
        {
            InitializeComponent();
            mp.hpbtn1.Click += new System.EventHandler(this.show);
            mp.button2.Click += new System.EventHandler(this.button2_Click);
         
            
            


        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Homepg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to close it!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mp.Close();
                this.Close();
                
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
            mp.hpbtn2_Click(sender,e);

        }

        private void show(object sender, EventArgs e)
        {
            mp.Hide();
            this.Show();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
            mp.hpbtn5_Click(sender, e);
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
            mp.hpbtn6_Click(sender, e);
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
            mp.hpbtn3_Click(sender, e);
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
            
            mp.hpbtn4_Click(sender, e);
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mp.Show();
            mp.hpbtn7_Click(sender, e);
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
