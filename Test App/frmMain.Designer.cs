namespace testerApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangePort = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdleTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxThreads = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAttempts = new System.Windows.Forms.TextBox();
            this.lblConnected = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtValidateInterval = new System.Windows.Forms.TextBox();
            this.ckB_EnableUpdate = new System.Windows.Forms.CheckBox();
            this.rdb_ver1 = new System.Windows.Forms.RadioButton();
            this.rdb_ver2 = new System.Windows.Forms.RadioButton();
            this.rdb_ver3 = new System.Windows.Forms.RadioButton();
            this.rdb_ver4 = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.tcpServer1 = new tcpServer.TcpServer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(12, 403);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(322, 91);
            this.txtText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Broadcast Text";
            // 
            // txtPort
            // 
            this.txtPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPort.Location = new System.Drawing.Point(66, 531);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(58, 20);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "32000";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tcp Port";
            // 
            // btnChangePort
            // 
            this.btnChangePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangePort.Location = new System.Drawing.Point(521, 529);
            this.btnChangePort.Name = "btnChangePort";
            this.btnChangePort.Size = new System.Drawing.Size(74, 23);
            this.btnChangePort.TabIndex = 13;
            this.btnChangePort.Text = "Change";
            this.btnChangePort.UseVisualStyleBackColor = true;
            this.btnChangePort.Click += new System.EventHandler(this.btnChangePort_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(343, 449);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(93, 35);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(601, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "TCP server status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(112, 505);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 13);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "PORT NOT OPEN";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Idle Time";
            // 
            // txtIdleTime
            // 
            this.txtIdleTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIdleTime.Location = new System.Drawing.Point(186, 531);
            this.txtIdleTime.Name = "txtIdleTime";
            this.txtIdleTime.Size = new System.Drawing.Size(47, 20);
            this.txtIdleTime.TabIndex = 26;
            this.txtIdleTime.Text = "50";
            this.txtIdleTime.TextChanged += new System.EventHandler(this.txtIdleTime_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Max Threads";
            // 
            // txtMaxThreads
            // 
            this.txtMaxThreads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMaxThreads.Location = new System.Drawing.Point(314, 531);
            this.txtMaxThreads.Name = "txtMaxThreads";
            this.txtMaxThreads.Size = new System.Drawing.Size(50, 20);
            this.txtMaxThreads.TabIndex = 28;
            this.txtMaxThreads.Text = "100";
            this.txtMaxThreads.TextChanged += new System.EventHandler(this.txtMaxThreads_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Max Send Attempts";
            // 
            // txtAttempts
            // 
            this.txtAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAttempts.Location = new System.Drawing.Point(475, 502);
            this.txtAttempts.Name = "txtAttempts";
            this.txtAttempts.Size = new System.Drawing.Size(40, 20);
            this.txtAttempts.TabIndex = 30;
            this.txtAttempts.Text = "3";
            this.txtAttempts.TextChanged += new System.EventHandler(this.txtAttempts_TextChanged);
            // 
            // lblConnected
            // 
            this.lblConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblConnected.AutoSize = true;
            this.lblConnected.BackColor = System.Drawing.SystemColors.Control;
            this.lblConnected.Location = new System.Drawing.Point(340, 505);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(13, 13);
            this.lblConnected.TabIndex = 32;
            this.lblConnected.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Connected clients:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 534);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Validate Interval";
            // 
            // txtValidateInterval
            // 
            this.txtValidateInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtValidateInterval.Location = new System.Drawing.Point(475, 531);
            this.txtValidateInterval.Name = "txtValidateInterval";
            this.txtValidateInterval.Size = new System.Drawing.Size(40, 20);
            this.txtValidateInterval.TabIndex = 34;
            this.txtValidateInterval.Text = "100";
            this.txtValidateInterval.TextChanged += new System.EventHandler(this.txtValidateInterval_TextChanged);
            // 
            // ckB_EnableUpdate
            // 
            this.ckB_EnableUpdate.AutoSize = true;
            this.ckB_EnableUpdate.Location = new System.Drawing.Point(547, 403);
            this.ckB_EnableUpdate.Name = "ckB_EnableUpdate";
            this.ckB_EnableUpdate.Size = new System.Drawing.Size(97, 17);
            this.ckB_EnableUpdate.TabIndex = 36;
            this.ckB_EnableUpdate.Text = "Enable Update";
            this.ckB_EnableUpdate.UseVisualStyleBackColor = true;
            // 
            // rdb_ver1
            // 
            this.rdb_ver1.AutoSize = true;
            this.rdb_ver1.Checked = true;
            this.rdb_ver1.Location = new System.Drawing.Point(442, 435);
            this.rdb_ver1.Name = "rdb_ver1";
            this.rdb_ver1.Size = new System.Drawing.Size(88, 17);
            this.rdb_ver1.TabIndex = 37;
            this.rdb_ver1.TabStop = true;
            this.rdb_ver1.Text = "VM_0.1.0.bin";
            this.rdb_ver1.UseVisualStyleBackColor = true;
            // 
            // rdb_ver2
            // 
            this.rdb_ver2.AutoSize = true;
            this.rdb_ver2.Location = new System.Drawing.Point(442, 461);
            this.rdb_ver2.Name = "rdb_ver2";
            this.rdb_ver2.Size = new System.Drawing.Size(88, 17);
            this.rdb_ver2.TabIndex = 38;
            this.rdb_ver2.TabStop = true;
            this.rdb_ver2.Text = "VM_0.2.0.bin";
            this.rdb_ver2.UseVisualStyleBackColor = true;
            // 
            // rdb_ver3
            // 
            this.rdb_ver3.AutoSize = true;
            this.rdb_ver3.Location = new System.Drawing.Point(547, 433);
            this.rdb_ver3.Name = "rdb_ver3";
            this.rdb_ver3.Size = new System.Drawing.Size(88, 17);
            this.rdb_ver3.TabIndex = 39;
            this.rdb_ver3.TabStop = true;
            this.rdb_ver3.Text = "VM_0.3.0.bin";
            this.rdb_ver3.UseVisualStyleBackColor = true;
            // 
            // rdb_ver4
            // 
            this.rdb_ver4.AutoSize = true;
            this.rdb_ver4.Location = new System.Drawing.Point(547, 461);
            this.rdb_ver4.Name = "rdb_ver4";
            this.rdb_ver4.Size = new System.Drawing.Size(88, 17);
            this.rdb_ver4.TabIndex = 40;
            this.rdb_ver4.Text = "VM_0.4.0.bin";
            this.rdb_ver4.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 25);
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(664, 359);
            this.txtLog.TabIndex = 41;
            this.txtLog.Text = "";
            // 
            // tcpServer1
            // 
            this.tcpServer1.Encoding = ((System.Text.Encoding)(resources.GetObject("tcpServer1.Encoding")));
            this.tcpServer1.IdleTime = 50;
            this.tcpServer1.IsOpen = false;
            this.tcpServer1.MaxCallbackThreads = 100;
            this.tcpServer1.MaxSendAttempts = 3;
            this.tcpServer1.Port = -1;
            this.tcpServer1.VerifyConnectionInterval = 0;
            this.tcpServer1.OnConnect += new tcpServer.tcpServerConnectionChanged(this.tcpServer1_OnConnect);
            this.tcpServer1.OnDataAvailable += new tcpServer.tcpServerConnectionChanged(this.tcpServer1_OnDataAvailable);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(343, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 35);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 564);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.rdb_ver4);
            this.Controls.Add(this.rdb_ver3);
            this.Controls.Add(this.rdb_ver2);
            this.Controls.Add(this.rdb_ver1);
            this.Controls.Add(this.ckB_EnableUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValidateInterval);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAttempts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxThreads);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdleTime);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnChangePort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(696, 461);
            this.Name = "frmMain";
            this.Text = "TCP Server Simulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private tcpServer.TcpServer tcpServer1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangePort;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdleTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxThreads;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAttempts;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValidateInterval;
        private System.Windows.Forms.CheckBox ckB_EnableUpdate;
        private System.Windows.Forms.RadioButton rdb_ver1;
        private System.Windows.Forms.RadioButton rdb_ver2;
        private System.Windows.Forms.RadioButton rdb_ver3;
        private System.Windows.Forms.RadioButton rdb_ver4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnClear;
    }
}

