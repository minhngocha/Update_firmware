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
        string g_frameSuccess = "###|TPA0123456|CMD=|v|000000|00&&&";
        string g_frameUpdate  = "###|TPA0123456|CMD=|u|000|00&&&";
        char[] tx_array = new char[512];
        public delegate void invokeDelegate();

        Logger log = new Logger("Data_");
        public frmMain()
        {
            InitializeComponent();

            var targetLogFile = new FileInfo("./Server_LogFile.txt");
            Console.WriteLine(targetLogFile.FullName);
            Logger.LogToConsole = false;
            Logger.Start(targetLogFile);
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
            DateTime nowtime = DateTime.Now;
            if (ckB_EnableUpdate.Checked == true)
            {
                tx_array = g_frameSuccess.ToCharArray();
                tx_array[22] = Convert.ToChar(nowtime.Year - 2000);
                tx_array[23] = Convert.ToChar(nowtime.Month);
                tx_array[24] = Convert.ToChar(nowtime.Day);
                tx_array[25] = Convert.ToChar(nowtime.Hour);
                tx_array[26] = Convert.ToChar(nowtime.Minute);
                tx_array[27] = Convert.ToChar(nowtime.Second);
                UInt16 crc = CalculateCRC(tx_array, 3, 26);
                tx_array[29] = (char)(crc / 256);
                tx_array[30] = (char)(crc % 256);
                tcpServer1.Send(tx_array);
                //logData(1, new string(tx_array), Color.DeepPink);

                byte[] bRoot = new byte[34];
                for (int index = 0; index < 34; index++)
                {
                    bRoot[index] = (byte)tx_array[index];
                }
                logData(1, BitConverter.ToString(bRoot), Color.DeepPink);

                if (rdb_ver1.Checked == true)
                {
                    tx_array = g_frameUpdate.ToCharArray();
                    tx_array[22] = (char)0x00;
                    tx_array[23] = (char)0x01;
                    tx_array[24] = (char)0x00;
                    crc = CalculateCRC(tx_array, 3, 23);
                    tx_array[26] = (char)(crc / 256);
                    tx_array[27] = (char)(crc % 256);
                    tcpServer1.Send(tx_array);
                    //logData(1, new string(tx_array), Color.DeepPink);
                    byte[] bRoot1 = new byte[31];
                    for (int index = 0; index < 31; index++)
                    {
                        bRoot1[index] = (byte)tx_array[index];
                    }
                    logData(1, BitConverter.ToString(bRoot1), Color.DeepPink);
                }
                else if (rdb_ver2.Checked == true)
                {
                    tx_array = g_frameUpdate.ToCharArray();
                    tx_array[22] = (char)0x00;
                    tx_array[23] = (char)0x02;
                    tx_array[24] = (char)0x00;
                    crc = CalculateCRC(tx_array, 3, 23);
                    tx_array[26] = (char)(crc / 256);
                    tx_array[27] = (char)(crc % 256);
                    tcpServer1.Send(tx_array);
                    //logData(1, new string(tx_array), Color.DeepPink);
                    byte[] bRoot1 = new byte[31];
                    for (int index = 0; index < 31; index++)
                    {
                        bRoot1[index] = (byte)tx_array[index];
                    }
                    logData(1, BitConverter.ToString(bRoot1), Color.DeepPink);
                }
                else if (rdb_ver3.Checked == true)
                {
                    tx_array = g_frameUpdate.ToCharArray();
                    tx_array[22] = (char)0x00;
                    tx_array[23] = (char)0x03;
                    tx_array[24] = (char)0x00;
                    crc = CalculateCRC(tx_array, 3, 23);
                    tx_array[26] = (char)(crc / 256);
                    tx_array[27] = (char)(crc % 256);
                    tcpServer1.Send(tx_array);
                    //logData(1, new string(tx_array), Color.DeepPink);

                    byte[] bRoot1 = new byte[31];
                    for (int index = 0; index < 31; index++)
                    {
                        bRoot1[index] = (byte)tx_array[index];
                    }
                    logData(1, BitConverter.ToString(bRoot1), Color.DeepPink);
                }
                else if (rdb_ver4.Checked == true)
                {
                    tx_array = g_frameUpdate.ToCharArray();
                    tx_array[22] = (char)0x00;
                    tx_array[23] = (char)0x04;
                    tx_array[24] = (char)0x00;
                    crc = CalculateCRC(tx_array, 3, 23);
                    tx_array[26] = (char)(crc / 256);
                    tx_array[27] = (char)(crc % 256);
                    tcpServer1.Send(tx_array);
                    //logData(1, new string(tx_array), Color.DeepPink);

                    byte[] bRoot1 = new byte[31];
                    for (int index = 0; index < 31; index++)
                    {
                        bRoot1[index] = (byte)tx_array[index];
                    }
                    logData(1, BitConverter.ToString(bRoot1), Color.DeepPink);
                }
            }
            else
            {
                tx_array = g_frameSuccess.ToCharArray();
                tx_array[22] = Convert.ToChar(nowtime.Year - 2000);
                tx_array[23] = Convert.ToChar(nowtime.Month);
                tx_array[24] = Convert.ToChar(nowtime.Day);
                tx_array[25] = Convert.ToChar(nowtime.Hour);
                tx_array[26] = Convert.ToChar(nowtime.Minute);
                tx_array[27] = Convert.ToChar(nowtime.Second);
                UInt16 crc = CalculateCRC(tx_array, 3, 26);
                tx_array[29] = (char) (crc / 256);
                tx_array[30] = (char) (crc % 256);
                tcpServer1.Send(tx_array);
                //logData(1, new string(tx_array), Color.DeepPink);

                byte[] bRoot = new byte[34];
                for (int index = 0; index < 34; index++)
                {
                    bRoot[index] = (byte) tx_array[index];
                }
                logData(1, BitConverter.ToString(bRoot), Color.DeepPink);

                
            }


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

            string bufstr = "";
            if (state == 0)
            {
                bufstr = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " RECEIVED:\r\n";
            }
            else if (state == 1)
            {
                bufstr = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " SENT:\r\n";
            }
            else if (state == 3)
            {
                bufstr = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " Connect form: ";
            }
            else if (state == 4)
            {
                bufstr = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss tt") + " Disonnect form: ";
            }
            /* Add header content */
            txtLog.AppendText(bufstr);
            log.Info(bufstr);
            /* Add main content */
            txtLog.SelectionColor = color;
            txtLog.AppendText(text);
            log.Info(text);
            /* Add character \r\n */
            txtLog.AppendText("\r\n");
            log.Info("\r\n");
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
                    logData(0, BitConverter.ToString(data), Color.Black);
                    if(data[0] == '#' && data[1] == '#' && data[2] == '#' && data[3] == '|')
                    {
                        if(data[20] == 'b')
                        {
                            this.txtVer.Text = "VM_" + data[100].ToString() + "." + data[101].ToString() + 
                             "." + data[102].ToString() + ".bin";
                        }
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

        private UInt16 reflect(UInt16 data, UInt16 bits)
        {
            UInt32 reflection = 0x00000000;
            // Reflect the data about the center bit.
            for (int bit = 0; bit < bits; bit++)
            {
                // If the LSB bit is set, set the reflection of it.
                if ((data & 0x01) != 0)
                {
                    reflection |= (UInt32) (1 << ((bits - 1) - bit));
                }
            }
            return (UInt16) (reflection);
        }

        private UInt16 fastCrc(char[] data, int start, UInt16 length, UInt16 reflectIn, UInt16 reflectOut, UInt16 polynomial, UInt16 xorIn, UInt16 xorOut, UInt16 msbMask, UInt16 mask)
        {
            UInt16 crc = xorIn;

            int j;
            UInt16 c;
            int bit;

            if (length == 0) return crc;

            for (int i = start; i < (start + length); i++)
            {
                c = data[i];

                if (reflectIn != 0)
                    c = (UInt16) reflect(c, 8);

                j = 0x80;

                while (j > 0)
                {
                    bit = (int)(crc & msbMask);
                    crc <<= 1;

                    if ((c & j) != 0)
                    {
                        bit = (int)(bit ^ msbMask);
                    }

                    if (bit != 0)
                    {
                        crc ^= polynomial;
                    }

                   j >>= 1;
                }
            }

            if (reflectOut != 0)
            {
                crc = (UInt16) ((reflect(crc, 32) ^ (UInt16)xorOut) & (UInt16)mask);
            }

            return crc;
        }
private UInt16 CalculateCRC(char[] array, UInt16 posStart, UInt16 length)
        {
            return fastCrc(array, posStart, length, 0, 0, 0x1021, 0x0000, 0x0000, 0x8000, 0xffff);
        }
    }
}
