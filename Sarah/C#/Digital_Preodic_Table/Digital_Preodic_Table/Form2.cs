using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Digital_Preodic_Table
{

    public partial class Form2 : Form
    {
        
        private int col_count = 1;
        private Color col;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Color col=ColorTranslator.FromHtml("#ffa36c");

            //panel2.BackColor =Color.FromArgb(1,col);
            
            history1.BringToFront();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_element ae = this.add_element1;
            ae.saved.Visible = false;
            ae.tb1.Text = "";
            ae.tb2.Text = "";
            ae.tb3.Text = "";
            ae.tb4.Text = "";
            ae.tb5.Text = "";
            ae.tb6.Text = "";
            ae.tb7.Text = "";
            ae.tb8.Text = "";
            if (col_count != 1)
            {

                history1.BringToFront();
                button4.ForeColor = Color.Black;
                if (col_count == 2)
                {
                    col = button7.BackColor;
                    button7.BackColor = button4.BackColor;
                    button4.BackColor = col;
                    button7.ForeColor = Color.White;
                }
                else if (col_count == 3)
                {
                    col = button6.BackColor;
                    button6.BackColor = button4.BackColor;
                    button4.BackColor = col;
                    button6.ForeColor = Color.White;

                }
                if (col_count == 4)
                {
                    col = button5.BackColor;
                    button5.BackColor = button4.BackColor;
                    button4.BackColor = col;
                    button5.ForeColor = Color.White;

                }
                col_count = 1;
            }
            Search s = this.search1;
            s.radioButton1.Checked = false;
            s.radioButton2.Checked = false;
            s.radioButton3.Checked = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            add_element ae = this.add_element1;
            ae.saved.Visible = false;
            ae.tb1.Text = "";
            ae.tb2.Text = "";
            ae.tb3.Text = "";
            ae.tb4.Text = "";
            ae.tb5.Text = "";
            ae.tb6.Text = "";
            ae.tb7.Text = "";
            ae.tb8.Text = "";
            if (col_count != 2)
            {

                search1.BringToFront();
                button7.ForeColor = Color.Black;
                if (col_count == 1)
                {
                    col = button4.BackColor;
                    button4.BackColor = button7.BackColor;
                    button7.BackColor = col;
                    button4.ForeColor = Color.White;
                }
                else if (col_count == 3)
                {
                    col = button6.BackColor;
                    button6.BackColor = button7.BackColor;
                    button7.BackColor = col;
                    button6.ForeColor = Color.White;

                }
                if (col_count == 4)
                {
                    col = button5.BackColor;
                    button5.BackColor = button7.BackColor;
                    button7.BackColor = col;
                    button5.ForeColor = Color.White;

                }
                col_count = 2;
                Search s = this.search1;
                s.radioButton1.Checked = false;
                s.radioButton2.Checked = false;
                s.radioButton3.Checked = false;
                s.textBox1.ReadOnly = true;
                s.textBox2.ReadOnly = true;
                s.textBox3.ReadOnly = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_element ae = this.add_element1;
            ae.saved.Visible = false;
            ae.tb1.Text = "";
            ae.tb2.Text = "";
            ae.tb3.Text = "";
            ae.tb4.Text = "";
            ae.tb5.Text = "";
            ae.tb6.Text = "";
            ae.tb7.Text = "";
            ae.tb8.Text = "";
            if (col_count != 3)
            {

                add_element1.BringToFront();
                button6.ForeColor = Color.Black;
                if (col_count == 1)
                {
                    col = button4.BackColor;
                    button4.BackColor = button6.BackColor;
                    button6.BackColor = col;
                    button4.ForeColor = Color.White;
                }
                else if (col_count == 2)
                {
                    col = button7.BackColor;
                    button7.BackColor = button6.BackColor;
                    button6.BackColor = col;
                    button7.ForeColor = Color.White;

                }
                if (col_count == 4)
                {
                    col = button5.BackColor;
                    button5.BackColor = button6.BackColor;
                    button6.BackColor = col;
                    button5.ForeColor = Color.White;

                }
                col_count = 3;
                Search s = this.search1;
                s.radioButton1.Checked = false;
                s.radioButton2.Checked = false;
                s.radioButton3.Checked = false;
                s.textBox1.ReadOnly = true;
                s.textBox2.ReadOnly = true;
                s.textBox3.ReadOnly = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            add_element ae = this.add_element1;
            ae.saved.Visible = false;
            ae.tb1.Text = "";
            ae.tb2.Text = "";
            ae.tb3.Text = "";
            ae.tb4.Text = "";
            ae.tb5.Text = "";
            ae.tb6.Text = "";
            ae.tb7.Text = "";
            ae.tb8.Text = "";
            if (col_count != 4)
            {

                displayall1.BringToFront();
                button5.ForeColor = Color.Black;
                if (col_count == 1)
                {
                    col = button4.BackColor;
                    button4.BackColor = button5.BackColor;
                    button5.BackColor = col;
                    button4.ForeColor = Color.White;
                }
                else if (col_count == 2)
                {
                    col = button7.BackColor;
                    button7.BackColor = button5.BackColor;
                    button5.BackColor = col;
                    button7.ForeColor = Color.White;

                }
                if (col_count == 3)
                {
                    col = button6.BackColor;
                    button6.BackColor = button5.BackColor;
                    button5.BackColor = col;
                    button6.ForeColor = Color.White;

                }
                col_count = 4;
                Search s = this.search1;
                s.radioButton1.Checked = false;
                s.radioButton2.Checked = false;
                s.radioButton3.Checked = false;
                s.textBox1.ReadOnly = true;
                s.textBox2.ReadOnly = true;
                s.textBox3.ReadOnly = true;
            }
        }

        private void explor1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            add_element ae = this.add_element1;
            ae.saved.Visible = false;
            ae.tb1.Text = "";
            ae.tb2.Text = "";
            ae.tb3.Text = "";
            ae.tb4.Text = "";
            ae.tb5.Text = "";
            ae.tb6.Text = "";
            ae.tb7.Text = "";
            ae.tb8.Text = "";

            Search s = this.search1;
            //tab_color_change_start
            if (col_count != 2)
            {

                search1.BringToFront();
                button7.ForeColor = Color.Black;
                if (col_count == 1)
                {
                    col = button4.BackColor;
                    button4.BackColor = button7.BackColor;
                    button7.BackColor = col;
                    button4.ForeColor = Color.White;
                }
                else if (col_count == 3)
                {
                    col = button6.BackColor;
                    button6.BackColor = button7.BackColor;
                    button7.BackColor = col;
                    button6.ForeColor = Color.White;

                }
                if (col_count == 4)
                {
                    col = button5.BackColor;
                    button5.BackColor = button7.BackColor;
                    button7.BackColor = col;
                    button5.ForeColor = Color.White;

                }
                col_count = 2;
            }
            //end
           
                for (int i = 1; i <120; i++)
                {
                    if (i.ToString() == textBox1.Text)
                    {
                        s.label19.Text = s.arra[i - 1].ToString();
                        s.label18.Text = textBox1.Text.ToString();
                        s.label17.Text = s.arrc[i - 1].ToString();
                        s.label16.Text = s.arrd[i - 1].ToString();
                        s.label15.Text = s.arre[i - 1].ToString();
                        s.label14.Text = s.arrh[i - 1].ToString();
                        s.label13.Text = s.arrg[i - 1].ToString();
                        s.label12.Text = s.arrf[i - 1].ToString();


                    }

                }
                
            
            
                for (int i = 0; i < 120; i++)
                {
                    if (textBox1.Text == s.arra[i].ToString())
                    {
                        s.label19.Text = s.arra[i].ToString();
                        s.label18.Text = (i + 1).ToString();
                        s.label17.Text = s.arrc[i].ToString();
                        s.label16.Text = s.arrd[i].ToString();
                        s.label15.Text = s.arre[i].ToString();
                        s.label14.Text = s.arrh[i].ToString();
                        s.label13.Text = s.arrg[i].ToString();
                        s.label12.Text = s.arrf[i].ToString();
                    }
                
                
            }
            
                for (int i = 0; i < 120; i++)
                {
                    if (textBox1.Text == s.arrf[i])
                    {
                        s.label19.Text = s.arra[i].ToString();
                        s.label18.Text = (i + 1).ToString();
                        s.label17.Text = s.arrc[i].ToString();
                        s.label16.Text = s.arrd[i].ToString();
                        s.label15.Text = s.arre[i].ToString();
                        s.label14.Text = s.arrh[i].ToString();
                        s.label13.Text = s.arrg[i].ToString();
                        s.label12.Text = s.arrf[i].ToString();


                    }
                }
                if (textBox1.Text.ToString() == "")
                {
                    s.label19.Text = "-".ToString();
                    s.label18.Text = "-".ToString();
                    s.label17.Text = "-".ToString();
                    s.label16.Text = "-".ToString();
                    s.label15.Text = "-".ToString();
                    s.label14.Text = "-".ToString();
                    s.label13.Text = "-".ToString();
                    s.label12.Text = "-".ToString();
                }
            
        }
       
        private void search1_Load(object sender, EventArgs e)
        {
            
        }
        public int counter = 113;
        public void add_element_btn(object sender, EventArgs e)
        {
            add_element ae = this.add_element1;
            Search s = this.search1;
            s.arra[counter] = ae.tb1.Text;
            s.arrc[counter] = ae.tb3.Text;
            s.arrd[counter] = ae.tb4.Text;
            s.arre[counter] = ae.tb5.Text;
            s.arrh[counter] = ae.tb6.Text;
            s.arrg[counter] = ae.tb7.Text;
            s.arrf[counter] = ae.tb8.Text;
            counter++;
            ae.saved.Visible = true;




        }
        private void btn1(object sender, EventArgs e)
        {
            NewLineHandling b;
            Search s = this.search1;
            displayall ds = this.displayall1;
            for (int i = 0; i < 113; i++)
            {
                ds.textBox1.Text += s.arra[i].ToString();
                ds.textBox1.Text += Environment.NewLine;
                ds.textBox2.Text += (i + 1).ToString();
                ds.textBox2.Text += Environment.NewLine;
                ds.textBox3.Text += s.arrc[i].ToString();
                ds.textBox3.Text += Environment.NewLine;
                ds.textBox4.Text += s.arrd[i].ToString();
                ds.textBox4.Text += Environment.NewLine;
                ds.textBox5.Text += s.arre[i].ToString();
                ds.textBox5.Text += Environment.NewLine;
                ds.textBox6.Text += s.arrh[i].ToString();
                ds.textBox6.Text += Environment.NewLine;
                ds.textBox7.Text += s.arrg[i].ToString();
                ds.textBox7.Text += Environment.NewLine;
                ds.textBox8.Text += s.arrf[i].ToString();
                ds.textBox8.Text += Environment.NewLine;


            }
                    }

    }

}

