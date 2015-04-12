using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lemniscate
{
    public partial class Form1 : Form
    {
        
        Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
        static IPAddress ip = null;
        static Int32 port = 0;
        static bool connected = false;
        static bool firstTime = true;
        string name = null;


        public Form1()
        {
            InitializeComponent();
        }
       
        private void keyDown (object sender, KeyEventArgs e ) {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
        private void appendTextbox (string x) {
            textBox1.AppendText(x);
            textBox1.AppendText("\n");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            textBox2.KeyDown += new KeyEventHandler(keyDown);
        }
        private void listening()
        {
            while (true)
            {
                
                
                byte[] data = new byte[1024];
                try
                {
                    if (!connected)
                    {
                        break;
                    }
                    else
                    {
                        int recv = server.Receive(data);
                        string x = Encoding.ASCII.GetString(data, 0, recv);
                        if (x.Contains("userUpdate"))
                        {
                            textBox3.Text = "";
                            while (true)
                            {
                                byte[] datas = new byte[1024];
                                int recvs = server.Receive(datas);
                                string xs = Encoding.ASCII.GetString(datas, 0, recvs);
                                
                                if (xs.Contains("stop"))
                                {
                                    break;
                                }
                                else {
                                    if (xs.Contains(name))
                                    {
                                        textBox3.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Bold);
                                    }
                                    textBox3.AppendText(xs);
                                    textBox3.AppendText("\n");
                                    textBox3.Font = new System.Drawing.Font(textBox1.Font, System.Drawing.FontStyle.Regular);
                                }
                            }
                        }
                        else
                        {
                            appendTextbox(x);
                        }

                    }
                }
                catch (Exception e)
                {
                    connected = false;
                    appendTextbox("Connection with the server disconnected");
                    break;
                }
            }
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!connected)
            {
                appendTextbox("You're not connected to a server! Press the 'connect to a server' button to connect to a server");
            }
            else
            {
                byte[] data = Encoding.ASCII.GetBytes(textBox2.Text);
                server.Send(data);
                if (!firstTime)
                {
                    
                }
                else
                {
                    name = textBox2.Text;
                    firstTime = false;
                }
            }
            textBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                try
                {
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    string iprotocol = Microsoft.VisualBasic.Interaction.InputBox("Enter the IP of the server", "Internet Protocol", "IP Goes Here!", -1, -1);
                    string portlol = Microsoft.VisualBasic.Interaction.InputBox("Enter port of the server");
                    int xxx = Int32.Parse(portlol);
                    ip = IPAddress.Parse(iprotocol);
                    port = xxx;
                    appendTextbox("Attempting to connect to " + xxx + ":" + portlol);
                    server.Connect(ip, port);
                    textBox1.Text = "";
                    appendTextbox("Successfully connected to " + xxx + ":" + portlol);
                    Thread x = new Thread(new ThreadStart(listening));
                    x.Start();
                    button2.Text = "Disconnect";
                    connected = true;
                }
                catch (Exception xx)
                {
                    textBox1.AppendText("Can't connect to server");
                    textBox1.AppendText("\n");
                }
            }
            else
            {
                connected = false;
                button2.Text = "Connect to a server";
                textBox3.Text = "";
                server.Close();
            }
            
        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nsButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
