using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnum_Click(object btn, EventArgs e)
        {
            txtDisplay.Text += (btn as Button).Text;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void btnon_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }
        enum Operation
        {
            Add,
            Sub,
            Mul,
            Div,
            Mod,
            None
        }
        static Operation preoperation = Operation.None;

        private void btnadd_Click(object sender, EventArgs e)
        {
            string oper = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
            if (txtDisplay.Text.Length != 0)
            {
                if (oper != "+" && oper != "-" && oper != "/" && oper != "*" && oper != "%")
                {
                    if (preoperation != Operation.None)
                    {
                        PerformCal(preoperation);
                    }
                    preoperation = Operation.Add;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            string oper = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
            if (txtDisplay.Text.Length != 0)
            {
                if (oper != "+" && oper != "-" && oper != "/" && oper != "*" && oper != "%")
                {
                    if (preoperation != Operation.None)
                    {
                        PerformCal(preoperation);
                    }
                    preoperation = Operation.Sub;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            string oper = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
            if (txtDisplay.Text.Length != 0)
            {
                if (oper != "+" && oper != "-" && oper != "/" && oper != "*" && oper != "%")
                {
                    if (preoperation != Operation.None)
                    {
                        PerformCal(preoperation);
                    }
                    preoperation = Operation.Mul;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            string oper = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
            if (txtDisplay.Text.Length != 0)
            {
                if (oper != "+" && oper != "-" && oper != "/" && oper != "*" && oper != "%")
                {
                    if (preoperation != Operation.None)
                    {
                        PerformCal(preoperation);
                    }
                    preoperation = Operation.Div;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            string oper = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
            if (txtDisplay.Text.Length != 0)
            {
                if (oper != "+" && oper != "-" && oper != "/" && oper != "*" && oper != "%")
                {
                    if (preoperation != Operation.None)
                    {
                        PerformCal(preoperation);
                    }
                    preoperation = Operation.Mod;
                    txtDisplay.Text += (sender as Button).Text;
                }
            }
        }

        private void PerformCal(Operation preoperation)
        {
            List<double> ls = new List<double>();
            if (preoperation == Operation.Add)
            {
                ls = txtDisplay.Text.Split('+').Select(double.Parse).ToList();
                txtDisplay.Text = (ls[0] + ls[1]).ToString();


            }
            else if (preoperation == Operation.Sub)
            {
                ls = txtDisplay.Text.Split('-').Select(double.Parse).ToList();
                txtDisplay.Text = (ls[0] - ls[1]).ToString();


            }
            else if (preoperation == Operation.Mul)
            {
                ls = txtDisplay.Text.Split('*').Select(double.Parse).ToList();
                txtDisplay.Text = (ls[0] * ls[1]).ToString();


            }
            else if (preoperation == Operation.Div)
            {
                try
                {
                    ls = txtDisplay.Text.Split('/').Select(double.Parse).ToList();
                    txtDisplay.Text = (ls[0] / ls[1]).ToString();
                }
                catch (DivideByZeroException)
                {
                    txtDisplay.Text = "Error!";
                }

            }
            else if (preoperation == Operation.Mod)
            {
                ls = txtDisplay.Text.Split('%').Select(double.Parse).ToList();
                txtDisplay.Text = (ls[0] % ls[1]).ToString();


            }

        }

        private void btnequ_Click(object sender, EventArgs e)
        {
            string oper = txtDisplay.Text[txtDisplay.Text.Length - 1].ToString();
            if (preoperation == Operation.None)
            {
                return;
            }
            else
            {
                if (oper != "+" && oper != "-" && oper != "/" && oper != "*" && oper != "%")
                {
                    PerformCal(preoperation);
                }
            }
        }
    }
}
