using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace GNet1._0
{


    public partial class SocServer : Form
    {
        NetworkStream NetStream;
        StreamReader ServerReader;
        StreamWriter ServerWriter;
        TcpListener Listner;
        public Socket SocketClient;

        public SocServer()
        {
            InitializeComponent();
        }

        private void SocServer_Load(object sender, EventArgs e)
        {
            
        }

        void ServerGetMessage()
        {
            if (NetStream != null && NetStream.DataAvailable)
            {
                rtxChatInfo.AppendText(ServerReader.ReadLine()+"\n")
            }
        }
        public void BeginLister()
        {
            Listner=new TcpListener(IPAddress.Parse())
        }
        private void btnBeginServer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
