using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnoff_Click(object sender, EventArgs e)
        {

        }

        private void Btnmul_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text.Length != 0)
            {
                string num1 = txtDisplay.Text[0].ToString();
                string num = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
                if (num != "+" && num != "-" && num != "×" && num != "÷" && num != "%" && num1 != "√")
                {
                    if (preoperation != Operations.None)
                    {
                        PerformCal(preoperation);

                    }
                    preoperation = Operations.Mul;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text.Length>0)
            {
                
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            
        }

        private void Btnon_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text.Length != 0)
            {
                string num1 = txtDisplay.Text[0].ToString();
                string num = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
                if (num != "+" && num != "-" && num != "×" && num != "÷" && num != "%" && num1 != "√")
                {
                    if (preoperation != Operations.None)
                    {
                        PerformCal(preoperation);

                    }
                    preoperation = Operations.Div;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text.Length != 0)
            {
                string num1 = txtDisplay.Text[0].ToString();
                string num = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
                if (num != "+" && num != "-" && num != "×" && num != "÷" && num != "%" && num1 != "√")
                {
                    if (preoperation != Operations.None)
                    {
                        PerformCal(preoperation);

                    }
                    preoperation = Operations.Sub;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text.Length != 0)
            {
                string num1 = txtDisplay.Text[0].ToString();
                string num = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
                if ( num!= "+"&&num!="-"&&num!= "×"&& num!="÷"&&num!="%" && num1 != "√")
                {
                    if (preoperation != Operations.None)
                    {
                        PerformCal(preoperation);

                    }
                    preoperation = Operations.Add;

                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void PerformCal(Operations preoperation)
        {
            List<double> lstNums=new List<double>();
            if(preoperation==Operations.Add)
            {
                lstNums = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                txtDisplay.Text = (lstNums[0] + lstNums[1]).ToString();
            }
            else if (preoperation == Operations.Sub)
            {
                lstNums = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                txtDisplay.Text = (lstNums[0] - lstNums[1]).ToString();
            }
            else if (preoperation == Operations.Mul)
            {
                lstNums = txtDisplay.Text.Split('×').Select(double.Parse).ToList();
                txtDisplay.Text = (lstNums[0] * lstNums[1]).ToString();
            }
            else if (preoperation == Operations.Div)
            {
                try
                {
                    lstNums = txtDisplay.Text.Split('÷').Select(double.Parse).ToList();
                    txtDisplay.Text = (lstNums[0] / lstNums[1]).ToString();
                }
                catch (DivideByZeroException)
                {
                    txtDisplay.Text = "Error!";
                }
            }
            else if (preoperation == Operations.Mod)
            {
                lstNums = txtDisplay.Text.Split('%').Select(double.Parse).ToList();
                txtDisplay.Text = (lstNums[0] % lstNums[1]).ToString();
            }
            else if (preoperation == Operations.Sqrt)
            {
                string opera;
                 Int64 num;
                opera= txtDisplay.Text.Remove(0, 1);
                num = Convert.ToInt64(opera);
                txtDisplay.Text = (Math.Sqrt(num)).ToString();
            }

        }

        private void btnequ_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length != 0)
            {
                string num = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
                if (preoperation == Operations.None)
                {
                    return;
                }
                else
                {
                    if (num != "+" && num != "-" && num != "×" && num != "÷" && num != "%")
                    {
                        PerformCal(preoperation);
                        preoperation = Operations.None;
                    }
                }
            }
        }

        private void Btnnum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
            
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        enum Operations
        {
            Add,
            Sub,
            Div,
            Mul,
            Mod,
            //sqrt added
            Sqrt,
            None
        }
        static Operations preoperation = Operations.None;

        private void btnmod_Click(object sender, EventArgs e)
        {
            string num1 = txtDisplay.Text[0].ToString();
            string num = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
            if (txtDisplay.Text.Length != 0)
            {
                if (num != "+" && num != "-" && num != "×" && num != "÷" && num != "%" && num1 != "√"
                {
                    if (preoperation != Operations.None)
                    {
                        PerformCal(preoperation);

                    }
                    preoperation = Operations.Mod;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }

        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            
            if (txtDisplay.Text.Length == 0)
            {

                if (preoperation != Operations.None)
                {
                    PerformCal(preoperation);

                }
                preoperation = Operations.Sqrt;
                txtDisplay.Text += (sender as Button).Text;
                }
            
        }
    }
}
