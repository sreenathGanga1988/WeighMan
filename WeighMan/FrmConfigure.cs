using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeighMan.Model;

namespace WeighMan
{
    public partial class FrmConfigure : Form
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice FinalVideo;
        public SerialPort mySerialPort;
        public FrmConfigure()
        {
            InitializeComponent();
            FillCom();
            FillVideo();
        }


        public FilterInfoCollection getvideodevices()
        {
            this.VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            return this.VideoCaptureDevices;
        }

        public void FillVideo()
        {
            this.cmbCam.Items.Clear();
            foreach (FilterInfo info in this.getvideodevices())
            {
                this.cmbCam.Items.Add(info.Name);

                //this.cmbCam.Items.Add(new { Text = info.Name, Value = info.Name });
            }
        }


        public void FillCom()
        {
            foreach (string str2 in SerialPort.GetPortNames())
            {
                string str3 = "";
                bool flag = str2.Length > 5;
                str3 = !flag ? str2 : str2.Substring(0, 5);
               this.cmbCom.Items.Add(str3);
              //  this.cmbCom.Items.Add(new { Text = str3, Value = str3 });
            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            try
            {
                new VideoCaptureDeviceForm().ShowDialog();
            }
            catch
            {
            }

        }

        private void FrmConfigure_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.FinalVideo.Stop();
                this.mySerialPort.Close();
            }
            catch
            {
            }

        }

        private void FrmConfigure_Shown(object sender, EventArgs e)
        {
            try
            {

                this.txt_weight.Select();

                this.lblMsg .Text = "Please wait... Initiating Ports and Devices...";
                DataBaseRepository databaser = new DataBaseRepository();

                List<WeighMan.Model.WeighConfigMaster> weighConfigMasters = databaser.GetConfigDet();
              
                if (weighConfigMasters.Count > 0)
                {

                   

                    cmbCam.SelectedItem= weighConfigMasters.FirstOrDefault().camera.ToString ();


                    cmbCom.SelectedItem = weighConfigMasters.FirstOrDefault().device.ToString();

                }
                else
                {
                    //this.cmbCam.SelectedIndex = 0;
                    //this.cmbCom.SelectedIndex = 0;
                }
                this.setimage(this.cmbCam.SelectedIndex);
                try
                {
                    if (this.cmbCom.Text != "")
                    {
                        this.mySerialPort = new SerialPort(this.cmbCom.Text);
                        this.mySerialPort.BaudRate = 0x2580;
                        this.mySerialPort.Parity = Parity.None;
                        this.mySerialPort.StopBits = StopBits.One;
                        this.mySerialPort.DataBits = 8;
                        this.mySerialPort.Handshake = Handshake.None;
                        this.mySerialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
                        this.mySerialPort.Open();
                        this.mySerialPort.DtrEnable = true;
                    }
                }
                catch (Exception exception1)
                {
                    MessageBox.Show(exception1.ToString());
                }
                this.lblMsg.Text = "";
                string key = databaser.GetSavedConfig();

               
                string mACAddress = GetMACAddress();



                if (key == null )
                {
                    MessageBox.Show("License Authentication Failed...");
                    new FrmAuth().ShowDialog();
                       Application.Exit();
                }
                else if (key.Trim()=="")
                {

                    MessageBox.Show("License Authentication Failed...");
                    new FrmAuth().ShowDialog();
                    Application.Exit();
                }
                else if (key.Trim()!= mACAddress)
                {
                    new FrmAuth().ShowDialog();
                    MessageBox.Show("License Authentication Failed...");
                    Application.Exit();
                }
                else
                {
                    lblMsg.Text = "Valid User";
                }
               
            }
            catch
            {

                MessageBox.Show("Invalid License... Contact Azinova...");
            }

        }



        public void setimage(int index)
        {
            try
            {
                if (this.cmbCam.Text != "")
                {
                    this.VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                    this.FinalVideo = new VideoCaptureDevice(this.VideoCaptureDevices[index].MonikerString);
                    this.FinalVideo.NewFrame += new NewFrameEventHandler(this.FinalVideo_NewFrame);
                    try
                    {
                        this.FinalVideo.Start();
                    }
                    catch (Exception exception1)
                    {
                        MessageBox.Show(exception1.ToString() + " - Capture Start Failed");
                    }
                }
            }
            catch (Exception exception3)
            {
                MessageBox.Show(exception3.ToString() + " - Device Initialization Failed");
            }
        }



        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
                this.pictureBox1.Image = bitmap;
                GC.Collect();
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString() + " - Capturing Frame Failed");
            }
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






        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string indata = ((SerialPort)sender).ReadLine();
                if ((indata.Trim() != "") && (indata.Trim().Length > 2))
                {

                    txt_weight.Text= indata.Trim();
                    //base.BeginInvoke(delegate {
                    //    this.elEntryBox1.Text = "";
                    //    this.elEntryBox1.Text = indata.Trim();
                    //});
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString());
            }
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            
        }

        private void pnl_configure_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btn_edit.Text != "Edit")
                {
                    try
                    {
                        pnl_configure.Enabled = false;
                        this.btn_edit.Text = "Edit";
                        this.cmbCam.SelectedItem = this.cmbCam.Text;
                        this.setimage(this.cmbCam.SelectedIndex);
                        DataBaseRepository databaser = new DataBaseRepository();
                        string key = databaser.GetSavedConfig();

                        databaser.RemoveConfig();



                        WeighConfigMaster weighConfigMaster = new WeighConfigMaster { camera = this.cmbCam.Text, device = this.cmbCom.Text, status = key };
                        databaser.InsertConfig(weighConfigMaster);
                        try
                        {
                            if (this.cmbCom.Text != "")
                            {
                                this.mySerialPort = new SerialPort(this.cmbCom.Text);
                                this.mySerialPort.BaudRate = 0x2580;
                                this.mySerialPort.Parity = Parity.None;
                                this.mySerialPort.StopBits = StopBits.One;
                                this.mySerialPort.DataBits = 8;
                                this.mySerialPort.Handshake = Handshake.None;
                                this.mySerialPort.DataReceived += new SerialDataReceivedEventHandler(this.DataReceivedHandler);
                                this.mySerialPort.Open();
                                this.mySerialPort.DtrEnable = true;
                            }
                        }
                        catch (Exception exception1)
                        {
                            MessageBox.Show(exception1.ToString());
                        }
                    }
                    catch
                    {
                    }
                    return;
                }
                else
                {
                    try
                    {
                        pnl_configure.Enabled = true;
                        this.btn_edit.Text = "Update";
                        this.FinalVideo.Stop();
                        if (this.mySerialPort.IsOpen)
                        {
                            this.mySerialPort.Close();
                        }
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.lblMsg.Text = "Please wait... Initiating Ports and Devices...";
                        string[] portNames = SerialPort.GetPortNames();
                        this.cmbCom.Items.Clear();
                        string[] strArray2 = portNames;
                        int index = 0;
                        while (true)
                        {
                            if (index >= strArray2.Length)
                            {
                                FillVideo();
                                break;
                            }
                            string str = strArray2[index];
                            string str2 = "";
                            bool flag3 = str.Length > 5;
                            str2 = !flag3 ? str : str.Substring(0, 5);
                            this.cmbCom.Items.Add(str2);
                            index++;
                        }
                    }
                    catch
                    {
                    }
                }

            }
            catch
            {
            }
        }

        private void txt_weight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.lblMsg.Text = "";
                if (this.txt_weight.Text != "")
                {
                    int num1;
                    char[] separator = new char[] { '.' };
                    if (this.txt_weight.Text.Split(separator)[1].Length < 1)
                    {
                        num1 = 0;
                    }
                    else
                    {
                        char[] chArray2 = new char[] { '.' };
                        num1 = (int)(this.txt_weight.Text.Split(chArray2)[1].Length );
                    }
                    if (num1 == 0)
                    {
                        this.txt_weight.Text = "";
                    }
                    else
                    {
                        char[] chArray3 = new char[] { ' ' };
                        if (!Directory.Exists(Application.StartupPath + @"\resources\" + DateTime.Now.ToString().Split(chArray3)[0]))
                        {
                            char[] chArray4 = new char[] { ' ' };
                            Directory.CreateDirectory(Application.StartupPath + @"\resources\" + DateTime.Now.ToString().Split(chArray4)[0]);
                        }
                        object[] objArray1 = new object[6];
                        objArray1[0] = Application.StartupPath;
                        objArray1[1] = @"\resources\";
                        char[] chArray5 = new char[] { ' ' };
                        objArray1[2] = DateTime.Now.ToString().Split(chArray5)[0];
                        objArray1[3] = @"\";
                        objArray1[4] = DateTime.Now.Ticks;
                        objArray1[5] = ".jpeg";
                        string filename = string.Concat(objArray1);
                        using (Bitmap bitmap = new Bitmap(this.pictureBox1.Image))
                        {
                            bitmap.Save(filename, ImageFormat.Jpeg);
                        }
                        DataBaseRepository databaser = new DataBaseRepository();
                        WeightData weightData= new WeightData { EntryDate = DateTime.Now.ToString(), Picture  = filename, WeightofLoad = txt_weight.Text };
                        databaser.InsertWeightData(weightData);
                        this.mySerialPort.DtrEnable = false;
                        Thread.Sleep(0x3e8);
                        this.mySerialPort.DtrEnable = true;
                        //this.elButton8_Click(this, e);
                    }
                }
            }
            catch (Exception exception)
            {
                this.txt_weight.Text = "";
                this.lblMsg.Text = exception.ToString();
            }
        }

        private void txt_weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                this.txt_weight.Text = "";
                e.Handled = true;
            }
            catch
            {
            }

        }

        private void txt_weight_Leave(object sender, EventArgs e)
        {
            this.txt_weight.Select();
        }
    }
}
