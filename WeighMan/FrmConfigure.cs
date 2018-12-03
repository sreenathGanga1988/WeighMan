using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }


        public FilterInfoCollection getvideodevices()
        {
            this.VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            return this.VideoCaptureDevices;
        }

        public void FillVideo()
        {
            foreach (FilterInfo info in this.getvideodevices())
            {
                this.cmbCam.Items.Add(info.Name);
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
                
              
               
                this.lblMsg .Text = "Please wait... Initiating Ports and Devices...";
                DataBaseRepository databaser = new DataBaseRepository();

                List<WeighMan.Model.WeighConfigMaster> weighConfigMasters = databaser.GetConfigDet();
              
                if (weighConfigMasters.Count > 0)
                {
                    this.cmbCam.SelectedValue = weighConfigMasters.FirstOrDefault().camera;
                    this.cmbCom .SelectedValue = weighConfigMasters.FirstOrDefault().device ;
                }
                else
                {
                    this.cmbCam.SelectedIndex = 0;
                    this.cmbCom.SelectedIndex = 0;
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
                //set = this.db.check("Select status from config", "config");
                //string mACAddress = GetMACAddress();
                //if (set.Tables[0].Rows.Count <= 0)
                //{
                //    new Form2().ShowDialog();
                //    MessageBox.Show("License Authentication Failed...");
                //    Application.Exit();
                //}
                //else if (mACAddress != set.Tables[0].Rows[0][0].ToString())
                //{
                //    MessageBox.Show("Invalid License... Contact Azinova...");
                //    new Form2().ShowDialog();
                //    MessageBox.Show("License Authentication Failed...");
                //    Application.Exit();
                //}
            }
            catch
            {
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











    
private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string indata = ((SerialPort)sender).ReadLine();
                if ((indata.Trim() != "") && (indata.Trim().Length > 2))
                {
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



    }
}
