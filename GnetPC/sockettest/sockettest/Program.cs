using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace sockettest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Thread thd1;
            Thread thd2;
            SocServer s2 = new SocServer();
            SocClient c1 = new SocClient();
            Console.Write("15\n");
            thd1 = new Thread(new ThreadStart(s2.SocServerListen));
            thd1.Start();
            Console.Write("16\n");
            thd2 = new Thread(new ThreadStart(c1.SocClientFileSend));
            thd2.Start();
            s2.fileAccept();
            Console.Read();
        }
    }
}
