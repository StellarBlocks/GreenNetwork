using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace GNet1._0
{
    class NetSoc
    {
        public TcpClient TcpClient;
        NetworkStream Stream;
        StreamReader ClientReader;
        StreamWriter ClientWriter;


        public string GetMessage()
        {
            string mess;
            if (Stream != null && Stream.DataAvailable)
            {
                mess = ClientReader.ReadLine();
                return mess;
            }
            else
                return null;         
        }

        public void ClientSocInit(string ip, int port)
        {
            TcpClient = new TcpClient(ip, port);
            Stream = TcpClient.GetStream();
            ClientReader = new StreamReader(Stream);
            ClientWriter = new StreamWriter(Stream);
        }

        public bool SendSocket(string sss)
        {
            try
            {
                ClientWriter.WriteLine(sss);
                ClientWriter.Flush();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
