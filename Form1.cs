using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Update_firmware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /* Start form */
            txt_port.Text = "32000";
        }

        public TcpListener listener;
        public TcpClient client;
        Thread newThread1;
        private void Btn_listen_Click(object sender, EventArgs e)
        {
            /* change state button & text box */
            btn_stop.Enabled = true;
            btn_listen.Enabled = false;
            txt_port.Enabled = false;
            grB2.Enabled = true;
            /* information */
            AppendText("Start listen with port " + txt_port.Text.ToString() + "\r\n", Color.LimeGreen);
            listener = new TcpListener(IPAddress.Any, Convert.ToInt32(txt_port.Text));
            listener.Start();
            newThread1 = new Thread(new ThreadStart(listen_client));
            newThread1.Start();
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            /* change state button & text box */
            btn_stop.Enabled = false;
            btn_listen.Enabled = true;
            txt_port.Enabled = true;
            grB2.Enabled = false;
            /* information */
            listener.Stop();
            if (newThread1.IsAlive)
            {
                newThread1.Abort();
            }
            newThread1 = null;
            try
            {
                client.Close();
            }
            catch
            {

            }
            AppendText("Stop listen with port " + txt_port.Text.ToString() + "\r\n", Color.LimeGreen);
           
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            rtxt_data.Clear();
        }

        private void AppendText(string text, Color color)
        {
            rtxt_data.SelectionStart = rtxt_data.TextLength;
            rtxt_data.SelectionLength = 0;
            rtxt_data.SelectionColor = color;
            rtxt_data.AppendText(text);
            rtxt_data.SelectionColor = rtxt_data.ForeColor;
            rtxt_data.ScrollToCaret();
        }

        private void listen_client()
        {
            int length;
            char[] rx_array = new char[512];
            client = listener.AcceptTcpClient();
            this.Invoke(new MethodInvoker(delegate ()
            {
                string client_connect = client.Client.RemoteEndPoint.ToString() +" : Client is connected \r\n";
                AppendText(client_connect, Color.LimeGreen);
            }));
            
            while (client.Connected)
            {
                
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                
                sw.AutoFlush = true;
                try
                {
                    length = client.Available;
                    if (length > 0)
                    {
                        Array.Clear(rx_array, 0, 128);
                        sr.Read(rx_array, 0, length);
                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            AppendText(new string(rx_array) + "\r\n", Color.DeepPink);
                        }));
                        if(rx_array[0] == '#' && rx_array[1] == '#' && rx_array[2] == '#' && rx_array[3] == '|' && rx_array[4] == 'T' &&
                           rx_array[5] == 'P' && rx_array[6] == 'A' && rx_array[7] == '0' && rx_array[8] == '1' && rx_array[9] == '2' )
                        {
                            if(chb_update.Checked == true)
                            {
                                if(txt_firm.Text != "")
                                {
                                    string update_mess = "SUCCESS&UPDATE:" + txt_firm.Text + "$";
                                    sw.Write(update_mess);
                                    this.Invoke(new MethodInvoker(delegate ()
                                    {
                                        AppendText("\r\nTX:" + update_mess, Color.Black);
                                    }));
                                }
                                else
                                {
                                    sw.Write("SUCCESS");
                                    this.Invoke(new MethodInvoker(delegate ()
                                    {
                                        AppendText("\r\nTX: SUCCESS" + "\r\n", Color.Black);
                                        AppendText("ERROR: Name File\r\n", Color.Red);
                                    }));
                                }
                                
                            }
                            else
                            {
                                sw.Write("SUCCESS");
                                this.Invoke(new MethodInvoker(delegate ()
                                {
                                    AppendText("\r\nTX: SUCCESS" + "\r\n", Color.Black);
                                }));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                Thread.Sleep(50);
            }
            client.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newThread1.IsAlive)
            {
                newThread1.Abort();
            }
            newThread1 = null;
            listener.Stop();
            //client.Close();
        }
    }
}
