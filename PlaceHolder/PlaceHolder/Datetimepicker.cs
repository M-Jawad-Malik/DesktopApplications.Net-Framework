using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaceHolder
{
    public partial class Datetimepicker : Form
    {
        public Datetimepicker()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString("dd-mm-yyyy"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker2.Value.ToString("hh:mm:ss tt"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker3.Value.ToString("dd-mm-yyyy hh:mm:ss tt"));
        }

        private void Datetimepicker_Load(object sender, EventArgs e)
        {

        }
    }
}
