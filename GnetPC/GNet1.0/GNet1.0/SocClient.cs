using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace GNet1._0
{
    public partial class SocClient : Form
    {
        NetSoc ClientSocket = new NetSoc();
        Thread Thd;
        public SocClient()
        {
            InitializeComponent();
        }

        private void txtServerPort_TextChanged(object sender, EventArgs e)
        {

        }
        
        void GetConn()
        {
            CheckForIllegalCrossThreadCalls = false;
            while(true)
                {
                try
                {
                    ClientSocket.ClientSocInit(txtServerIp.Text, int.Parse(txtServerPort.Text.Trim()));
                    txtServerIp.Enabled = false;
                    txtServerPort.Enabled = false;
                    this.Text = "客户端   " + "正在与" + txtServerIp.Text.Trim() + "连接.....";
                    return;
                }
                catch(Exception e)
                {
                    txtServerIp.Enabled = true;
                    txtServerPort.Enabled = true;
                    this.Text = "客户端连接失败";
                    Console.WriteLine(e);
                }
                }
        }

        void ClientGetMessage()
        {
            string sss;
            if ((sss = ClientSocket.GetMessage()) != null)
            {
                rtxChatInfo.AppendText(DateTime.Now.ToString());
                rtxChatInfo.AppendText("服务器说：\n");
                rtxChatInfo.AppendText(sss + "\n");
                rtxChatInfo.SelectionStart = rtxChatInfo.Text.Length;
                rtxChatInfo.Focus();
                rtxSendMessage.Focus();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thd = new Thread(new ThreadStart(GetConn));
            Thd.Start();
        }


        private void tmrGetMess_Tick(object sender, EventArgs e)
        {
            ClientGetMessage();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (ClientSocket.SendSocket(rtxSendMessage.Text))
            {
                rtxChatInfo.AppendText(DateTime.Now.ToString());
                rtxChatInfo.AppendText("客户端说：\n");
                rtxChatInfo.AppendText(rtxSendMessage.Text + "\n");
                rtxSendMessage.Clear();
                //下拉框
                rtxChatInfo.SelectionStart = rtxChatInfo.Text.Length;
                rtxChatInfo.Focus();
                rtxSendMessage.Focus();
                ClientGetMessage();
                return;
            }
            else
            {
                txtServerIp.Enabled = true;
                txtServerPort.Enabled = true;
                this.Text = "连接失败......";
                return;
            }
        }

        private void rtxSendMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
