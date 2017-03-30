using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace sockettest
{
    
    class SocServer
    {
        StreamReader NSR;
        StreamWriter FSW;
        NetworkStream NetStream;
        Socket SocketClient;
        TcpListener Listener;
        public void SocServerListen()
        {
            Listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 6000);
            Listener.Start();
            SocketClient = Listener.AcceptSocket();
            NetStream = new NetworkStream(SocketClient);
            NSR = new StreamReader(NetStream);
            Console.Write("listen success\n"); 
        }

        public void txtAccept()
        {
            FSW = new StreamWriter(@"D:\TestFolder\ServerFolder\accept.txt", true, Encoding.Default);
            Console.Write("create success\n");
            while (true)
            {
                if (NetStream != null && NetStream.DataAvailable)
                {
                    FSW.Write(NSR.ReadLine());
                    FSW.Flush();
                    Console.Write("accept success\n");
                    break;
                }
            }
        }

        public void fileAccept()
        {
            FileStream FStream = new FileStream(@"D:\TestFolder\ServerFolder\accept.docx", FileMode.Create, FileAccess.Write);
            while (true)
            {
                if (NetStream != null && NetStream.DataAvailable)
                {
                    byte[] acceptbuffer = new byte[1024 * 1024 * 3];
                    NetStream.Read(acceptbuffer, 0, acceptbuffer.Length);
                    FStream.Write(acceptbuffer, 0, acceptbuffer.Length);
                    FStream.Flush();
                    FStream.Close();
                    Console.Write("accept success\n");
                    break;
                }
            }
        }

    }
}
