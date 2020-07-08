using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DroneSDK
{
    public class SDK
    {
        public Connection InitConnection()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Connect("", 9000);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.10.1"), 8889);

            return new Connection()
            {
                Socket = socket,
                EndPoint = endPoint
            };
        }

        public int SendReceive(Socket socket, IPEndPoint endpoint, string command)
        {
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(command);
                byte[] intocommand = Encoding.UTF8.GetBytes("command");
                int ix = socket.SendTo(intocommand, endpoint);
                int iy = socket.SendTo(msg, endpoint);
            }
            catch (SocketException e)
            {
                return (e.ErrorCode);
            }
            return 0;
        }
    }


    public class Connection
    {
        public Socket Socket { get; set; }
        public IPEndPoint EndPoint { get; set; }
    }
}
