using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace kip
{
    class IPAnoncer
    {
        static int port = 8005; // порт для рассылки своего адреса
        private static IPAddress remoteAddress;
        protected static IPAddress localIp;
        public static IPAddress LocalIp { get => localIp; }

        public IPAnoncer()
        {
            Thread myThread = new Thread(new ThreadStart(SendMessage));
            myThread.Start(); // запускаем поток
        }

        private static void SendMessage()
        {
            remoteAddress = IPAddress.Parse("235.5.5.11");
            var localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            
            foreach (IPAddress ip in localIPs)
            {
                try
                {
                    if (ip.ScopeId == long.MinValue) throw new Exception("Что-то пошло не так. Не могу определить свой IP адрес");
                }
                catch (SocketException)
                {
                    {
                        localIp = ip;
                        UdpClient sender = new UdpClient(); // создаем UdpClient для отправки
                        IPEndPoint endPoint = new IPEndPoint(remoteAddress, port);
                        try
                        {
                            while (true)
                            {
                                string message = LocalIp.ToString(); ; // сообщение для отправки
                                message = String.Format("{0}:{1}", "IP-address", message);
                                // для отладки
                                //Console.WriteLine(message);
                                byte[] data = Encoding.Unicode.GetBytes(message);
                                sender.Send(data, data.Length, endPoint); // отправка
                                Thread.Sleep(10000);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            sender.Close();
                        }
                    }
                }
            }
        }
    }
}
