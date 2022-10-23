using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Loading_Page
{
    public partial class Form1 : Form
    {
        Thread th;
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            drop2.Visible = false;
            drop3.Visible = false;
        }

        private void gunaCircleProgressBar1_Click(object sender, EventArgs e)
        {

        }
        int progress = 0;
        public void frm_probar()
        {
            progress += 1;
            if(progress>=100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            Loadingbar.Value = progress;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            frm_probar();
            drop.Top += 1;
            
           
            if (drop.Top == 309)
            {
                drop2.Visible = true;
                drop3.Visible = true;
                
            }
            if(drop.Top>=320)
            {
                drop.SendToBack();
                drop2.Top += 1;
                drop3.Top += 1;
            }
            if(drop3.Top==315)
            {
                drop3.Visible = false;
            }
            if(drop2.Top==315)
            {
                drop2.Visible = false;
            }
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void opennewform()
        {
            Application.Run(new Form2());
        }
    }
}
