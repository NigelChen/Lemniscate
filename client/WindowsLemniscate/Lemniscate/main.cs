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
<<<<<<< HEAD
using System.Drawing;
=======
>>>>>>> ca98241b982dd3a61bf59a6cc5ed498c5ed3e2aa

/*
 * By Nigel Chen
 * 2015
 * Feel free to distribute/modify the code however you want
 * */
namespace Lemniscate
{
    public partial class Form1 : Form
    {
        
<<<<<<< HEAD
        Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp); //Socket - where all the magic happens :P
        static IPAddress ip = null; //Host IP
        static Int32 port = 0;  //Port
        static bool connected = false; //Determines if there is a connection with a server.
        static bool firstTime = true; //Used for determining the name of the client.
        static bool firstJuan = true; //Used for determining the server code. Boolean to determine if it's the first time the client connects.
        string name = null;
        string serverCode = null; //The connected server's code.
=======
        Socket server = new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
        static IPAddress ip = null;
        static Int32 port = 0;
        static bool connected = false;
        static bool firstTime = true;
        string name = null;

>>>>>>> ca98241b982dd3a61bf59a6cc5ed498c5ed3e2aa

        
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
            textBox2.ReadOnly = true;
        }
        private void listening()
        {
            button2.Enabled = true;
            button1.Enabled = true;
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
                        
                        if (x.Contains("userUpdate") && x.Contains(serverCode))
                        {
                            
                            textBox3.Text = "";
                            while (true)
                            {
                                byte[] datas = new byte[1024];
                                int recvs = server.Receive(datas);
                                string xs = Encoding.ASCII.GetString(datas, 0, recvs);
                                
<<<<<<< HEAD
                                if (xs.Contains("stop") && x.Contains(serverCode))
                                {
                                    break;
                                }
                                else if (xs.Replace(" ", "").Equals(name))
                                {
                                    textBox3.SelectionStart = 0;
                                    textBox3.SelectionLength = name.Length;
                                    textBox3.SelectionFont = new Font(textBox3.Font, FontStyle.Bold);
                                    textBox3.AppendText(xs);
                                    textBox3.AppendText("\n");
                                }
                                else
                                {
                                    textBox3.AppendText(xs);
                                    textBox3.AppendText("\n");
=======
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
>>>>>>> ca98241b982dd3a61bf59a6cc5ed498c5ed3e2aa
                                }
                            }
                        }
                        else if (firstJuan)
                        {
                            serverCode = x;
                            firstJuan = false;
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
                    button2.Text = "Connect to a server";
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
        private void connect()
        {
            textBox2.ReadOnly = true;
            button2.Enabled = false;
            button1.Enabled = false;
            button2.Text = "Connecting...";
            server.Connect(ip, port);
            connected = true;
            textBox2.ReadOnly = false;
            textBox1.Text = "";
            if (connected)
            {
                Thread x = new Thread(new ThreadStart(listening));
                x.Start();
                button2.Text = "Disconnect";
            }
            
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
                    appendTextbox("Attempting to connect to " + iprotocol + ":" + portlol);
                    Thread startConnect = new Thread(new ThreadStart(connect));
                    startConnect.Start();
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
<<<<<<< HEAD
            server.Close();
=======
>>>>>>> ca98241b982dd3a61bf59a6cc5ed498c5ed3e2aa
            Application.Exit();
        }

        private void nsButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
