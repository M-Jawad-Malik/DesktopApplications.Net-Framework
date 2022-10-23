using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.Server;

namespace SMSTOMOBILE
{
    public partial class Form1 : Form
    {
        private GsmCommMain comm;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //WebClient client = new WebClient();
                //Stream s = client.OpenRead("");
                //StreamReader reader = new StreamReader(s);
                //string result = reader.ReadToEnd();
                //MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SmsSubmitPdu pdu;
                byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                pdu = new SmsSubmitPdu(SMSTxt.Text, NumTxt.Text.ToString(),dcs);
                int time = 1;
                for(int i=0;i<time;i++)
                {
                    comm.SendMessage(pdu);
                }

            }
            catch(Exception ce)
            {
                MessageBox.Show(ce.Message, "Message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ComPort.Text=="")
            {
                MessageBox.Show("Device Not Connected");
                return;
            }
            comm = new GsmCommMain(ComPort.Text, 9600, 150);
            Cursor.Current = Cursors.Default;
            bool retry;
            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Device Connected Succesfully!");

                }
                catch (Exception c)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(c.Message, "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information) == DialogResult.Retry)
                    {
                        retry = true;
                    }
                    else
                    {
                        return;
                    }
                }
            } while (retry);

        }
    }
}
