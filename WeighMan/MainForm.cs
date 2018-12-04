using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeighMan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSetting frmset = new FrmSetting();
            frmset.Show();              
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            FrmConfigure cnfgr = new FrmConfigure();
            cnfgr.Show();
        }

        private void btn_misreport_Click(object sender, EventArgs e)
        {
            new FrmAuth().ShowDialog();
        }
    }
}
