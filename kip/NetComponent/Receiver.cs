using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KipLib;

namespace kip
{
    public class Receiver
    {
        public Receiver()
        {
            Thread myThread = new Thread(new ThreadStart(Listener));
            myThread.Start(); // запускаем поток
        }

        public static void Listener()
        {
            const int PORT = 8005; // порт для прослушивания подключений
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAnoncer.LocalIp, PORT);
                listener.Start();
                Console.WriteLine("Ожидание подключений...");
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    try
                    {
                        Console.WriteLine("Обнаружено подключение...");
                        using (NetworkStream stream = client.GetStream())
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                int numBytesRead;
                                byte[] messsize = new byte[8];

                                numBytesRead = stream.Read(messsize, 0, 8);
                                Console.WriteLine(BitConverter.ToInt64(messsize, 0).ToString() + " длина высылаемого сообщения");

                                byte[] data = new byte[BitConverter.ToInt64(messsize,0)];
                                while ((numBytesRead = stream.Read(data, 0, data.Length)) > 0)
                                {
                                    ms.Write(data, 0, numBytesRead);
                                }
                                Console.WriteLine(ms.Length + " длинна полученного сообщения");
                                GetBack(ms);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (client != null)
                            client.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (listener != null)
                    listener.Stop();
            }
        }

        public static void GetBack(MemoryStream stream)
        {
            stream.Position = 0;
            Items.GetItems = DeSerializeFromMemory(stream);
            Console.WriteLine("Получено элементов: " + Items.GetItems.Count);
        }

        private static List<Items> DeSerializeFromMemory(MemoryStream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (List<Items>)formatter.Deserialize(stream);
        }
    }
}

