using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace FControllTello
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o comando!");
           // string command = Console.ReadLine();

            Start();

        }


        static void Start()
        {
            try
            {
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                
                socket.Connect("", 9000);

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.10.1"), 8889);

                int defaultSeconds = 5000;

                Console.WriteLine("takeoff");
                SendReceive(socket, endPoint, "takeoff");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("left");
                SendReceive(socket, endPoint, "left 50");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("right");
                SendReceive(socket, endPoint, "right 50");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("forward");
                SendReceive(socket, endPoint, "forward 50");
                Thread.Sleep(defaultSeconds);


                Console.WriteLine("cw");
                SendReceive(socket, endPoint, "cw 90");
                Thread.Sleep(defaultSeconds);


                Console.WriteLine("forward");
                SendReceive(socket, endPoint, "forward 50");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("cw");
                SendReceive(socket, endPoint, "cw 90");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("forward");
                SendReceive(socket, endPoint, "forward 50");
                Thread.Sleep(5);

                Console.WriteLine("cw");
                SendReceive(socket, endPoint, "cw 90");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("forward");
                SendReceive(socket, endPoint, "forward 50");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("cw");
                SendReceive(socket, endPoint, "cw 90");
                Thread.Sleep(defaultSeconds);

                Console.WriteLine("land");
                SendReceive(socket, endPoint, "land");

                Console.ReadKey();
                socket.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }


        public static int SendReceive(Socket socket, IPEndPoint endpoint, string command)
        {
            byte[] bytes = new byte[256];
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(command);
                byte[] intocommand = Encoding.UTF8.GetBytes("command");
                int ix = socket.SendTo(intocommand, endpoint);

                Console.WriteLine("Sent {0} bytes.", ix);

                int iy = socket.SendTo(msg, endpoint);
                Console.WriteLine("Sent {0} bytes.", iy);

                socket.Receive(bytes);
                Console.WriteLine(Encoding.UTF8.GetString(bytes));
            }
            catch (SocketException e)
            {
                Console.WriteLine("{0} Error code: {1}.", e.Message, e.ErrorCode);
                return (e.ErrorCode);
            }
            return 0;
        }
    }
}
