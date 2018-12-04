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
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_bottom = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.pnl_configure = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVideo = new System.Windows.Forms.Button();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            this.pnl_bottom.SuspendLayout();
            this.pnl_left.SuspendLayout();
            this.pnl_configure.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_top.Controls.Add(this.label4);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(920, 39);
            this.pnl_top.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(351, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Weigh Man";
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
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(86, 10);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(35, 13);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "label3";
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnl_left.Controls.Add(this.btn_edit);
            this.pnl_left.Controls.Add(this.pnl_configure);
            this.pnl_left.Controls.Add(this.pnlWeight);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 39);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(239, 376);
            this.pnl_left.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(68, 139);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(97, 23);
            this.btn_edit.TabIndex = 15;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pnl_configure
            // 
            this.pnl_configure.Controls.Add(this.panel1);
            this.pnl_configure.Controls.Add(this.label1);
            this.pnl_configure.Controls.Add(this.cmbCam);
            this.pnl_configure.Controls.Add(this.label2);
            this.pnl_configure.Controls.Add(this.btnVideo);
            this.pnl_configure.Controls.Add(this.cmbCom);
            this.pnl_configure.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_configure.Enabled = false;
            this.pnl_configure.Location = new System.Drawing.Point(0, 0);
            this.pnl_configure.Name = "pnl_configure";
            this.pnl_configure.Size = new System.Drawing.Size(239, 133);
            this.pnl_configure.TabIndex = 14;
            this.pnl_configure.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_configure_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 28);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(351, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Weigh Man";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Camera";
            // 
            // cmbCam
            // 
            this.cmbCam.FormattingEnabled = true;
            this.cmbCam.Location = new System.Drawing.Point(86, 34);
            this.cmbCam.Name = "cmbCam";
            this.cmbCam.Size = new System.Drawing.Size(121, 21);
            this.cmbCam.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Weigh Scale";
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(86, 61);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(97, 23);
            this.btnVideo.TabIndex = 10;
            this.btnVideo.Text = "Setting";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(86, 90);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(121, 21);
            this.cmbCom.TabIndex = 9;
            // 
            // pnlWeight
            // 
            this.pnlWeight.Controls.Add(this.txt_weight);
            this.pnlWeight.Controls.Add(this.label3);
            this.pnlWeight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlWeight.Location = new System.Drawing.Point(0, 310);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(239, 66);
            this.pnlWeight.TabIndex = 13;
            // 
            // txt_weight
            // 
            this.txt_weight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.Location = new System.Drawing.Point(0, 23);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(239, 22);
            this.txt_weight.TabIndex = 1;
            this.txt_weight.TextChanged += new System.EventHandler(this.txt_weight_TextChanged);
            this.txt_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_weight_KeyPress);
            this.txt_weight.Leave += new System.EventHandler(this.txt_weight_Leave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(239, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 304);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_bottom);
            this.Controls.Add(this.pnl_top);
            this.Name = "FrmConfigure";
            this.Text = "FrmConfigure";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfigure_FormClosing);
            this.Shown += new System.EventHandler(this.FrmConfigure_Shown);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.pnl_bottom.ResumeLayout(false);
            this.pnl_bottom.PerformLayout();
            this.pnl_left.ResumeLayout(false);
            this.pnl_configure.ResumeLayout(false);
            this.pnl_configure.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlWeight.ResumeLayout(false);
            this.pnlWeight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bottom;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Panel pnlWeight;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_configure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_edit;
    }
}