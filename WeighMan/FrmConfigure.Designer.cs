namespace WeighMan
{
    partial class FrmConfigure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.btnCom = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_bottom.SuspendLayout();
            this.pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(920, 39);
            this.pnl_top.TabIndex = 0;
            // 
            // pnl_bottom
            // 
            this.pnl_bottom.Controls.Add(this.lblMsg);
            this.pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bottom.Location = new System.Drawing.Point(0, 415);
            this.pnl_bottom.Name = "pnl_bottom";
            this.pnl_bottom.Size = new System.Drawing.Size(920, 35);
            this.pnl_bottom.TabIndex = 1;
            // 
            // pnl_left
            // 
            this.pnl_left.Controls.Add(this.pictureBox1);
            this.pnl_left.Controls.Add(this.btnCom);
            this.pnl_left.Controls.Add(this.btnVideo);
            this.pnl_left.Controls.Add(this.cmbCom);
            this.pnl_left.Controls.Add(this.label2);
            this.pnl_left.Controls.Add(this.cmbCam);
            this.pnl_left.Controls.Add(this.label1);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 39);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(239, 376);
            this.pnl_left.TabIndex = 2;
            // 
            // btnCom
            // 
            this.btnCom.Location = new System.Drawing.Point(86, 130);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(97, 23);
            this.btnCom.TabIndex = 11;
            this.btnCom.Text = "button2";
            this.btnCom.UseVisualStyleBackColor = true;
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(86, 40);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(97, 23);
            this.btnVideo.TabIndex = 10;
            this.btnVideo.Text = "button1";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(86, 92);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(121, 21);
            this.cmbCom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weigh Scale";
            // 
            // cmbCam
            // 
            this.cmbCam.FormattingEnabled = true;
            this.cmbCam.Location = new System.Drawing.Point(86, 13);
            this.cmbCam.Name = "cmbCam";
            this.cmbCam.Size = new System.Drawing.Size(121, 21);
            this.cmbCam.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Camera";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(86, 10);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(35, 13);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 163);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Name = "FrmConfigure";
            this.Text = "FrmConfigure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfigure_FormClosing);
            this.Shown += new System.EventHandler(this.FrmConfigure_Shown);
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.pnl_left.ResumeLayout(false);
            this.pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}