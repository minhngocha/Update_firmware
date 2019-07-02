/****************************************************************
 * This work is original work authored by Craig Baird, released *
 * under the Code Project Open Licence (CPOL) 1.02;             *
 * http://www.codeproject.com/info/cpol10.aspx                  *
 * This work is provided as is, no guarentees are made as to    *
 * suitability of this work for any specific purpose, use it at *
 * your own risk.                                               *
 * This product is not intended for use in any form except      *
 * learning. The author recommends only using small sections of *
 * code from this project when integrating the attacked         *
 * TcpServer project into your own project.                     *
 * This product is not intended for use for any comercial       *
 * purposes, however it may be used for such purposes.          *
 ****************************************************************/

using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace testerApp
{
    public partial class frmMain : Form
    {
        public delegate void invokeDelegate();

        public frmMain()
        {
            InitializeComponent();
        }

        int count_connect = 0;
        private void btnChangePort_Click(object sender, EventArgs e)
        {
            try
            {
                openTcpPort();
            }
            catch (FormatException)
            {
                MessageBox.Show("Port must be an integer", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Port is too large", "Invalid Port", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void openTcpPort()
        {
            tcpServer1.Close();
            tcpServer1.Port = Convert.ToInt32(txtPort.Text);
            txtPort.Text = tcpServer1.Port.ToString();
            tcpServer1.Open();
            displayTcpServerStatus();
        }

        private void displayTcpServerStatus()
        {
            if (tcpServer1.IsOpen)
            {
                lblStatus.Text = "PORT OPEN";
                lblStatus.BackColor = Color.Lime;
            }
            else
            {
                lblStatus.Text = "PORT NOT OPEN";
                lblStatus.BackColor = Color.Red;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            send();
        }

        private void response()
        {
            string data = "";
            if (ckB_EnableUpdate.Checked == true)
            {
                if(rdb_ver1.Checked == true)
                {
                    data = "SUCCESS&UPDATE:" + rdb_ver1.Text.ToString() + "$";
                }
                else if (rdb_ver2.Checked == true)
                {
                    data = "SUCCESS&UPDATE:" + rdb_ver2.Text.ToString() + "$";
                }
                else if (rdb_ver3.Checked == true)
                {
                    data = "SUCCESS&UPDATE:" + rdb_ver3.Text.ToString() + "$";
                }
                else if (rdb_ver4.Checked == true)
                {
                    data = "SUCCESS&UPDATE:" + rdb_ver4.Text.ToString() + "$";
                }
            }
            else
            {
                data = "SUCCESS";
            }

            tcpServer1.Send(data);

            logData(1, data, Color.DeepPink);
        }
        private void send()
        {
            string data = "";

            foreach (string line in txtText.Lines)
            {
                data = data + line.Replace("\r", "").Replace("\n", "") + "\r\n";
            }
            data = data.Substring(0, data.Length - 2);

            tcpServer1.Send(data);

            logData(1, data, Color.DeepPink);
        }

        public void logData(int state, string text, Color color)
        {
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.SelectionLength = 0;
            txtLog.SelectionColor = color;
            //txtLog.AppendText(tcpServer1.Connections.ip);
            if (state == 0)
            {
                txtLog.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " RECEIVED:\r\n");
            }
            else if (state == 1)
            {
                txtLog.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " SENT:\r\n");
            }
            else if (state == 3)
            {
                txtLog.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " Connect form: ");
            }
            else if (state == 4)
            {
                txtLog.AppendText(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " Disonnect form: ");
            }
            txtLog.SelectionColor = color;
            txtLog.AppendText(text);
            txtLog.AppendText("\r\n");
            if (txtLog.Lines.Length > 500)
            {
                string[] temp = new string[500];
                Array.Copy(txtLog.Lines, txtLog.Lines.Length - 500, temp, 0, 500);
                txtLog.Lines = temp;
            }
            txtLog.SelectionColor = txtLog.ForeColor;
            txtLog.ScrollToCaret();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            tcpServer1.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnChangePort_Click(null, null);

            timer1.Enabled = true;
        }

        private void tcpServer1_OnDataAvailable(tcpServer.TcpServerConnection connection)
        {
            byte[] data = readStream(connection.Socket);
            if (data != null)
            {
                string dataStr = Encoding.ASCII.GetString(data);

                invokeDelegate del = () =>
                {
                    logData(0, dataStr, Color.Black);
                    if(data[0] == '#' && data[1] == '#' && data[2] == '#' && data[3] == '|')
                    {
                        response();
                    }
                    
                };
                Invoke(del);

                data = null;
            }
        }

        protected byte[] readStream(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            if (stream.DataAvailable)
            {
                byte[] data = new byte[client.Available];

                int bytesRead = 0;
                try
                {
                    bytesRead = stream.Read(data, 0, data.Length);
                }
                catch (IOException)
                {
                }

                if (bytesRead < data.Length)
                {
                    byte[] lastData = data;
                    data = new byte[bytesRead];
                    Array.ConstrainedCopy(lastData, 0, data, 0, bytesRead);
                }
                return data;
            }
            return null;
        }

        private void tcpServer1_OnConnect(tcpServer.TcpServerConnection connection)
        {
            invokeDelegate setText = () => lblConnected.Text = tcpServer1.Connections.Count.ToString();
            Invoke(setText);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayTcpServerStatus();
            lblConnected.Text = tcpServer1.Connections.Count.ToString();
            if (tcpServer1.Connections.Count > count_connect)
            {
                count_connect = tcpServer1.Connections.Count;
                logData(3,tcpServer1.connections[count_connect - 1 ].m_socket.Client.RemoteEndPoint.ToString(), Color.LimeGreen);
            }
            else
            {
                count_connect = tcpServer1.Connections.Count;
            }
        }

        private void txtIdleTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(txtIdleTime.Text);
                tcpServer1.IdleTime = time;
            }
            catch (FormatException) { }
            catch (OverflowException) { }
        }

        private void txtMaxThreads_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int threads = Convert.ToInt32(txtMaxThreads.Text);
                tcpServer1.MaxCallbackThreads = threads;
            }
            catch (FormatException) { }
            catch (OverflowException) { }
        }

        private void txtAttempts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int attempts = Convert.ToInt32(txtAttempts.Text);
                tcpServer1.MaxSendAttempts = attempts;
            }
            catch (FormatException) { }
            catch (OverflowException) { }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void txtValidateInterval_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int interval = Convert.ToInt32(txtValidateInterval.Text);
                tcpServer1.VerifyConnectionInterval = interval;
            }
            catch (FormatException) { }
            catch (OverflowException) { }
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }
    }
}
