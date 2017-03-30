using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace sockettest
{
    class SocClient
    {
        TcpClient client;
        NetworkStream NetStream;


        public void SocClientTxtSend()
        {
            client = new TcpClient("127.0.0.1", 6000);
            NetStream = client.GetStream();
            Console.Write("connectSuccess\n");
            StreamReader FSR = new StreamReader(@"D:\TestFolder\ClientFolder\test.txt", Encoding.Default);
            StreamWriter NSW = new StreamWriter(NetStream);
            NSW.WriteLine(FSR.ReadLine());
            NSW.Flush();
            Console.Write("sendSuccess\n");
        }

        public void SocClientFileSend()
        {
            client = new TcpClient("127.0.0.1", 6000);
            NetStream = client.GetStream();
            Console.Write("connectSuccess\n");
            FileStream FStream = new FileStream(@"D:\TestFolder\ClientFolder\txt.docx", FileMode.Open,FileAccess.Read);
            StreamWriter NSW = new StreamWriter(NetStream);
            Console.Write("createStreamSuccess\n");
            int lg = (int)FStream.Length;
            byte[] arrFileData = new byte[1024 * 1024 * 3];
            FStream.Read(arrFileData, 0, lg);
            NetStream.Write(arrFileData, 0, lg);
            NetStream.Flush();
            NetStream.Close();
            Console.Write("sendSuccess\n");
        }


        
    }
}
