using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeighMan.Model;

namespace WeighMan
{
    public partial class FrmAuth : Form
    {
        public FrmAuth()
        {
            InitializeComponent();
            this.label1.Text = "Serial Key : " + GetMACAddress();
            txt_Entry.Text = GetMACAddress();
        }
        public string GetMACAddress()
        {
            string str = string.Empty;
            foreach (NetworkInterface interface2 in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (str == string.Empty)
                {
                    str = interface2.GetPhysicalAddress().ToString();
                }
            }
            return str;
        }

        private void txt_Entry_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string mACAddress = GetMACAddress();
                
                char[] chArray = new char[mACAddress.Length];
                int index = 0;
                int num2 = mACAddress.Length - 1;
                while (true)
                {
                    if (index >= mACAddress.Length)
                    {

                       string str2 = new string(chArray);

                        this.txt_Entry.Text = ("ACT_" + GetMACAddress() + "__" + str2);
                        if (this.txt_Entry.Text == ("ACT_" + GetMACAddress() + "__" + str2))
                        {
                            DataBaseRepository databaser = new DataBaseRepository();
                            databaser.RemoveConfig();
                            WeighConfigMaster weighConfigMaster = new WeighConfigMaster { camera="a",device="a",status= GetMACAddress() };
                            databaser.
                                InsertConfig(weighConfigMaster);
                            MessageBox.Show("Restarting Application for activation...");
                            Application.Restart();
                        }
                        break;
                    }
                    chArray[index] = mACAddress[num2];
                    index++;
                    num2--;
                }
            }
            catch
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaseRepository databaser = new DataBaseRepository();
            databaser.RemoveConfig();


        }
    }

  

    }

