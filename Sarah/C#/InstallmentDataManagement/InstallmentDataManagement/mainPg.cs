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
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
// mp.hpbtn1.Click += new System.EventHandler(this.show);
//mp.button2.Click += new System.EventHandler(this.button2_Click);
namespace FazleRabbi
{
    public partial class mainPg : Form
    {
        
        string PrdctNm, PrdctCmpny, PrdctCtgry;
        int cus_count = 0;
        int sp_count = 0;
        int oa_count = 0;
        int bk_count = 0;
        int br_count = 0;
        int stk_count = 0;
        int ProPur_Count;
        int delmoninst_count;
        public Image file=null;
        SqlDataReader dbr;
        string query_allCusRec;
        byte[] arr;
        string bkquery;
        SqlConnection conect = new SqlConnection("Data Source = localhost; Initial Catalog = RACIA; Integrated Security = True");
        public mainPg()
        {
            InitializeComponent();
            this.events();
            

        }
        public void events()
        {
                 
            //main section//
            customerPanel1.panel2.Top = customerPanel1.button3.Top;
            stockPanel1.panel2.Top = stockPanel1.button3.Top;
            salesPanel1.panel1.Top = salesPanel1.button3.Top;
            ownerPanel1.panel2.Top = ownerPanel1.button4.Top;
            bikeregPanel1.panel2.Top = bikeregPanel1.button4.Top;
            panel2.BackColor = ColorTranslator.FromHtml("#5D8097");
            //main section//
            //Customer Section//
            
            customerPanel1.button3.Click += new System.EventHandler(this.CP_button3);
            customerPanel1.button4.Click += new System.EventHandler(this.CP_button4);
            customerPanel1.button5.Click += new System.EventHandler(this.CP_button5);
            customerPanel1.button6.Click += new System.EventHandler(this.CP_button6);
            //New added Controls//
            customerPanel1.button1.Click += new System.EventHandler(this.CP_button1);
            customerPanel1.button2.Click += new System.EventHandler(this.CP_button2);
            customerPanel1.button7.Click += new System.EventHandler(this.CP_button7);
            //customerPanel1.button8.Click += new System.EventHandler(this.CP_button8);
            delCusRec1.button1.Click += new System.EventHandler(this.delCusRec_btn1);
            delCusRec1.button2.Click += new System.EventHandler(this.delCusRec_btn2);
            //New Added Controls//
            customerReg1.comboBox1.SelectedIndexChanged += new System.EventHandler(this.CusReg1cmb1_SelectedIndexChanged);
            customerReg1.bunifuThinButton22.Click += new System.EventHandler(this.CR_NextBtn);
            customerReg21.bunifuThinButton23.Click += new System.EventHandler(this.CR2_BackBtn);
            customerReg1.label25.Click += new System.EventHandler(this.upload_img_ctrl);
            customerReg1.pictureBox1.Click += new System.EventHandler(this.upload_img_ctrl);
            customerReg1.panel3.Click += new System.EventHandler(this.upload_img_ctrl);
            customerReg1.btncancel.Click += new System.EventHandler(this.CR_CancelBtn);
            customerReg1.txtb8.OnValueChanged += new System.EventHandler(this.blncCusRec_txtchanged);
            customerReg1.txtb12.OnValueChanged += new System.EventHandler(this.discount_cusregtxtchanged);
            customerReg21.savebtn.Click += new System.EventHandler(this.CR2_SaveBtn);
            customerReg21.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            customerReg21.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            customerRecord1.comboBox1.TextChanged += new System.EventHandler(this.CusRec_cmb1_textchanged);
            /*Monthly installment*/
            monthlyInstallment1.txtb1.OnValueChanged += new System.EventHandler(this.MonInst_txtb1_textchanged);
            monthlyInstallment1.MonInstSave.Click += new System.EventHandler(this.MonInst_Savebtn);
            delMonInstallRec1.txtb1.OnValueChanged += new System.EventHandler(this.DelMonInst_txtb1_textchanged);
            delMonInstallRec1.delbtn.Click += new System.EventHandler(this.DelMonInst_Deletebtn);
            /*Monthly installment*/
            /*Customer REcord Section*/
            customerRecord1.txtb1.OnValueChanged += new System.EventHandler(this.CusRec_txtb1_textchanged);
            /*Customer Record Section*/
            /*All Customer Record Section*/
            allCustomerRec1.cmb1.Text = "Month";
            AllCusRec_Fun();
            allCustomerRec1.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            allCustomerRec1.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            /*All Customer Record Section*/
            /*Delete Customer ALL Record Section*/
            delCusAllRec1.txtb1.OnValueChanged += new System.EventHandler(this.DelCusAllRec_txtb1_textchanged);
            delCusAllRec1.DelCusAllRecbtn.Click += new System.EventHandler(this.DelCusAllRec_Delbtn);
            /*Delete Customer All Record Section*/
            /*cUstomer Sponerial Detail Section*/
            cusSponRec1.txtb1.TextChanged += new System.EventHandler(this.SponRecDis_txtchanged);
            /*cUstomer Sponerial Detail Section*/
            //Customer Section//
            //Stock Section//
            //stockPanel1.button1.Click += new System.EventHandler(this.Stk_button1);
            stockPanel1.button3.Click += new System.EventHandler(this.Stk_button3);
            //newPro1.savebtn.Click += new System.EventHandler(this.NewPro_savebtn);
            Stock_DGV1();
            stockRec1.dateTimePicker1.Click += new System.EventHandler(this.StockDateTimeP_ValueChanged);
            //Stock Section//
            //Sales and Purchase Section//
            salesPanel1.button1.Click += new System.EventHandler(this.SP_button1);
            salesPanel1.button4.Click += new System.EventHandler(this.SP_button4);
            salesPanel1.button5.Click += new System.EventHandler(this.SP_button5);
            salesPanel1.button6.Click += new System.EventHandler(this.SP_button6);
            salesPanel1.button2.Click += new System.EventHandler(this.SP_button2);
            salesPanel1.button7.Click += new System.EventHandler(this.SP_button7);
            purchaseRec1.btn1.Click += new System.EventHandler(this.PurRec_Plusbtn);
            proPur1.button1.Click += new System.EventHandler(this.ProPur_Addnew);
            proPur1.button2.Click += new System.EventHandler(this.ProPur_finish);
            ProPur_DGV1();
            purchaseRec1.dateTimePicker2.ValueChanged += new System.EventHandler(this.ProPurDateTimeP_ValueChanged);
            purchaseRec1.txtb4.OnValueChanged += new System.EventHandler(this.ProPurbillTxtb_valchng);
            expenses1.ExpnsSavebtn.Click += new System.EventHandler(this.ExpensesRec_Fun);
            ExpenseDataDisplay();
            expenses1.dateTimePicker2.ValueChanged += new System.EventHandler(this.ExpenseDataGrid);
            ExpenditureDataDisplay();
            dailyExpenditure1.dateTimePicker1.ValueChanged += new System.EventHandler(this.ExpenditureDataGrid);
            DailySales_DGV1();
            DailyEpenditure();
            dailyExpenditure1.dateTimePicker1.ValueChanged += new System.EventHandler(this.ExpenditureCal);
            Sales_DGV1();
            salesRec1.dateTimePicker1.ValueChanged += new System.EventHandler(this.SalesrDateTimeP_ValueChanged);
            delProPurRec1.txtb1.OnValueChanged += new System.EventHandler(this.DelPurRec_billtxtchanged);
            delProPurRec1.dateTimePicker1.ValueChanged += new System.EventHandler(this.DelPurRec_billtxtchanged);
            delProPurRec1.delbtn.Click += new System.EventHandler(this.DelPurRec_delbtn);
            delExpsRec1.dateTimePicker1.ValueChanged += new System.EventHandler(this.DelExpenseDataGrid);
            delExpsRec1.delbtn.Click += new System.EventHandler(this.DelExpsRec_delbtn);
            //Sales and Purchase Section//
            //Owners Section//
            ownerPanel1.button4.Click += new System.EventHandler(this.OA_button4);
            ownerPanel1.button5.Click += new System.EventHandler(this.OA_button5);
            ownerPanel1.button1.Click += new System.EventHandler(this.OA_button1);
            debitAc1.debitsavebtn.Click += new System.EventHandler(this.debitSave_Fun);
            Debit_DGV1();
            debitAc1.dateTimePicker2.ValueChanged += new System.EventHandler(this.DebitDataGrid);
            Credit_DGV1();
            creditAc1.dateTimePicker1.ValueChanged += new System.EventHandler(this.CreditDateTimeP_ValueChanged);
            delDebRec1.dateTimePicker1.ValueChanged += new System.EventHandler(this.DelDebit_DGV1);
            delDebRec1.deldbtbtn.Click += new System.EventHandler(this.DelDebitRec_delbtn);
            //Owners Section//
            //Bike REgistration Section//
            bikeregPanel1.button4.Click += new System.EventHandler(this.BK_button4);
            bikeregPanel1.button5.Click += new System.EventHandler(this.BK_button5);
            bikeregPanel1.button1.Click += new System.EventHandler(this.BK_button1);
            bikeRegRec1.bkregsavebtn.Click += new System.EventHandler(this.Bkreg_Fun);
            BikeReg_DGV1();
            bikeRegRecDis1.dateTimePicker1.ValueChanged += new System.EventHandler(this.BikeRegDataGrid);
            delBikeRegRec1.txtb1.OnValueChanged += new System.EventHandler(this.DelBikeReg_DGV1);
            delBikeRegRec1.delbikeregbtn.Click += new System.EventHandler(this.DelBikeRegRec_delbtn);
            //Bike REgistration Section//
            //Backup and Resutore Section//
            backupPanel1.button4.Click += new System.EventHandler(this.BR_button4);
            backupPanel1.button5.Click += new System.EventHandler(this.BR_button5);
            backup1.backupbrowsebtn.Click += new System.EventHandler(this.browsebtn_backup);
            backup1.backupbtn.Click += new System.EventHandler(this.backupbtn_backup);
            restore1.browsebtn.Click += new System.EventHandler(this.browsebtn_restore);
            restore1.restorebtn.Click += new System.EventHandler(this.restorebtn_restore);
             
            //Backup and Resutore Section//
            //check and balancing//
            this.SetMaximumLength(customerReg1.txtb4, 15); 
            this.SetMaximumLength(customerReg21.txtb5, 15);
            this.SetMaximumLength(customerReg21.txtb9, 15);
            customerReg1.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOwnerName_KeyPress);
            customerReg1.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOwnerName_KeyPress);
            customerReg21.txtb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOwnerName_KeyPress);
            customerReg21.txtb8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOwnerName_KeyPress);
            purchaseRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOwnerName_KeyPress);
            bikeRegRec1.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOwnerName_KeyPress);
            customerReg1.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg1.txtb5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg1.txtb7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg1.txtb8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg1.txtb9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg21.txtb7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg21.txtb11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerRecord1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            cusSponRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delCusAllRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            monthlyInstallment1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            monthlyInstallment1.txtb8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            monthlyInstallment1.txtb9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delMonInstallRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delMonInstallRec1.txtb8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delMonInstallRec1.txtb9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            purchaseRec1.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            proPur1.comboBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            purchaseRec1.txtb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            purchaseRec1.txtb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delProPurRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            expenses1.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delExpsRec1.txtb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            debitAc1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delDebRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            bikeRegRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            bikeRegRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            delBikeRegRec1.txtb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            customerReg1.txtb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SymbolNumbersOnly_KeyPress);
            //check and balancing//
        }
        //Referesh Database//
        private void refreshbtn_Click(object sender, EventArgs e)
        {
            generl_combobox();
            AllCusRec_Fun();
            Stock_DGV1();
            ProPur_DGV1();
            Sales_DGV1();
            ExpenseDataDisplay();
            ExpenditureDataDisplay();
            DailySales_DGV1();
            DailyEpenditure();
            Debit_DGV1();
            BikeReg_DGV1();
            Credit_DGV1();
            DailyExpndPur_DGV1();
        }
        
        //Referesh Database//
        //Check and Balancing//
        private void SetMaximumLength(Bunifu.Framework.UI.BunifuMetroTextbox metroTextbox, int maximumLength)
        {
            foreach (Control ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;

                    // Set other properties & events here...
                }
            }
        }
        private void tbOwnerName_KeyPress(object sender, KeyPressEventArgs e)
        {

            //===================to accept only charactrs & space/backspace=============================================

            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter characters only");
            }
        }
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {

            //===================to accept only charactrs & space/backspace=============================================

            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter only Numbers");
            }
        }
        private void SymbolNumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {

            //===================to accept only charactrs & space/backspace=============================================

            if (e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsPunctuation(e.KeyChar)))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter only Numbers and Dash '-' ");
            }
        }
        //Check and Balancing//
        private void mainPg_Load(object sender, EventArgs e)
        {
            generl_combobox();
           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
/// <summary>
/// Basic Application Controls Coding Start from here
/// </summary>

        // Top bar Menu Buttons//
        public void hpbtn2_Click(object sender, EventArgs e)
        {

            customerPanel1.BringToFront();
            if (cus_count == 0)
            {
                customerReg1.BringToFront();
            }
            if (cus_count == 1)
            {
                monthlyInstallment1.BringToFront();
            }
            if (cus_count == 2)
            {
                customerRecord1.BringToFront();
            }
            if (cus_count == 3)
            {
                allCustomerRec1.BringToFront();
            }
            if (cus_count == 4)
            {
                customerReg21.BringToFront();
                
            }
            if (cus_count == 5)
            {
                delCusRec1.button1.BackColor = Color.White;
                delCusRec1.BringToFront();
                delCusAllRec1.BringToFront();
               

            }
            if (cus_count == 6)
            {
                delCusRec1.button2.BackColor = Color.White;
                delCusRec1.BringToFront();
                delMonInstallRec1.BringToFront();

            }
            if (cus_count == 7)
            {
                cusSponRec1.BringToFront();

            }
            ///Require Changes
            if (cus_count == 8)
            {
                cusSponRec1.BringToFront();

            }
            //if (cus_count == 9)
            //{
            //    cusSponRec1.BringToFront();

            //}
            //Require Changes
            hpbtn2.BackColor = Color.SeaGreen;
            hpbtn3.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn4.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn5.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn6.BackColor = Color.FromArgb(210, 221, 226);

        }

        public void hpbtn3_Click(object sender, EventArgs e)
        {
            stockPanel1.BringToFront();
            if (stk_count == 0)
            {
                stockRec1.BringToFront();
            }
            //if (stk_count == 1)
            //{
            //   newPro1.BringToFront();
            //}
           
            hpbtn3.BackColor = Color.SeaGreen;
            hpbtn2.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn4.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn5.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn6.BackColor = Color.FromArgb(210, 221, 226);

        }

        public void hpbtn4_Click(object sender, EventArgs e)
        {
            salesPanel1.BringToFront();
            if (sp_count == 0)
            {
                purchaseRec1.BringToFront();
            }
            if (sp_count == 1)
            {
                salesRec1.BringToFront();
            }
            if (sp_count == 2)
            {
                expenses1.BringToFront();
            }
            if (sp_count == 3)
            {
                dailyExpenditure1.BringToFront();
            }
            if(sp_count==4)
            {
                delProPurRec1.BringToFront();
               }
            if(sp_count==5)
            {
                delExpsRec1.BringToFront();
            }
            
            hpbtn4.BackColor = Color.SeaGreen;
            hpbtn2.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn3.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn5.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn6.BackColor = Color.FromArgb(210, 221, 226);
        }

        public void hpbtn5_Click(object sender, EventArgs e)
        {
            ownerPanel1.BringToFront();
            if (oa_count == 0)
            {
                debitAc1.BringToFront();
            }
            if (oa_count == 1)
            {
                creditAc1.BringToFront();
            }
            if(oa_count==2)
            {
                delDebRec1.BringToFront();
            }
            hpbtn5.BackColor = Color.SeaGreen;
            hpbtn2.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn3.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn4.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn6.BackColor = Color.FromArgb(210, 221, 226);
        }

        public void hpbtn6_Click(object sender, EventArgs e)
        {
            bikeregPanel1.BringToFront();
           
            if (bk_count == 0)
            {
                bikeRegRec1.BringToFront();
            }
            if (bk_count == 1)
            {
                bikeRegRecDis1.BringToFront();
            }
            if (bk_count == 2)
            {
                delBikeRegRec1.BringToFront();
            }
            hpbtn6.BackColor = Color.SeaGreen;
            hpbtn2.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn3.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn4.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn5.BackColor = Color.FromArgb(210, 221, 226);
           
        }
        public void hpbtn7_Click(object sender, EventArgs e)
        {
            backupPanel1.BringToFront();
            if(br_count==0)
            {
                backup1.BringToFront();
            }
            if(br_count==1)
            {
                restore1.BringToFront();
            }
            hpbtn3.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn2.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn4.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn5.BackColor = Color.FromArgb(210, 221, 226);
            hpbtn6.BackColor = Color.FromArgb(210, 221, 226);

        }
        //Top menu Button//
        // Customerpanel Controls//
        public void CP_button3(object sender,EventArgs e)
        {
            customerPanel1.panel2.Top = customerPanel1.button3.Top;
            customerReg1.BringToFront();

        }
        public void CP_button4(object sender, EventArgs e)
        {
            customerPanel1.panel2.Top = customerPanel1.button4.Top;
            monthlyInstallment1.BringToFront();
            cus_count = 1;
        }
        public void CP_button5(object sender, EventArgs e)
        {
            customerPanel1.panel2.Top = customerPanel1.button5.Top;
            customerRecord1.BringToFront();
            cus_count = 2;
        }
        public void CP_button6(object sender, EventArgs e)
        {
            customerPanel1.panel2.Top = customerPanel1.button6.Top;
            allCustomerRec1.BringToFront();
            cus_count = 3;
        }
        public void CP_button1(object sender, EventArgs e)
        {
            delCusRec1.BringToFront();
            customerPanel1.panel2.Top = customerPanel1.button1.Top;
            
                delCusRec1.button1.BackColor = Color.White;

                delCusAllRec1.BringToFront();
                cus_count = 5;
            
            


        }
        public void CP_button2(object sender, EventArgs e)
        {
            customerPanel1.panel2.Top = customerPanel1.button2.Top;
            cusSponRec1.BringToFront();
            cus_count = 7;

        }
        public void CP_button7(object sender, EventArgs e)
        {
            customerPanel1.panel2.Top = customerPanel1.button7.Top;
            cusSponRec1.BringToFront();
            cus_count = 8;

        }
        //public void CP_button8(object sender, EventArgs e)
        //{
        //    customerPanel1.panel2.Top = customerPanel1.button8.Top;
        //    cusSponRec1.BringToFront();
        //    cus_count = 9;

        //}
        public void delCusRec_btn2(object sender,EventArgs e)
        {
            delCusRec1.button2.BackColor = Color.White;
            delCusRec1.button1.BackColor = ColorTranslator.FromHtml("#DDF311");
            delMonInstallRec1.BringToFront();
            cus_count = 6;
        }
        public void delCusRec_btn1(object sender, EventArgs e)
        {
            delCusRec1.button2.BackColor = ColorTranslator.FromHtml("#DDF311");
            delCusRec1.button1.BackColor = Color.White;
            delCusAllRec1.BringToFront();
            cus_count = 5;
        }
        // Customerpanel Controls//

        // CustomerRec Controls//
        public void CR_NextBtn(object sender, EventArgs e)
        {
            customerReg21.BringToFront();
            cus_count = 4;
        }
        public void CR_CancelBtn(object sender, EventArgs e)
        {
            customerReg1.textBox1.Text = "";
            customerReg1.txtb1.Text = "";
            customerReg1.txtb2.Text = "";
            customerReg1.txtb3.Text = "";
            customerReg1.txtb4.Text = "";
            customerReg1.txtb5.Text = "";
            customerReg1.txtb6.Text = "";
            customerReg1.txtb7.Text = "";
            customerReg1.txtb8.Text = "";
            customerReg1.txtb9.Text = "";
            customerReg1.txtb10.Text = "";
            file = null;
            customerReg1.label25.ForeColor = Color.Black;
            customerReg1.label25.Text = "Upload your image here";

        }
        public void CR2_BackBtn(object sender, EventArgs e)
        {
            customerReg1.BringToFront();
        }
        private bool CusRegRec_Rcptcnfrm()
        {
            string query1 = "select * from MonInstVar where RcptNo='" + customerReg1.txtb1.Text.Trim() + "'";
            conect.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, conect);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            if (dtbl1.Rows.Count == 1)
            {
                conect.Close();
                return false;


            }

            else
            {
                conect.Close();
                return true;

            }

        }

            private bool CusRegRec_cnfrm()
        {

            string query = "select * from CusPerInfo where AcNo='" + customerReg1.textBox1.Text.Trim() + "'";
            conect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                conect.Close();
                return false;


            }

            else
            {
                conect.Close();
                return true;

            }


        }

        private bool CashCusRegRec_cnfrm()
        {

            string query = "select * from CusPerInfo where ProRcptNo='" + customerReg1.txtb1.Text.Trim() + "'";
            conect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            conect.Close();
            string query1 = "select * from MonInstVar where RcptNo='" + customerReg1.txtb1.Text.Trim() + "'";
            conect.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, conect);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            if (dtbl.Rows.Count == 1|| dtbl1.Rows.Count == 1)
            {
                conect.Close();
                return false;


            }

            else
            {
                conect.Close();
                return true;

            }


        }
        public void CusReg1cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(customerReg1.comboBox1.Text=="Installment")
            {
                customerReg1.label3.Visible = true;
                customerReg1.textBox1.Visible = true;
                customerReg21.l7.Visible = true;
                customerReg21.l8.Visible = true;
                customerReg21.l9.Visible = true;
                customerReg21.l10.Visible = true;
                customerReg21.l11.Visible = true;
                customerReg21.l12.Visible = true;
                customerReg21.l13.Visible = true;
                customerReg21.l14.Visible = true;
                customerReg21.txtb4.Visible = true;
                customerReg21.txtb5.Visible = true;
                customerReg21.txtb6.Visible = true;
                customerReg21.txtb7.Visible = true;
                customerReg21.txtb8.Visible = true;
                customerReg21.txtb9.Visible = true;
                customerReg21.txtb10.Visible = true;
                customerReg21.txtb11.Visible = true;
                customerReg21.label23.Visible = true;
                customerReg21.label25.Visible = true;
                customerReg21.label26.Visible = true;
                customerReg1.l19.Text = "Advance";
                customerReg1.txtb9.Enabled = true;
                customerReg1.txtb9.BackColor = Color.White;
            }
           else
            {
                customerReg1.label3.Visible = false;
                customerReg1.textBox1.Visible = false;
                customerReg21.l7.Visible = false;
                customerReg21.l8.Visible = false;
                customerReg21.l9.Visible = false;
                customerReg21.l10.Visible = false;
                customerReg21.l11.Visible = false;
                customerReg21.l12.Visible = false;
                customerReg21.l13.Visible = false;
                customerReg21.l14.Visible = false;
                customerReg21.txtb4.Visible = false;
                customerReg21.txtb5.Visible = false;
                customerReg21.txtb6.Visible = false;
                customerReg21.txtb7.Visible = false;
                customerReg21.txtb8.Visible = false;
                customerReg21.txtb9.Visible = false;
                customerReg21.txtb10.Visible = false;
                customerReg21.txtb11.Visible = false;
                customerReg21.label23.Visible = false;
                customerReg21.label25.Visible = false;
                customerReg21.label26.Visible = false;
                customerReg1.l19.Text = "Recieved Amount";
                customerReg1.txtb9.Enabled = false;
                customerReg1.txtb9.BackColor = Color.DarkGray;

            }

        }
        public void discount_cusregtxtchanged(object sender,EventArgs e)
        {
            if(customerReg1.txtb11.Text!=""&&customerReg1.txtb12.Text!=string.Empty)
            {
                Int64 total = Int64.Parse(customerReg1.txtb11.Text.ToString()) - Int64.Parse(customerReg1.txtb12.Text.ToString());
                customerReg1.txtb7.Text = total.ToString();
                   
             }
            if(customerReg1.txtb12.Text==string.Empty)
            {
                customerReg1.txtb7.Text = string.Empty;
            }
        }
        public void CR_Installment()
        {

            Int64 rec;
            string query;
            Int64 blnc = 0;
            if (customerReg1.txtb12.Text == string.Empty)
            {
                customerReg1.txtb12.Text = 0.ToString();
                if(customerReg1.txtb11.Text=="")
                {
                    customerReg1.txtb11.Text = customerReg1.txtb7.Text;
                }
            }
            else
            {
                if(customerReg1.txtb11.Text == ""&&customerReg1.txtb7.Text!=string.Empty)
                {
                    Int64 reatailamnt= Int64.Parse(customerReg1.txtb7.Text.ToString()) + Int64.Parse(customerReg1.txtb12.Text.ToString());
                    customerReg1.txtb11.Text = reatailamnt.ToString();
                }
            }
            if (customerReg1.textBox1.Text != "" && customerReg1.txtb1.Text != "" && customerReg1.txtb2.Text != "" &&  customerReg1.txtb7.Text != "" && customerReg1.txtb8.Text != "" && customerReg1.txtb9.Text != "" && customerReg21.comboBox1.Text != "" && customerReg21.comboBox2.Text != "" && customerReg21.comboBox3.Text != "")
            {
                if (CusRegRec_cnfrm())
                {
                    if (CusRegRec_Rcptcnfrm())
                    {
                        if (Int64.TryParse(customerReg1.txtb10.Text, out rec))
                        {
                            blnc = rec;
                        }

                        //Personal Information Entering//


                        conect.Open();
                        if (file != null)
                        {
                            Image img = file;
                            ImageConverter converter = new ImageConverter();

                            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                            query = "insert into CusPerInfo values('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg1.txtb6.Text.Trim() + "',@photo,'" + customerReg1.txtb2.Text.Trim() + "','" + customerReg1.txtb3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb4.Text.Trim() + "','" + customerReg1.txtb5.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                    "insert into MonInstStat values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg1.txtb7.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "','" + customerReg1.txtb9.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb11.Text.Trim() + "','" + customerReg1.txtb12.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                    "insert into MonInstVar values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "','" + customerReg1.txtb10.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');" +
                                    "insert into Spon1 values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.txtb4.Text.Trim() + "','" + customerReg21.txtb5.Text.Trim() + "','" + customerReg21.txtb7.Text.Trim() + "','" + customerReg21.txtb6.Text.Trim() + "');" +
                                    "insert into Spon2 values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.txtb8.Text.Trim() + "','" + customerReg21.txtb9.Text.Trim() + "','" + customerReg21.txtb11.Text.Trim() + "','" + customerReg21.txtb10.Text.Trim() + "');" +
                                    "insert into ProSolBas  values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + 1 + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                    "Insert into NewPro values ('" + 0 + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + -1 + "');";
                            SqlCommand cmd = new SqlCommand(query, conect);
                            cmd.Parameters.AddWithValue("@photo", arr);
                            dbr = cmd.ExecuteReader();

                        }
                        else
                        {
                            query = "insert into CusPerInfo values('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg1.txtb6.Text.Trim() + "',null,'" + customerReg1.txtb2.Text.Trim() + "','" + customerReg1.txtb3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb4.Text.Trim() + "','" + customerReg1.txtb5.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                    "insert into MonInstStat values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg1.txtb7.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "','" + customerReg1.txtb9.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb11.Text.Trim() + "','" + customerReg1.txtb12.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                    "insert into MonInstVar values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "','" + customerReg1.txtb10.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');" +
                                    "insert into Spon1 values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.txtb4.Text.Trim() + "','" + customerReg21.txtb5.Text.Trim() + "','" + customerReg21.txtb7.Text.Trim() + "','" + customerReg21.txtb6.Text.Trim() + "');" +
                                    "insert into Spon2 values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.txtb8.Text.Trim() + "','" + customerReg21.txtb9.Text.Trim() + "','" + customerReg21.txtb11.Text.Trim() + "','" + customerReg21.txtb10.Text.Trim() + "');" +
                                    "insert into ProSolBas  values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + 1 + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                    "Insert into NewPro values ('" + 0 + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + -1 + "');";
                            SqlCommand cmd = new SqlCommand(query, conect);

                            dbr = cmd.ExecuteReader();
                        }




                        MessageBox.Show("Customer Registered Succesfully!");
                        while (dbr.Read())

                        {

                        }







                        conect.Close();
                        if (customerReg21.comboBox1.Text == "Bike".ToString())
                        {
                            conect.Open();
                            string query1 = "insert into ProSolBik  values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.txtb1.Text.Trim() + "','" + customerReg21.txtb2.Text.Trim() + "','" + customerReg21.txtb3.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');";
                            SqlCommand cmd1 = new SqlCommand(query1, conect);
                            cmd1.ExecuteNonQuery();
                            conect.Close();
                            customerReg21.txtb1.Text = "";
                            customerReg21.txtb2.Text = "";
                            customerReg21.txtb3.Text = "";

                        }
                        if (blnc == 0)
                        {
                            conect.Open();
                            string query1 = "insert into Sales (DateofSl,RcptNo,CshInst,CusNm,PrdctNm,PrdctCmpny,PrdctCtgry,amnt) values ('" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + " ','Cash','" + customerReg1.txtb2.Text.Trim() + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');";
                            SqlCommand cmd1 = new SqlCommand(query1, conect);
                            cmd1.ExecuteNonQuery();
                            conect.Close();
                        }
                        else
                        {
                            conect.Open();
                            string query1 = "insert into Sales (DateofSl,RcptNo,CshInst,CusNm,PrdctNm,PrdctCmpny,PrdctCtgry,amnt)  values ('" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + " ','Installment','" + customerReg1.txtb2.Text.Trim() + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');";
                            SqlCommand cmd1 = new SqlCommand(query1, conect);
                            cmd1.ExecuteNonQuery();
                            conect.Close();
                        }
                        customerReg1.textBox1.Text = "";
                        customerReg1.txtb1.Text = "";
                        customerReg1.txtb2.Text = "";
                        customerReg1.txtb3.Text = "";
                        customerReg1.txtb4.Text = "";
                        customerReg1.txtb5.Text = "";
                        customerReg1.txtb6.Text = "";
                        customerReg1.txtb7.Text = "";
                        customerReg1.txtb8.Text = "";
                        customerReg1.txtb9.Text = "";
                        customerReg21.comboBox1.Text = "";
                        customerReg21.comboBox2.Text = "";
                        customerReg21.comboBox3.Text = "";
                        customerReg21.txtb4.Text = "";
                        customerReg21.txtb5.Text = "";
                        customerReg21.txtb6.Text = "";
                        customerReg21.txtb7.Text = "";
                        customerReg21.txtb8.Text = "";
                        customerReg21.txtb9.Text = "";
                        customerReg21.txtb10.Text = "";
                        customerReg21.txtb11.Text = "";
                        customerReg1.txtb11.Text = "";
                        customerReg1.txtb12.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Reciept has Already been used....!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("There is Already a Customer Registered with this account","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Completely fill the form!");
            }

            //SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{




            //}

            //else
            //{
            //    MessageBox.Show("Username or Password Incorrect!");
            //}
        }
        public void CR_Cash()
        {

            Int64 rec;
            string query;
            Int64 blnc = 0;
            if (customerReg1.txtb12.Text == string.Empty)
            {
                customerReg1.txtb12.Text = 0.ToString();
                if (customerReg1.txtb11.Text == "")
                {
                    customerReg1.txtb11.Text = customerReg1.txtb7.Text;
                }
            }
            else
            {
                if (customerReg1.txtb11.Text == "" && customerReg1.txtb7.Text != string.Empty)
                {
                    Int64 reatailamnt = Int64.Parse(customerReg1.txtb7.Text.ToString()) + Int64.Parse(customerReg1.txtb12.Text.ToString());
                    customerReg1.txtb11.Text = reatailamnt.ToString();
                }
            }
            if (customerReg1.txtb12.Text!="" &&customerReg1.txtb1.Text != "" && customerReg1.txtb2.Text != "" && customerReg1.txtb7.Text != "" && customerReg1.txtb8.Text != "" && customerReg21.comboBox1.Text != "" && customerReg21.comboBox2.Text != "" && customerReg21.comboBox3.Text != "")
            {
                if (CashCusRegRec_cnfrm())
                {
                    if (Int64.TryParse(customerReg1.txtb10.Text, out rec))
                    {
                        blnc = rec;
                    }

                    //Personal Information Entering//

                   
                    conect.Open();
                    if (file != null)
                    {
                        Image img = file;
                        ImageConverter converter = new ImageConverter();

                        arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                        query = "insert into CusPerInfo values(null,'"  + customerReg1.txtb6.Text.Trim() + "',@photo,'" + customerReg1.txtb2.Text.Trim() + "','" + customerReg1.txtb3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb4.Text.Trim() + "','" + customerReg1.txtb5.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                "insert into MonInstStat values (null,'" + customerReg1.txtb7.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "','" + 0.ToString().Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb11.Text.Trim() + "','" + customerReg1.txtb12.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                "insert into MonInstVar values (null,'" + customerReg1.txtb1.Text.Trim() + "','" + customerReg1.txtb10.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');" +
                                "insert into ProSolBas  values (null,'" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + 1 + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                "Insert into NewPro values ('" + 0 + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + -1 + "');";
                        SqlCommand cmd = new SqlCommand(query, conect);
                        cmd.Parameters.AddWithValue("@photo", arr);
                        dbr = cmd.ExecuteReader();

                    }
                    else
                    {
                        query = "insert into CusPerInfo values(null,'" + customerReg1.txtb6.Text.Trim() + "',null,'" + customerReg1.txtb2.Text.Trim() + "','" + customerReg1.txtb3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb4.Text.Trim() + "','" + customerReg1.txtb5.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                "insert into MonInstStat values (null,'" + customerReg1.txtb7.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "','" + 0.ToString().Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb11.Text.Trim() + "','" + customerReg1.txtb12.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                "insert into MonInstVar values (null,'" + customerReg1.txtb1.Text.Trim() + "','" + customerReg1.txtb10.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');" +
                                "insert into ProSolBas  values (null,'" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.dateTimePicker1.Text.Trim() + "','" + 1 + "','" + customerReg1.txtb1.Text.Trim() + "');" +
                                "Insert into NewPro values ('" + 0 + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + -1 + "');";
                        SqlCommand cmd = new SqlCommand(query, conect);

                        dbr = cmd.ExecuteReader();
                    }




                    MessageBox.Show("Customer Registered Succesfully!");
                    while (dbr.Read())

                    {

                    }







                    conect.Close();
                    if (customerReg21.comboBox1.Text == "Bike".ToString())
                    {
                        conect.Open();
                        string query1 = "insert into ProSolBik  values ('" + customerReg1.textBox1.Text.Trim() + "','" + customerReg21.txtb1.Text.Trim() + "','" + customerReg21.txtb2.Text.Trim() + "','" + customerReg21.txtb3.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + "');";
                        SqlCommand cmd1 = new SqlCommand(query1, conect);
                        cmd1.ExecuteNonQuery();
                        conect.Close();
                        customerReg21.txtb1.Text = "";
                        customerReg21.txtb2.Text = "";
                        customerReg21.txtb3.Text = "";
                        conect.Close();

                    }
                    if (blnc == 0)
                    {
                        conect.Open();
                        string query1 = "insert into Sales (DateofSl,RcptNo,CshInst,CusNm,PrdctNm,PrdctCmpny,PrdctCtgry,amnt) values ('" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + " ','Cash','" + customerReg1.txtb2.Text.Trim() + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');";
                        SqlCommand cmd1 = new SqlCommand(query1, conect);
                        cmd1.ExecuteNonQuery();
                        conect.Close();
                    }
                    else
                    {
                        conect.Open();
                        string query1 = "insert into Sales (DateofSl,RcptNo,CshInst,CusNm,PrdctNm,PrdctCmpny,PrdctCtgry,amnt)  values ('" + customerReg1.dateTimePicker1.Text.Trim() + "','" + customerReg1.txtb1.Text.Trim() + " ','Installment','" + customerReg1.txtb2.Text.Trim() + "','" + customerReg21.comboBox1.Text.Trim() + "','" + customerReg21.comboBox2.Text.Trim() + "','" + customerReg21.comboBox3.Text.Trim() + "','" + customerReg1.txtb8.Text.Trim() + "');";
                        SqlCommand cmd1 = new SqlCommand(query1, conect);
                        cmd1.ExecuteNonQuery();
                        conect.Close();
                    }
                    customerReg1.textBox1.Text = "";
                    customerReg1.txtb1.Text = "";
                    customerReg1.txtb2.Text = "";
                    customerReg1.txtb3.Text = "";
                    customerReg1.txtb4.Text = "";
                    customerReg1.txtb5.Text = "";
                    customerReg1.txtb6.Text = "";
                    customerReg1.txtb7.Text = "";
                    customerReg1.txtb8.Text = "";
                    customerReg1.txtb9.Text = "";
                    customerReg21.comboBox1.Text = "";
                    customerReg21.comboBox2.Text = "";
                    customerReg21.comboBox3.Text = "";
                    customerReg21.txtb4.Text = "";
                    customerReg21.txtb5.Text = "";
                    customerReg21.txtb6.Text = "";
                    customerReg21.txtb7.Text = "";
                    customerReg21.txtb8.Text = "";
                    customerReg21.txtb9.Text = "";
                    customerReg21.txtb10.Text = "";
                    customerReg21.txtb11.Text = "";
                    customerReg1.txtb11.Text = "";
                    customerReg1.txtb12.Text = "";


                }
                else
                {
                    MessageBox.Show("This Reciept has already been used___!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Completely fill the form!","Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            //DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
            //if (dtbl.Rows.Count == 1)
            //{




            //}

            //else
            //{
            //    MessageBox.Show("Username or Password Incorrect!");
            //}
        }
        public void CR2_SaveBtn(object sender, EventArgs e)
        {
            if(customerReg1.comboBox1.Text=="Installment")
            {
                CR_Installment();
            }
            else if(customerReg1.comboBox1.Text=="Cash")
            {
                CR_Cash();
            }
        }
        //Sales and Purchase Panel Controls  //
        public void SP_button1(object sender, EventArgs e)
        {
            salesPanel1.panel1.Top = salesPanel1.button1.Top;
            purchaseRec1.BringToFront();
            sp_count = 0;

        }
        public void SP_button4(object sender, EventArgs e)
        {
            salesPanel1.panel1.Top = salesPanel1.button4.Top;
            salesRec1.BringToFront();
            sp_count = 1;
        }
        public void SP_button5(object sender, EventArgs e)
        {
            salesPanel1.panel1.Top = salesPanel1.button5.Top;
            expenses1.BringToFront();
            sp_count = 2;
        }
        public void SP_button6(object sender, EventArgs e)
        {
            salesPanel1.panel1.Top = salesPanel1.button6.Top;
            dailyExpenditure1.BringToFront();
            sp_count = 3;
        }
        public void SP_button2(object sender, EventArgs e)
        {
            salesPanel1.panel1.Top = salesPanel1.button2.Top;
            delProPurRec1.BringToFront();
            sp_count = 4;

        }
        public void SP_button7(object sender, EventArgs e)
        {
            salesPanel1.panel1.Top = salesPanel1.button7.Top;
            delExpsRec1.BringToFront();
            sp_count = 5;

        }
        //Sales and Purchase Panel Controls  //
        //Owners Panel Controls//
        public void OA_button4(object sender, EventArgs e)
        {
            ownerPanel1.panel2.Top = ownerPanel1.button4.Top;
            debitAc1.BringToFront();
            oa_count = 0;
        }
        public void OA_button5(object sender, EventArgs e)
        {
            ownerPanel1.panel2.Top = ownerPanel1.button5.Top;
            creditAc1.BringToFront();
            oa_count = 1;
        }
        public void OA_button1(object sender, EventArgs e)
        {
            ownerPanel1.panel2.Top = ownerPanel1.button1.Top;
            delDebRec1.BringToFront();
            oa_count = 2;
        }
        //Owners Panel Controls//
        //Stock & Product Section//
        public void Stk_button3(object sender, EventArgs e)
        {
            stockPanel1.panel2.Top = stockPanel1.button3.Top;
            stockRec1.BringToFront();
            stk_count = 0;

        }
        public void Stk_button1(object sender, EventArgs e)
        {
            //stockPanel1.panel2.Top = stockPanel1.button1.Top;
            //newPro1.BringToFront();
            //stk_count = 1;
        }
        //Stock & Product Section//
        //Bike Regisration Section//
        public void BK_button4(object sender, EventArgs e)
        {
            bikeregPanel1.panel2.Top = bikeregPanel1.button4.Top;
            bikeRegRec1.BringToFront();
            bk_count = 0;
        }
        public void BK_button5(object sender, EventArgs e)
        {
            bikeregPanel1.panel2.Top =bikeregPanel1.button5.Top;
            bikeRegRecDis1.BringToFront();
            bk_count = 1;
        }
        public void BK_button1(object sender, EventArgs e)
        {
            bikeregPanel1.panel2.Top = bikeregPanel1.button1.Top;
            delBikeRegRec1.BringToFront();
            bk_count = 2;
        }
        //Bike Registration Section//
        //Backup & Restore Section//
        public void BR_button4(object sender, EventArgs e)
        {
            backupPanel1.panel2.Top = backupPanel1.button4.Top;
            backup1.BringToFront();
            br_count = 0;
        }
        public void BR_button5(object sender, EventArgs e)
        {
            backupPanel1.panel2.Top = backupPanel1.button5.Top;
            restore1.BringToFront();
            br_count = 1;
        }

        
        //Backup & Restore Section//
        /// <summary>
        /// Basic Application Controls Coding ends here
        /// </summary>
        /// 
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Controls of Users Controls or ACtual Coding Starts here
        /// </summary>
        //Customer Registration Section//
        public void upload_img_ctrl(object sender,EventArgs e )
        {

           
                OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG|*JPG;*.jpg;*.jpeg|PNG|*.PNG;*.png";
            if(f.ShowDialog()==DialogResult.OK)
            {
               
                    file = Image.FromFile(f.FileName);


                }
            
            if(file!=null)
            {
                customerReg1.label25.ForeColor = Color.Red;
                customerReg1.label25.Text = "Uploaded!";
            }
            if(file==null)
            {
                customerReg1.label25.ForeColor = Color.Black;
                customerReg1.label25.Text = "Upload your image here";
            }
        }
        public void generl_combobox()
        {
            customerReg21.comboBox1.Items.Clear();
            customerReg21.comboBox2.Items.Clear();
            customerReg21.comboBox3.Items.Clear();
            conect.Open();
            //Combobox1//
            string query = "Select Distinct(PrdctNm) from NewPro where Quantity > 0";
            SqlCommand cmd = new SqlCommand(query, conect);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                customerReg21.comboBox1.Items.Add(dr["PrdctNm"].ToString());


            }
            conect.Close();
            //Combobox1//
        }
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerReg21.comboBox2.Items.Clear();
            customerReg21.comboBox3.Items.Clear();
            //Combobox2// 
            conect.Open();
            string query1 = "Select Distinct(PrdctCmpny) from NewPro where PrdctNm='" + customerReg21.comboBox1.Text + "';";
            SqlCommand cmd1 = new SqlCommand(query1, conect);
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                customerReg21.comboBox2.Items.Add(dr1["PrdctCmpny"].ToString());

            }
            conect.Close();
            if(customerReg21.comboBox1.Text=="Bike".ToString())
            {
                customerReg21.label11.Visible = true;
                customerReg21.l4.Visible = true;
                customerReg21.label13.Visible = true;
                customerReg21.l5.Visible = true;
                customerReg21.label15.Visible = true;
                customerReg21.l6.Visible = true;
                customerReg21.txtb1.Visible = true;
                customerReg21.txtb2.Visible = true;
                customerReg21.txtb3.Visible = true;
            }
            else
            {
                customerReg21.label11.Visible = false;
                customerReg21.l4.Visible = false;
                customerReg21.label13.Visible = false;
                customerReg21.l5.Visible = false;
                customerReg21.label15.Visible = false;
                customerReg21.l6.Visible = false;
                customerReg21.txtb1.Visible = false;
                customerReg21.txtb2.Visible = false;
                customerReg21.txtb3.Visible = false;
            }
            //Combobox2//
           
        }
        public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerReg21.comboBox3.Items.Clear();
            //Combobox3//
            conect.Open();
            string query2 = "Select Distinct(PrdctCtgry) from NewPro where PrdctNm='" + customerReg21.comboBox1.Text + "'and PrdctCmpny ='" + customerReg21.comboBox2.Text + "';";
            SqlCommand cmd2 = new SqlCommand(query2, conect);
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                customerReg21.comboBox3.Items.Add(dr2["PrdctCtgry"].ToString());


            }
            conect.Close();
            //Combobox3//
        }
        private void blncCusRec_txtchanged(object sender,EventArgs e)
        {
            if (customerReg1.txtb7.Text != "" && customerReg1.txtb8.Text != "")
            { 
                Int64 blnc = Int64.Parse(customerReg1.txtb7.Text.ToString()) - Int64.Parse(customerReg1.txtb8.Text.ToString());
                customerReg1.txtb10.Text = blnc.ToString();
            }
            if(customerReg1.txtb8.Text==string.Empty)
            {
                customerReg1.txtb10.Text = string.Empty;
            }
        }
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //Customer Registration Section//
        //Monthly Installment Section//
        public void MonInst_txtb1_textchanged(object sender, EventArgs e)
        {
            monthlyInstallment1.txtb2.Text = "";
            monthlyInstallment1.txtb3.Text = "";
            monthlyInstallment1.txtb5.Text = "";
            monthlyInstallment1.txtb6.Text = "";
            monthlyInstallment1.txtb7.Text ="";
            monthlyInstallment1.txtb4.Text = "";
            conect.Open();
            string query, query1;
            query = "select Appnm,fathnm,cnic,address,phoneno from CusPerInfo where AcNo='" + monthlyInstallment1.txtb1.Text.Trim() + "';";
            query1 = "select nm from Spon1 where AcNo='"+monthlyInstallment1.txtb1.Text.Trim()+"';";
            SqlCommand cmd4 = new SqlCommand(query, conect);
            SqlDataReader data1 = cmd4.ExecuteReader();
            while(data1.Read())
            {

               monthlyInstallment1.txtb2.Text = data1.GetValue(0).ToString();
               monthlyInstallment1.txtb3.Text = data1.GetValue(1).ToString();
                monthlyInstallment1.txtb5.Text = data1.GetValue(2).ToString();
               monthlyInstallment1.txtb6.Text = data1.GetValue(3).ToString();
                monthlyInstallment1.txtb7.Text = data1.GetValue(4).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd5 = new SqlCommand(query1, conect);
            SqlDataReader data2 = cmd5.ExecuteReader();

            while(data2.Read())
            {
                monthlyInstallment1.txtb4.Text = data2.GetValue(0).ToString();
            }
            conect.Close();


        }
        private bool MonInst_cnfrm()
        {

           
            string query1 = "select * from MonInstVar where RcptNo='" + monthlyInstallment1.txtb8.Text.Trim() + "'";
            conect.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter(query1, conect);
            DataTable dtbl1 = new DataTable();
            sda1.Fill(dtbl1);
            if ( dtbl1.Rows.Count == 1)
            {
                conect.Close();
                return false;


            }

            else
            {
                conect.Close();
                return true;

            }


        }
        public void MonInst_Savebtn(object sender, EventArgs e)
        {
            Int64 balance=0, amntrec=0,blnc,amnt;

            if (monthlyInstallment1.txtb9.Text != string.Empty && monthlyInstallment1.txtb8.Text != string.Empty&&monthlyInstallment1.txtb1.Text!=string.Empty&&monthlyInstallment1.txtb2.Text!=string.Empty)
            {
                if (MonInst_cnfrm())
                {
                    if (Int64.TryParse(monthlyInstallment1.txtb9.Text, out amnt))
                    {
                        amntrec = amnt;
                    }
                    try
                    {
                        conect.Open();
                        string query;
                        query = "select Min(blnc) as Minimum from MonInstVar where AcNo='" + monthlyInstallment1.txtb1.Text.Trim() + "';";
                        SqlCommand cmd1 = new SqlCommand(query, conect);
                        SqlDataReader data1 = cmd1.ExecuteReader();

                        while (data1.Read())
                        {

                            if (Int64.TryParse(data1["Minimum"].ToString(), out blnc))
                            {
                                balance = blnc;
                            }

                        }
                        conect.Close();
                        balance = balance - amntrec;
                        string query2;
                        query2 = "insert into MonInstVar values ('" + monthlyInstallment1.txtb1.Text.Trim() + "','" + monthlyInstallment1.txtb8.Text.Trim() + "','" + balance + "','" + monthlyInstallment1.dateTimePicker1.Text.Trim() + "','" + monthlyInstallment1.txtb9.Text.Trim() + "');";
                        conect.Open();
                        SqlCommand cmd2 = new SqlCommand(query2, conect);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Saved Succesfully!");
                    }
                    catch

                    {

                        MessageBox.Show("Error!");

                    }

                    conect.Close();

                    conect.Open();
                    string queryuni = "select PrdctNm,PrdctCmpny,PrdctCtgry from ProSolBas where AcNo='" + monthlyInstallment1.txtb1.Text.Trim() + "';";
                    SqlCommand cmd5 = new SqlCommand(queryuni, conect);
                    SqlDataReader data2 = cmd5.ExecuteReader();

                    while (data2.Read())
                    {
                        PrdctNm = data2.GetValue(0).ToString();
                        PrdctCmpny = data2.GetValue(1).ToString();
                        PrdctCtgry = data2.GetValue(2).ToString();
                    }
                    conect.Close();
                    conect.Open();
                    string query1 = "insert into Sales (DateofSl,RcptNo,CshInst,CusNm,PrdctNm,PrdctCmpny,PrdctCtgry,amnt)  values ('" + monthlyInstallment1.dateTimePicker1.Text.Trim() + "','" + monthlyInstallment1.txtb8.Text.Trim() + " ','Installment','" + monthlyInstallment1.txtb2.Text.Trim() + "','" + PrdctNm + "','" + PrdctCmpny + "','" + PrdctCtgry + "','" + monthlyInstallment1.txtb9.Text.Trim() + "');";
                    SqlCommand cmd3 = new SqlCommand(query1, conect);
                    cmd3.ExecuteNonQuery();
                    conect.Close();
                }
                else
                {

                    MessageBox.Show("Already Used Reciept No!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Entries Empty!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            monthlyInstallment1.txtb9.Text = "";
            monthlyInstallment1.txtb8.Text = "";

        }
        public void DelMonInst_Deletebtn(object sender, EventArgs e)
        {
            Int64 balance = 0, amntrec = 0, blnc, amnt;

            if (delMonInstallRec1.txtb9.Text != string.Empty && delMonInstallRec1.txtb8.Text != string.Empty && delMonInstallRec1.txtb1.Text != string.Empty && delMonInstallRec1.txtb2.Text != string.Empty)
            {
                if (delmoninst_count == 1)
                {
                    DialogResult res = MessageBox.Show("Are you Sure to Delete the Record!", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        if (Int64.TryParse(delMonInstallRec1.txtb9.Text, out amnt))
                        {
                            amntrec = amnt;
                        }
                        try
                        {
                            conect.Open();
                            string query;
                            query = "select Min(blnc) as Minimum from MonInstVar where AcNo='" + delMonInstallRec1.txtb1.Text.Trim() + "';";
                            SqlCommand cmd1 = new SqlCommand(query, conect);
                            SqlDataReader data1 = cmd1.ExecuteReader();

                            while (data1.Read())
                            {

                                if (Int64.TryParse(data1["Minimum"].ToString(), out blnc))
                                {
                                    balance = blnc;
                                }

                            }

                            conect.Close();
                            balance = balance + amntrec;
                            string query2;
                            query2 = "delete from MonInstVar where Acno='" + delMonInstallRec1.txtb1.Text.Trim() + "' and RcptNo='" + delMonInstallRec1.txtb8.Text.Trim() + "'and AmntRec='" + delMonInstallRec1.txtb9.Text.Trim() + "';";
                            conect.Open();
                            SqlCommand cmd2 = new SqlCommand(query2, conect);
                            cmd2.ExecuteNonQuery();
                            if (conect.State == ConnectionState.Open)
                            { conect.Close(); }
                            string query3;
                            query3 = "update MonInstVar set blnc='" + balance + "' where blnc=(select min(blnc) from MonInstVar where AcNo='" + delMonInstallRec1.txtb1.Text.Trim() + "') and AcNo='" + delMonInstallRec1.txtb1.Text.Trim() + "';";
                            conect.Open();
                            SqlCommand cmd4 = new SqlCommand(query3, conect);
                            cmd4.ExecuteNonQuery();
                            if (conect.State == ConnectionState.Open)
                            { conect.Close(); }
                            MessageBox.Show("Deleted Succesfully!");
                        }
                        catch (Exception cr)

                        {

                            MessageBox.Show(cr.Message);

                        }

                        conect.Close();

                        conect.Open();
                        string queryuni = "select PrdctNm,PrdctCmpny,PrdctCtgry from ProSolBas where AcNo='" + delMonInstallRec1.txtb1.Text.Trim() + "';";
                        SqlCommand cmd5 = new SqlCommand(queryuni, conect);
                        SqlDataReader data2 = cmd5.ExecuteReader();

                        while (data2.Read())
                        {
                            PrdctNm = data2.GetValue(0).ToString();
                            PrdctCmpny = data2.GetValue(1).ToString();
                            PrdctCtgry = data2.GetValue(2).ToString();
                        }
                        conect.Close();
                        conect.Open();
                        string query1 = "Delete from Sales where RcptNo='" + delMonInstallRec1.txtb8.Text.Trim() + "'and PrdctNm='" + PrdctNm + "'and PrdctCmpny='" + PrdctCmpny + "'and PrdctCtgry='" + PrdctCtgry + "'and amnt='" + delMonInstallRec1.txtb9.Text.Trim() + "';";
                        SqlCommand cmd3 = new SqlCommand(query1, conect);
                        cmd3.ExecuteNonQuery();
                        conect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Deletion Canceled!");
                    }
                    delmoninst_count = 0;
                }
                else
                {
                    MessageBox.Show("You cannot Delete Processing Reciept Record!");
                }
            }
            else
            {
                MessageBox.Show("Entries Empty!");
            }

        }
        public void DelMonInst_txtb1_textchanged(object sender, EventArgs e)
        {
            delMonInstallRec1.txtb2.Text = "";
            delMonInstallRec1.txtb3.Text = "";
            delMonInstallRec1.txtb4.Text = "";
            conect.Open();
            string query;
            query = "select Appnm,cnic,phoneno from CusPerInfo where AcNo='" + delMonInstallRec1.txtb1.Text.Trim() + "';";
            
            SqlCommand cmd4 = new SqlCommand(query, conect);
            SqlDataReader data1 = cmd4.ExecuteReader();
            while (data1.Read())
            {

                delMonInstallRec1.txtb2.Text = data1.GetValue(0).ToString();
                delMonInstallRec1.txtb3.Text = data1.GetValue(1).ToString();
                delMonInstallRec1.txtb4.Text = data1.GetValue(2).ToString();
                
            }
            conect.Close();
            conect.Open();
            string query1 = "SELECT DATENAME(month, DateofRec) AS 'Month Name' ,DateofRec as 'Date',RcptNo as 'Reciept No',AmntRec as 'Amount Recieved',blnc as 'Balance' from MonInstVar where AcNo='" + delMonInstallRec1.txtb1.Text.Trim() + "';";
            SqlDataAdapter sqlda = new SqlDataAdapter(query1, conect);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            delMonInstallRec1.dataGridView1.DataSource = dtbl;
            if(dtbl.Rows.Count>1)
            {
                delmoninst_count = 1;
            }
            conect.Close();
            


        }
        //Monthly Installment Section//
        //Customer Record Section//
        public void CashCusRec_txtb1txt()
        {
            customerRecord1.textBox1.Text = "";
            customerRecord1.textBox2.Text = "";
            customerRecord1.textBox3.Text = "";
            customerRecord1.textBox4.Text = "";
            customerRecord1.textBox5.Text = "";
            customerRecord1.textBox6.Text = "";
            customerRecord1.textBox7.Text = "";
            customerRecord1.textBox8.Text = "";
            customerRecord1.textBox9.Text = "";
            customerRecord1.textBox10.Text = "";
            customerRecord1.textBox11.Text = "";
            customerRecord1.pictureBox1.Image = null;
            photo_CusRec();
            string query, query2, query3, query4, query5;
            query = "select Appnm,fathnm,cnic,address,phoneno from CusPerInfo where ProRcptNo='" + customerRecord1.txtb1.Text.Trim() + "';";
           
            query2 = "Select TPrice,MInstall,advnc from MonInstStat where ProRcptNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query3 = "select Min(blnc) as Minimum from MonInstVar where RcptNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query4 = "Select PrdctNm from ProSolBas where ProRcptNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query5 = "SELECT DATENAME(month, DateofRec) AS 'Month Name' ,DateofRec as 'Date',RcptNo as 'Reciept No',AmntRec as 'Amount Recieved',blnc as 'Balance' from MonInstVar where RcptNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            conect.Open();
            SqlCommand cmd1 = new SqlCommand(query, conect);




            SqlDataReader data1 = cmd1.ExecuteReader();
            while (data1.Read())
            {

                customerRecord1.textBox1.Text = data1.GetValue(0).ToString();
                customerRecord1.textBox2.Text = data1.GetValue(1).ToString();
                customerRecord1.textBox3.Text = data1.GetValue(2).ToString();
                customerRecord1.textBox4.Text = data1.GetValue(3).ToString();
                customerRecord1.textBox5.Text = data1.GetValue(4).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd3 = new SqlCommand(query2, conect);
            SqlDataReader dt3 = cmd3.ExecuteReader();
            while (dt3.Read())
            {
                customerRecord1.textBox8.Text = dt3.GetValue(0).ToString();
                customerRecord1.textBox9.Text = dt3.GetValue(1).ToString();
                customerRecord1.textBox10.Text = dt3.GetValue(2).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd4 = new SqlCommand(query3, conect);
            SqlDataReader dt4 = cmd4.ExecuteReader();
            while (dt4.Read())
            {
                customerRecord1.textBox11.Text = dt4.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd5 = new SqlCommand(query4, conect);
            SqlDataReader dt5 = cmd5.ExecuteReader();
            while (dt5.Read())
            {
                customerRecord1.textBox7.Text = dt5.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(query5, conect);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            customerRecord1.dataGridView1.DataSource = dtbl;
            conect.Close();
            customerRecord1.label6.SendToBack();

        }
        public void InstCusRec_txtb1txt()
        {
            customerRecord1.textBox1.Text = "";
            customerRecord1.textBox2.Text = "";
            customerRecord1.textBox3.Text = "";
            customerRecord1.textBox4.Text = "";
            customerRecord1.textBox5.Text = "";
            customerRecord1.textBox6.Text = "";
            customerRecord1.textBox7.Text = "";
            customerRecord1.textBox8.Text = "";
            customerRecord1.textBox9.Text = "";
            customerRecord1.textBox10.Text = "";
            customerRecord1.textBox11.Text = "";
            customerRecord1.pictureBox1.Image = null;
            photo_CusRec();
            string query, query1, query2, query3, query4, query5;
            query = "select Appnm,fathnm,cnic,address,phoneno from CusPerInfo where AcNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query1 = "select nm from Spon1 where AcNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query2 = "Select TPrice,MInstall,advnc from MonInstStat where AcNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query3 = "select Min(blnc) as Minimum from MonInstVar where AcNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query4 = "Select PrdctNm from ProSolBas where AcNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            query5 = "SELECT DATENAME(month, DateofRec) AS 'Month Name' ,DateofRec as 'Date',RcptNo as 'Reciept No',AmntRec as 'Amount Recieved',blnc as 'Balance' from MonInstVar where AcNo='" + customerRecord1.txtb1.Text.Trim() + "';";
            conect.Open();
            SqlCommand cmd1 = new SqlCommand(query, conect);




            SqlDataReader data1 = cmd1.ExecuteReader();
            while (data1.Read())
            {

                customerRecord1.textBox1.Text = data1.GetValue(0).ToString();
                customerRecord1.textBox2.Text = data1.GetValue(1).ToString();
                customerRecord1.textBox3.Text = data1.GetValue(2).ToString();
                customerRecord1.textBox4.Text = data1.GetValue(3).ToString();
                customerRecord1.textBox5.Text = data1.GetValue(4).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd2 = new SqlCommand(query1, conect);
            SqlDataReader dt2 = cmd2.ExecuteReader();
            while (dt2.Read())
            {
                customerRecord1.textBox6.Text = dt2.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd3 = new SqlCommand(query2, conect);
            SqlDataReader dt3 = cmd3.ExecuteReader();
            while (dt3.Read())
            {
                customerRecord1.textBox8.Text = dt3.GetValue(0).ToString();
                customerRecord1.textBox9.Text = dt3.GetValue(1).ToString();
                customerRecord1.textBox10.Text = dt3.GetValue(2).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd4 = new SqlCommand(query3, conect);
            SqlDataReader dt4 = cmd4.ExecuteReader();
            while (dt4.Read())
            {
                customerRecord1.textBox11.Text = dt4.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd5 = new SqlCommand(query4, conect);
            SqlDataReader dt5 = cmd5.ExecuteReader();
            while (dt5.Read())
            {
                customerRecord1.textBox7.Text = dt5.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(query5, conect);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            customerRecord1.dataGridView1.DataSource = dtbl;
            conect.Close();
            customerRecord1.label6.SendToBack();

        }
        public void CusRec_txtb1_textchanged(object sender, EventArgs e)
        {
           if(customerRecord1.comboBox1.Text=="Installment")
            {
                InstCusRec_txtb1txt();
            }
           else if (customerRecord1.comboBox1.Text=="Cash")
            {
                CashCusRec_txtb1txt();
               
            }
        }
        public void CusRec_cmb1_textchanged(object sender, EventArgs e)
        {
            if (customerRecord1.comboBox1.Text == "Installment")
            {
                customerRecord1.label3.Text = "Enter Account No.";
                customerRecord1.label4.Text = "Monthly installment Details";
                customerRecord1.label4.Location = new System.Drawing.Point(150, 10);
            }
            else if (customerRecord1.comboBox1.Text == "Cash")
            {
                customerRecord1.label3.Text = "Enter Reciept No.";
                customerRecord1.label4.Text = "Payment Details";
                customerRecord1.label4.Location = new System.Drawing.Point(190, 10);

            }
        }
        public void photo_CusRec()
        {
            if (customerRecord1.txtb1.Text != "")
            {
                string sql = "SELECT photo FROM CusPerInfo WHERE AcNo='" + customerRecord1.txtb1.Text.Trim() + "';";

                conect.Open();
                SqlCommand command = new SqlCommand(sql, conect);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        byte[] img = (byte[])(reader[0]);
                        customerRecord1.label6.SendToBack();
                        MemoryStream ms = new MemoryStream(img);
                        customerRecord1.pictureBox1.Image = Image.FromStream(ms);

                    }
                    else
                    {
                        customerRecord1.pictureBox1.Image = null;
                        customerRecord1.label6.BringToFront();
                       
                    }

                }
                conect.Close();
            }
        }
        //Customer Record Section//
        //All Customer Record section//
        public void AllCusRec_Fun()
        {
            conect.Open();
            if (allCustomerRec1.cmb1.Text=="Date")
            {
                query_allCusRec = "select a.AcNo as 'Account No.',a.Appnm as 'Customer Name',a.ProRcptNo as 'Processing Reciept No',b.PrdctNm as 'Product Name',b.PrdctCmpny as 'Company',b.PrdctCtgry as 'Category',c.RePrice as 'Retail Price',c.Discount as 'Discount',c.TPrice as 'Total Price',c.MInstall as 'Monthly installment',min(d.blnc)  as 'Balance'" +
                    " from CusPerInfo a" +
                    " Inner Join" +
                    " ProSolBas b On a.ProRcptNo = b.ProRcptNo and a.DateofReg='" + allCustomerRec1.dateTimePicker1.Text.Trim()+"'" +
                    " inner Join MonInstStat c on b.ProRcptNo = c.ProRcptNo" +
                    " inner join MonInstVar d on (c.AcNo is not null and c.AcNo=d.AcNo)Or (c.AcNo is null and c.DateofReg=d.DateofRec) " +
                    " group by a.AcNo,a.Appnm,a.ProRcptNo,b.PrdctNm,b.PrdctCmpny,b.PrdctCtgry,c.RePrice,c.Discount,c.TPrice,c.MInstall";


            }
            else if(allCustomerRec1.cmb1.Text=="Month")
            {
                query_allCusRec = "select a.AcNo as 'Account No.',a.Appnm as 'Customer Name',a.ProRcptNo as 'Processing Reciept No',b.PrdctNm as 'Product Name',b.PrdctCmpny as 'Company',b.PrdctCtgry as 'Category',c.RePrice as 'Retail Price',c.Discount as 'Discount',c.TPrice as 'Total Price',c.MInstall as 'Monthly installment',min(d.blnc)  as 'Balance'" +
                    " from CusPerInfo a" +
                    " Inner Join" +
                    " ProSolBas b On a.ProRcptNo = b.ProRcptNo and month(a.DateofReg)= month('" + allCustomerRec1.dateTimePicker1.Text.Trim() + "')" +
                    " inner Join MonInstStat c on b.ProRcptNo = c.ProRcptNo" +
                    " inner join MonInstVar d on (c.AcNo is not null and c.AcNo=d.AcNo)Or (c.AcNo is null and c.DateofReg=d.DateofRec) " +
                    " group by a.AcNo,a.Appnm,a.ProRcptNo,b.PrdctNm,b.PrdctCmpny,b.PrdctCtgry,c.RePrice,c.Discount,c.TPrice,c.MInstall";
            }
            else if(allCustomerRec1.cmb1.Text=="Year")
            {
                query_allCusRec = "select a.AcNo as 'Account No.',a.Appnm as 'Customer Name',a.ProRcptNo as 'Processing Reciept No',b.PrdctNm as 'Product Name',b.PrdctCmpny as 'Company',b.PrdctCtgry as 'Category',c.RePrice as 'Retail Price',c.Discount as 'Discount',c.TPrice as 'Total Price',c.MInstall as 'Monthly installment',min(d.blnc)  as 'Balance'" +
                    " from CusPerInfo a" +
                    " Inner Join" +
                    " ProSolBas b On a.ProRcptNo = b.ProRcptNo and year(a.DateofReg)= year('" + allCustomerRec1.dateTimePicker1.Text.Trim() + "')" +
                    " inner Join MonInstStat c on b.ProRcptNo = c.ProRcptNo" +
                    "  inner join MonInstVar d on (c.AcNo is not null and c.AcNo=d.AcNo)Or (c.AcNo is null and c.DateofReg=d.DateofRec) " +
                    " group by a.AcNo,a.Appnm,a.ProRcptNo,b.PrdctNm,b.PrdctCmpny,b.PrdctCtgry,c.RePrice,c.Discount,c.TPrice,c.MInstall";
            }
            
            SqlDataAdapter da = new SqlDataAdapter(query_allCusRec, conect);
            DataTable dtbl = new DataTable();
            da.Fill(dtbl);
            allCustomerRec1.dataGridView1.DataSource = dtbl;
            conect.Close();

        }
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllCusRec_Fun();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AllCusRec_Fun();
        }
        //All Customer Record Section//
        //Delete Customer REcord Section//
        public void Delphoto_CusRec()
        {
            if (delCusAllRec1.txtb1.Text != "")
            {
                string sql = "SELECT photo FROM CusPerInfo WHERE AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';";

                conect.Open();
                SqlCommand command = new SqlCommand(sql, conect);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    if (reader[0] != System.DBNull.Value)
                    {
                        byte[] img = (byte[])(reader[0]);
                        delCusAllRec1.label6.SendToBack();
                        MemoryStream ms = new MemoryStream(img);
                        delCusAllRec1.pictureBox1.Image = Image.FromStream(ms);

                    }
                    else
                    {
                        delCusAllRec1.pictureBox1.Image = null;
                        delCusAllRec1.label6.BringToFront();

                    }

                }
                conect.Close();
            }
        }
        public void DelCusAllRec_txtb1_textchanged(object sender, EventArgs e)
        {
            delCusAllRec1.textBox1.Text = "";
            delCusAllRec1.textBox2.Text = "";
            delCusAllRec1.textBox3.Text = "";
            delCusAllRec1.textBox4.Text = "";
            delCusAllRec1.textBox5.Text = "";
            delCusAllRec1.textBox6.Text = "";
            delCusAllRec1.textBox7.Text = "";
            delCusAllRec1.textBox8.Text = "";
            delCusAllRec1.textBox9.Text = "";
            delCusAllRec1.textBox9.Text = "";
            delCusAllRec1.textBox10.Text = "";
            delCusAllRec1.pictureBox1.Image = null;
            Delphoto_CusRec();
            string query, query1, query2, query3, query4, query5;
            query = "select Appnm,fathnm,cnic,address,phoneno from CusPerInfo where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';";
            query1 = "select nm from Spon1 where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';";
            query2 = "Select TPrice,advnc from MonInstStat where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';";
            query3 = "select Min(blnc) as Minimum from MonInstVar where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';";
            query4 = "Select PrdctNm from ProSolBas where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';";
            query5 = "SELECT DATENAME(month, DateofRec) AS 'Month Name' ,DateofRec as 'Date',RcptNo as 'Reciept No',AmntRec as 'Amount Recieved',blnc as 'Balance' from MonInstVar where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';";
            conect.Open();
            SqlCommand cmd1 = new SqlCommand(query, conect);




            SqlDataReader data1 = cmd1.ExecuteReader();
            while (data1.Read())
            {

                delCusAllRec1.textBox1.Text = data1.GetValue(0).ToString();
                delCusAllRec1.textBox2.Text = data1.GetValue(1).ToString();
                delCusAllRec1.textBox3.Text = data1.GetValue(2).ToString();
                delCusAllRec1.textBox4.Text = data1.GetValue(3).ToString();
                delCusAllRec1.textBox5.Text = data1.GetValue(4).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd2 = new SqlCommand(query1, conect);
            SqlDataReader dt2 = cmd2.ExecuteReader();
            while (dt2.Read())
            {
                delCusAllRec1.textBox6.Text = dt2.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd3 = new SqlCommand(query2, conect);
            SqlDataReader dt3 = cmd3.ExecuteReader();
            while (dt3.Read())
            {
                delCusAllRec1.textBox8.Text = dt3.GetValue(0).ToString();
                delCusAllRec1.textBox9.Text = dt3.GetValue(1).ToString();
             
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd4 = new SqlCommand(query3, conect);
            SqlDataReader dt4 = cmd4.ExecuteReader();
            while (dt4.Read())
            {
                delCusAllRec1.textBox10.Text = dt4.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlCommand cmd5 = new SqlCommand(query4, conect);
            SqlDataReader dt5 = cmd5.ExecuteReader();
            while (dt5.Read())
            {
                delCusAllRec1.textBox7.Text = dt5.GetValue(0).ToString();
            }
            conect.Close();
            conect.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter(query5, conect);
            DataTable dtbl = new DataTable();
            sqlda.Fill(dtbl);
            delCusAllRec1.dataGridView1.DataSource = dtbl;
            conect.Close();
            delCusAllRec1.label6.SendToBack();

        }
        
        public void DelCusAllRec_Delbtn(object sender, EventArgs e)
        {
            if(delCusAllRec1.txtb1.Text!=""&&delCusAllRec1.textBox1.Text!="")
            {
               
                DialogResult result = MessageBox.Show("Are you sure to Delete Record of the Customer!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conect.Open();
                    string query = "delete from CusPerInfo where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';" +
                        //"delete from MonInstStat where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "';" +
                        "delete from MonInstVar where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "'; " +
                        //"delete from Spon1 where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "'; " +
                        //"delete from Spon2 where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "'; " +
                        //"delete from ProSolBas where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "'; " +
                        //"delete from ProSolBik where AcNo='" + delCusAllRec1.txtb1.Text.Trim() + "'; " +
                        "delete top (1)  from NewPro  where PrdctNm='" + delCusAllRec1.textBox7.Text.Trim() + "' and Quantity=-1";
                    SqlCommand cmd = new SqlCommand(query, conect);
                    cmd.ExecuteNonQuery();
                    conect.Close();
                    delCusAllRec1.txtb1.Text = "";
                    delCusAllRec1.textBox1.Text = "";
                    delCusAllRec1.textBox2.Text = "";
                    delCusAllRec1.textBox3.Text = "";
                    delCusAllRec1.textBox4.Text = "";
                    delCusAllRec1.textBox5.Text = "";
                    delCusAllRec1.textBox6.Text = "";
                    delCusAllRec1.textBox7.Text = "";
                    delCusAllRec1.textBox8.Text = "";
                    delCusAllRec1.textBox9.Text = "";
                    delCusAllRec1.textBox9.Text = "";
                    delCusAllRec1.textBox10.Text = "";
                    delCusAllRec1.pictureBox1.Image = null;
                    MessageBox.Show("Record Deleted Succesfully!");


                }
                else
                {
                    MessageBox.Show("Deletion Canceled!");
                }

            }
            else
            {
                MessageBox.Show("No Record To Delete!");
            }
        }
        //Delete Customer Record Section//
        /// <summary>
        /// Sponsor detail Section//
        public void SponRecDis_txtchanged(object sender,EventArgs e)
        {

            cusSponRec1.txtb4.Text = "";
            cusSponRec1.txtb5.Text = "";
            cusSponRec1.txtb6.Text = "";
            cusSponRec1.txtb7.Text = "";
            cusSponRec1.txtb8.Text = "";
            cusSponRec1.txtb9.Text = "";
            cusSponRec1.txtb10.Text = "";
            cusSponRec1.txtb11.Text = "";
            conect.Open();
                string query = "select nm,cnic,address,phoneno from Spon1 where AcNo='"+cusSponRec1.txtb1.Text.Trim()+"';";
                SqlCommand cmd = new SqlCommand(query, conect);
                SqlDataReader dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    cusSponRec1.txtb4.Text = dt.GetValue(0).ToString();
                    cusSponRec1.txtb5.Text = dt.GetValue(1).ToString();
                    cusSponRec1.txtb6.Text = dt.GetValue(2).ToString();
                    cusSponRec1.txtb7.Text = dt.GetValue(3).ToString();

                }
                conect.Close();
                conect.Open();
                string query1 = "select nm,cnic,address,phoneno from Spon2 where AcNo='" + cusSponRec1.txtb1.Text.Trim() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, conect);
                SqlDataReader dt1 = cmd1.ExecuteReader();
            while (dt1.Read())
            {
                cusSponRec1.txtb8.Text = dt1.GetValue(0).ToString();
                cusSponRec1.txtb9.Text = dt1.GetValue(1).ToString();
                cusSponRec1.txtb10.Text = dt1.GetValue(2).ToString();
                cusSponRec1.txtb11.Text = dt1.GetValue(3).ToString();

            }
                conect.Close();
            



        }
        /// Sponsor detail Section//
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //Stock Section//
        public void NewPro_savebtn(object sender,EventArgs e)
        {
            //string query;
            ////Product Detail Entering//
            //try

            //{
            //    conect.Open();
            //    query = "insert into NewPro values('" + newPro1.txtb1.Text.Trim() + "','" + newPro1.txtb2.Text.Trim() + "','" + newPro1.txtb3.Text.Trim()+"');";
            //    SqlCommand cmd = new SqlCommand(query, conect);
            //    dbr = cmd.ExecuteReader();
            //    MessageBox.Show("Saved Succesfully!");
            //    while (dbr.Read())

            //    {

            //    }

            //}

            //catch (Exception es)

            //{

            //    MessageBox.Show(es.Message);

            //}
            //conect.Close();
            generl_combobox();
            proPur1.generl_combobox();
        }
        public void Stock_DGV1()
        {
            conect.Open();
            string query = "select PrdctNm as 'Product Name',PrdctCmpny as 'Product Company',PrdctCtgry as 'Product Category',Sum(Quantity) as 'Remaining Quantity' from NewPro group by PrdctNm,PrdctCmpny,PrdctCtgry";
              
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stockRec1.dataGridView1.DataSource = dt;
            conect.Close();
        }
        private void StockDateTimeP_ValueChanged(object sender, EventArgs e)
        {
            Stock_DGV1();
        }
        //Stock Section//
        //Sales and Purchase Record//
        public void PurRec_Plusbtn(object sender,EventArgs e)
        {
            purchaseRec1.l1.Visible = false;
            purchaseRec1.l2.Visible =false;
            purchaseRec1.l3.Visible = false;
            if (purchaseRec1.txtb1.Text != "" && purchaseRec1.txtb2.Text != "" && purchaseRec1.txtb3.Text != "")
            {
                proPur1.BringToFront();
                conect.Open();
                string query = "Insert into ProPurPri values ('" + purchaseRec1.dateTimePicker1.Text.Trim() + "','" + purchaseRec1.txtb1.Text.Trim() + "','" + purchaseRec1.txtb2.Text.Trim() + "','" + purchaseRec1.txtb3.Text.Trim() + "');";
                SqlCommand sqlcmd = new SqlCommand(query, conect);
                sqlcmd.ExecuteNonQuery();
                conect.Close();
                ProPur_DGV1();
            }
            if (purchaseRec1.txtb1.Text == "" || purchaseRec1.txtb2.Text == "" ||purchaseRec1.txtb3.Text == "")
            {
                MessageBox.Show("Entries are Empty!");
            }
            if(purchaseRec1.txtb1.Text=="")
            {
                purchaseRec1.l1.Visible = true;
            }
            if (purchaseRec1.txtb2.Text == "")
            {
                purchaseRec1.l2.Visible = true;
            }
            if (purchaseRec1.txtb2.Text == "")
            {
                purchaseRec1.l3.Visible = true;
            }




        }
       
        public void ProPur_Addnew(object sender, EventArgs e)
        {
            
            int count = 0;
            conect.Open();
            try
            {
                string query1 = "Insert into NewPro values ('" + purchaseRec1.txtb2.Text.Trim() + "','" + proPur1.comboBox1.Text.Trim() + "','" + proPur1.comboBox2.Text.Trim() + "','" + proPur1.comboBox3.Text.Trim() + "','" + proPur1.comboBox4.Text.Trim() + "');";
                string query = "Insert into ProPurSec values ('" + purchaseRec1.txtb2.Text.Trim() + "','" + proPur1.comboBox1.Text.Trim() + "','" + proPur1.comboBox2.Text.Trim() + "','" + proPur1.comboBox3.Text.Trim() + "','" + proPur1.comboBox4.Text.Trim() + "');";
                SqlCommand sqlcmd = new SqlCommand(query, conect);
                SqlCommand sqlcmd1 = new SqlCommand(query1, conect);
                sqlcmd1.ExecuteNonQuery();
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Previous One Saved Successfully");
                count = 1;
                ProPur_Count = 1;
                
            }
            catch 
            {
                MessageBox.Show("Not Saved!");
            }
            
            if (count == 1)
            {
                proPur1.comboBox1.Text = "";
                proPur1.comboBox2.Text = "";
                proPur1.comboBox3.Text = "";
                proPur1.comboBox4.Text = "";
            }
            conect.Close();
            generl_combobox();
        }
        public void ProPur_finish(object sender, EventArgs e)
        {
            if (ProPur_Count != 1)
            {
                MessageBox.Show("No Item has been entered!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure to close it!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    proPur1.SendToBack();
                    purchaseRec1.txtb1.Text = "";
                    purchaseRec1.txtb2.Text = "";
                    purchaseRec1.txtb3.Text = "";
                }
                ProPur_Count = 0;
            }


        }
        public void ProPur_DGV1()
        {
            conect.Open();
            string query= "select DateofPur as 'Date of Purchasing',Dlrnm as 'Dealer Name',billno as 'Bill No', amnt as 'Amount'  from ProPurPri where DateofPur between'" + purchaseRec1.dateTimePicker2.Text.Trim()+ "' and getdate() order by DateofPur";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            purchaseRec1.dataGridView1.DataSource = dt;
            conect.Close();
        }
        private void ProPurDateTimeP_ValueChanged(object sender, EventArgs e)
        {
            ProPur_DGV1();
        }
        public void Sales_DGV1()
        {
            conect.Open();
            string query = "select DateofSl as 'Date',RcptNo as 'Reciept No',CusNm as 'Customer Name', CshInst as 'Cash / Installment',PrdctNm as 'Product Name',PrdctCmpny as 'Product Company',PrdctCtgry as 'Product Category',Amnt as 'Amount'  from Sales where DateofSl ='" + salesRec1.dateTimePicker1.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            salesRec1.dataGridView1.DataSource = dt;
            conect.Close();
        }
        private void SalesrDateTimeP_ValueChanged(object sender, EventArgs e)
        {
            Sales_DGV1();
        }
        private void ProPurbillTxtb_valchng(object sender, EventArgs e)
        {

            conect.Open();
            string query = "select PrdctNm as 'Product Name', PrdctCmpny as 'Product Company',PrdctCtgry as 'Product Category / Model',Quantity from ProPurSec where billno='" + purchaseRec1.txtb4.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            purchaseRec1.dataGridView2.DataSource = dt;
            conect.Close();
        }
        /*Daily Expenses*/
        private void ExpensesRec_Fun(object sender, EventArgs e)
        {
            if (expenses1.txtb1.Text != "" || expenses1.txtb2.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure to Save it!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conect.Open();
                    string query = "insert into Expns values ('" + expenses1.txtb1.Text.Trim() + "','" + expenses1.dateTimePicker1.Text.Trim() + "','" + expenses1.txtb2.Text.Trim() + "');";
                    SqlCommand sqlcmd = new SqlCommand(query, conect);
                    sqlcmd.ExecuteNonQuery();
                    conect.Close();
                    expenses1.txtb1.Text = "";
                    expenses1.txtb2.Text = "";
                    ExpenseDataDisplay();
                    ExpenditureDataDisplay();
                    DailySales_DGV1();
                }
                else
                {
                    MessageBox.Show("Canceled!");
                }
            }
            else
            {
                MessageBox.Show("Entries Empty!");
            }

            
        }
        private void ExpenseDataDisplay()
        {
            conect.Open();
            string query = "Select dtyl as Detail, Amnt as Amount from Expns where DateofExp='" + expenses1.dateTimePicker2.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            expenses1.dataGridView1.DataSource = dt;
            conect.Close();

        }
        
        private void ExpenseDataGrid(object sender,EventArgs e)
        {

            ExpenseDataDisplay();
        }

        /*Daily Expenses*/
        /*Daily Expenditure*/

        private void ExpenditureDataDisplay()
        {
            conect.Open();
            string query = "Select dtyl as Detail, Amnt as Amount from Expns where DateofExp='" + dailyExpenditure1.dateTimePicker1.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dailyExpenditure1.dataGridView2.DataSource = dt;
            conect.Close();

        }
        private void ExpenditureDataGrid(object sender, EventArgs e)
        {
            ExpenditureDataDisplay();
            DailySales_DGV1();
            DailyExpndPur_DGV1();
        }
        public void DailySales_DGV1()
        {
            conect.Open();
            string query = "select DateofSl as 'Date',RcptNo as 'Reciept No',CusNm as 'Customer Name', CshInst as 'Cash / Installment',PrdctNm as 'Product Name',PrdctCmpny as 'Product Company',PrdctCtgry as 'Product Category',Amnt as 'Amount'  from Sales where DateofSl ='" + dailyExpenditure1.dateTimePicker1.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dailyExpenditure1.dataGridView1.DataSource = dt;
            conect.Close();
        }
        public void DailyExpndPur_DGV1()
        {
            conect.Open();
            string query = "select DateofPur as 'Date of Purchasing',Dlrnm as 'Dealer Name',billno as 'Bill No', amnt as 'Amount'  from ProPurPri where DateofPur ='" + dailyExpenditure1.dateTimePicker1.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dailyExpenditure1.dataGridView3.DataSource = dt;
            conect.Close();
        }
        public void DailyEpenditure()
        {
            Int64 expns = 0, sales = 0, cal = 0;
            Int64 ResultNumber,res1,res2;
            Int64 purprice = 0;
            conect.Open();
            string query = "select sum(amnt) as SUM  from Sales where DateofSl='" + dailyExpenditure1.dateTimePicker1.Text.Trim() + "';";
            SqlCommand cmd = new SqlCommand(query, conect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                if (Int64.TryParse(dr["SUM"].ToString(), out ResultNumber))
                {
                   sales = ResultNumber;
                }
            }
            conect.Close();
            conect.Open();
            string query1 = "select Sum(Amnt) as SUM from Expns where DateofExp ='" + dailyExpenditure1.dateTimePicker1.Text.Trim() + "';";

            SqlCommand cmd1 = new SqlCommand(query1, conect);

            SqlDataReader dr2 = cmd1.ExecuteReader();
            
            while (dr2.Read())
            {

                if(Int64.TryParse(dr2["SUM"].ToString(),out res1))
                    {
                    expns = res1;
                }
            }
            conect.Close();
            
            conect.Open();
            string query3 = "select Sum(amnt) as SUM from ProPurPri where DateofPur ='" + dailyExpenditure1.dateTimePicker1.Text.Trim() + "';";

            SqlCommand cmd3 = new SqlCommand(query3, conect);

            SqlDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {

                if (Int64.TryParse(dr3["SUM"].ToString(), out res2))
                {
                    purprice = res2;
                }
            }
            conect.Close();

            cal = sales - expns-purprice;
            dailyExpenditure1.txtb1.Text = cal.ToString();




        }
        private void ExpenditureCal(object sender, EventArgs e)
        {
            ExpenditureDataDisplay();
            DailySales_DGV1();
            DailyEpenditure();
            DailyExpndPur_DGV1();
        }
        /*Daily Expenditure*/
        /*Delete Purchase Record*/
        public void DelPurRec_billtxtchanged(object sender,EventArgs e)
        {
            conect.Open();
            string query = "select DateofPur as 'Date of Purchasing',Dlrnm as 'Dealer Name',billno as 'Bill No', amnt as 'Amount'  from ProPurPri where DateofPur ='" + delProPurRec1.dateTimePicker1.Text.Trim() + "'and billno='"+delProPurRec1.txtb1.Text.Trim()+"';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            delProPurRec1.dataGridView1.DataSource = dt;
            conect.Close();
            conect.Open();
            string query1 = "select PrdctNm as 'Product Name', PrdctCmpny as 'Product Company',PrdctCtgry as 'Product Category / Model',Quantity from ProPurSec where billno='" + delProPurRec1.txtb1.Text.Trim() + "';";
            SqlDataAdapter da1 = new SqlDataAdapter(query1, conect);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            delProPurRec1.dataGridView2.DataSource = dt1;
            conect.Close();
        }
        public void DelPurRec_delbtn(object sender, EventArgs e)
        {
            if (delProPurRec1.txtb1.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure to Delete the Record!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conect.Open();
                    string query = "delete from ProPurSec where billno='" + delProPurRec1.txtb1.Text.Trim() + "';" +
                        "delete from ProPurPri where billno='" + delProPurRec1.txtb1.Text.Trim() + "';";
                    SqlCommand cmd = new SqlCommand(query, conect);
                    cmd.ExecuteNonQuery();
                    conect.Close();
                    MessageBox.Show("Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("Deletion Canceled!");
                }
            }
            else
            {
                MessageBox.Show("No Record to Delete!");
            }
            delProPurRec1.txtb1.Text = "";
        }
        private void DelExpenseDataGrid(object sender, EventArgs e)
        {
            conect.Open();
            string query = "Select dtyl as Detail, Amnt as Amount from Expns where DateofExp='" + delExpsRec1.dateTimePicker1.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            delExpsRec1.dataGridView1.DataSource = dt;
            conect.Close();
            ExpenseDataDisplay();
        }
        private void DelExpsRec_delbtn(object sender,EventArgs e)
        {
            if (delExpsRec1.txtb1.Text != "" && delExpsRec1.txtb2.Text != "")
            {
                if (Del_cnfrm())
                {
                    
                    DialogResult result = MessageBox.Show("Are you sure to Delete the Record!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        conect.Open();
                        string query = "delete from Expns where Dtyl='" + delExpsRec1.txtb1.Text.Trim() + "' and DateofExp = '" + delExpsRec1.dateTimePicker1.Text.Trim() + "' and Amnt='" + delExpsRec1.txtb2.Text.Trim() + "';";
                        SqlCommand cmd = new SqlCommand(query, conect);
                        cmd.ExecuteNonQuery();
                        conect.Close();
                        MessageBox.Show("Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Canceled!");
                    }
                }
                else
                {
                    MessageBox.Show("No Record to Delete!");
                }
            }
              else
            {
                 MessageBox.Show("No Record to Delete!");
            }
                delExpsRec1.txtb1.Text = "";
                delExpsRec1.txtb2.Text = "";

        }
        private bool Del_cnfrm()
        {
           
            string query = "select * from Expns where Dtyl='" + delExpsRec1.txtb1.Text.Trim() + "' and DateofExp = '" + delExpsRec1.dateTimePicker1.Text.Trim() + "' and Amnt='" + delExpsRec1.txtb2.Text.Trim() + "';";
            conect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                conect.Close();
                return true;
                

            }

            else
            {
                conect.Close();
                return false;

            }
           

        }

        //Sales and Prchase Record//
        //Owners Account//
        private void debitSave_Fun(object sender, EventArgs e)
        {
            if (debitAc1.txtb1.Text != "")
            {
                DialogResult result = MessageBox.Show("Are you sure to Save it!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conect.Open();
                    string query = "insert into Dbt values ('" + debitAc1.dateTimePicker1.Text.Trim() + "','" + debitAc1.txtb1.Text.Trim() + "');";
                    SqlCommand sqlcmd = new SqlCommand(query, conect);
                    sqlcmd.ExecuteNonQuery();
                    conect.Close();
                    debitAc1.txtb1.Text = "";
                   
                }
                else
                {
                    MessageBox.Show("Canceled!");
                }
            }
            else
            {
                MessageBox.Show("Entries Empty!");
            }


        }
        public void Debit_DGV1()
        {
            conect.Open();
            string query = "select DateofAR as 'Date of Amount Recieved', Amnt as 'Amount Recieved' from Dbt where DateofAR between'" + debitAc1.dateTimePicker2.Text.Trim() + "' and getdate() order by DateofAR";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            debitAc1.dataGridView1.DataSource = dt;
            conect.Close();
        }
        private void DebitDataGrid(object sender, EventArgs e)
        {
            Debit_DGV1();
        }
        public void Credit_DGV1()
        {
            conect.Open();
            string query = "select DateofPur as 'Date of Purchasing',Dlrnm as 'Dealer Name',billno as 'Bill No', amnt as 'Amount'  from ProPurPri where DateofPur between'" + creditAc1.dateTimePicker1.Text.Trim() + "' and getdate() order by DateofPur";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            creditAc1.dataGridView1.DataSource = dt;
            conect.Close();
        }
        private void CreditDateTimeP_ValueChanged(object sender, EventArgs e)
        {
            Credit_DGV1();
        }

        private void delExpsRec1_Load(object sender, EventArgs e)
        {

        }

        public void DelDebit_DGV1(object sender, EventArgs e)
        {
            conect.Open();
            string query = "select DateofAR as 'Date of Amount Recieved', Amnt as 'Amount Recieved' from Dbt where DateofAR ='" + delDebRec1.dateTimePicker1.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            delDebRec1.dataGridView1.DataSource = dt;
            conect.Close();
        }

        private bool DelDebit_cnfrm()
        {

            string query = "select * from Dbt where DateofAR ='"+delDebRec1.dateTimePicker1.Text.Trim()+"' and Amnt ='"+delDebRec1.txtb1.Text.Trim()+"'";
            conect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                conect.Close();
                return true;


            }

            else
            {
                conect.Close();
                return false;

            }


        }
        private void DelDebitRec_delbtn(object sender, EventArgs e)
        {
            if (delDebRec1.txtb1.Text != "")
            {
                if (DelDebit_cnfrm())
                {

                    DialogResult result = MessageBox.Show("Are you sure to Delete the Record!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        conect.Open();
                        string query = "delete from Dbt where DateofAR='"+delDebRec1.dateTimePicker1.Text.Trim()+"' and Amnt='"+delDebRec1.txtb1.Text.Trim()+"'";
                        SqlCommand cmd = new SqlCommand(query, conect);
                        cmd.ExecuteNonQuery();
                        conect.Close();
                        MessageBox.Show("Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Canceled!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Amount Entered!");
                }
            }
            else
            {
                MessageBox.Show("Hello No Record to Delete!");
            }
            delDebRec1.txtb1.Text = "";
          

        }
        //OWners Account//
        //Bike registrtion Section//
        private void Bkreg_Fun(object sender, EventArgs e)
        {
            if (bikeRegRec1.txtb1.Text != ""&& bikeRegRec1.txtb2.Text != "" && bikeRegRec1.txtb3.Text != "" &&bikeRegRec1.txtb4.Text != "" && bikeRegRec1.radioButton1.Checked != false|| bikeRegRec1.radioButton2.Checked != false)
            {
                DialogResult result = MessageBox.Show("Are you sure to Save it!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    conect.Open();
                    if (bikeRegRec1.radioButton1.Checked == true)
                    {
                        bkquery = "insert into BkReg values ('" + bikeRegRec1.dateTimePicker1.Text.Trim() + "','" + bikeRegRec1.txtb1.Text.Trim() + "','" + bikeRegRec1.txtb2.Text.Trim() + "','" + bikeRegRec1.txtb3.Text.Trim() + "','" + bikeRegRec1.txtb4.Text.Trim() + "','Yes');";
                    }
                    if (bikeRegRec1.radioButton2.Checked == true)
                    {
                        bkquery = "insert into BkReg values ('" + bikeRegRec1.dateTimePicker1.Text.Trim() + "','" + bikeRegRec1.txtb1.Text.Trim() + "','" + bikeRegRec1.txtb2.Text.Trim() + "','" + bikeRegRec1.txtb3.Text.Trim() + "','" + bikeRegRec1.txtb4.Text.Trim() + "','No');";
                    }
                    SqlCommand sqlcmd = new SqlCommand(bkquery, conect);
                    sqlcmd.ExecuteNonQuery();
                    conect.Close();
                    bikeRegRec1.txtb1.Text = "";
                    bikeRegRec1.txtb2.Text = "";
                    bikeRegRec1.txtb3.Text = "";
                    bikeRegRec1.txtb4.Text = "";
                    bikeRegRec1.radioButton1.Checked = false;
                    bikeRegRec1.radioButton2.Checked = false;

                }
                else
                {
                    MessageBox.Show("Canceled!");
                }
            }
            else
            {
                MessageBox.Show("Entries Empty!");
            }


        }
        public void BikeReg_DGV1()
        {
            conect.Open();
            string query = "select DateReg as 'Date',AcNo as 'Account No',Appnm as 'Applicant Name',Amnt as 'Fee',PltNo as 'Registration No',Rcvd as 'Recieved' from BkReg where DateReg between'" + bikeRegRecDis1.dateTimePicker1.Text.Trim() + "' and getdate() order by DateReg";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bikeRegRecDis1.dataGridView1.DataSource = dt;
            conect.Close();
        }
        private void BikeRegDataGrid(object sender, EventArgs e)
        {
            BikeReg_DGV1();
        }
        public void DelBikeReg_DGV1(object sender, EventArgs e)
        {
            conect.Open();
            string query = "select DateReg as 'Date',AcNo as 'Account No',Appnm as 'Applicant Name',Amnt as 'Fee',PltNo as 'Registration No',Rcvd as 'Recieved' from BkReg where AcNo='" + delBikeRegRec1.txtb1.Text.Trim() + "';";
            SqlDataAdapter da = new SqlDataAdapter(query, conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            delBikeRegRec1.dataGridView1.DataSource = dt;
            conect.Close();
        }

        private bool DelBikeRegRec_cnfrm()
        {

            string query = "select * from Bkreg where AcNo='" +delBikeRegRec1.txtb1.Text.Trim()+"'";
            conect.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conect);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                conect.Close();
                return true;


            }

            else
            {
                conect.Close();
                return false;

            }


        }
        private void DelBikeRegRec_delbtn(object sender, EventArgs e)
        {
            if (delBikeRegRec1.txtb1.Text != "")
            {
                if (DelBikeRegRec_cnfrm())
                {

                    DialogResult result = MessageBox.Show("Are you sure to Delete the Record!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        conect.Open();
                        string query = "delete from BkReg where AcNo='" + delBikeRegRec1.txtb1.Text.Trim()+ "'";
                        SqlCommand cmd = new SqlCommand(query, conect);
                        cmd.ExecuteNonQuery();
                        conect.Close();
                        MessageBox.Show("Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Deletion Canceled!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Amount Entered!");
                }
            }
            else
            {
                MessageBox.Show("Hello No Record to Delete!");
            }
            delBikeRegRec1.txtb1.Text = "";


        }
        //Bike registrtion Section//

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        

        /// <summary>
        /// BackUp! and Restore!///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void browsebtn_backup(object sender,EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                backup1.txtb1.Text = dlg.SelectedPath;
                backup1.backupbtn.Enabled = true;

            }
        }
        public void backupbtn_backup(object sender,EventArgs e)
        {
            string database = conect.Database.ToString();
            try
            {
                if(backup1.txtb1.Text==string.Empty)
                {
                    MessageBox.Show("Please Enter backup file location!");
                }
                else
                {
                    
                    string cmd = "BACKUP DATABASE " + database + " TO DISK='" + backup1.txtb1.Text.Trim() + "\\" + "FAZLERABBI_DBBACKUP" +"-"+DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'";
                    using(SqlCommand command=new SqlCommand(cmd,conect))
                    {
                        if(conect.State!=ConnectionState.Open)
                        {
                            conect.Open();
                        }
                        command.ExecuteNonQuery();
                        conect.Close();
                        MessageBox.Show("Database backup  Done Successfully!");
                        backup1.backupbtn.Enabled = false;

                    }
                }
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            backup1.txtb1.Text = "";
        }
        public void browsebtn_restore(object sender, EventArgs e)
        {
            OpenFileDialog dlg=new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup file|*.bak";
            dlg.Title = "Database Restore";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                restore1.txtb1.Text = dlg.FileName;
                restore1.restorebtn.Enabled = true;

            }
        }

        public void restorebtn_restore(object sender, EventArgs e)
        {
            string database = conect.Database.ToString();
            try
            {
                if (restore1.txtb1.Text == string.Empty)
                {
                    MessageBox.Show("Please Enter backup file location!");
                }
                else
                {
                    DialogResult res = MessageBox.Show("Are you Sure to Replace Database With BackUp File!", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Wait for A while while Restore is being done!");
                        if (conect.State != ConnectionState.Open)
                        {
                            conect.Open();
                        }
                        string sqlstmt1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                        SqlCommand cmd1 = new SqlCommand(sqlstmt1, conect);
                        cmd1.ExecuteNonQuery();
                        string sqlstmt2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK = '" + restore1.txtb1.Text.Trim() + "'WITH REPLACE;");
                        SqlCommand cmd2 = new SqlCommand(sqlstmt2, conect);
                        cmd2.ExecuteNonQuery();
                        string sqlstmt3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                        SqlCommand cmd3 = new SqlCommand(sqlstmt3, conect);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show("Database Restore  Done successfully!");
                        restore1.restorebtn.Enabled = false;
                        conect.Close();
                    }
                    else
                    {
                        MessageBox.Show("Restore Canceled!");
                    }
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            restore1.txtb1.Text = "";
        }



    }
}
