using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DroneUI
{
    public class SDK
    {
        public DroneConnection InitConnection()
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Connect("", 9000);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("192.168.10.1"), 8889);

            return new DroneConnection()
            {
                Socket = socket,
                EndPoint = endPoint
            };
        }

        public int SendReceive(DroneConnection droneConnection, string command)
        {
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(command);
                byte[] intocommand = Encoding.UTF8.GetBytes("command");
                int ix = droneConnection.Socket.SendTo(intocommand, droneConnection.EndPoint);
                int iy = droneConnection.Socket.SendTo(msg, droneConnection.EndPoint);
            }
            catch (SocketException e)
            {
                return (e.ErrorCode);
            }
            return 0;
        }
    }


    public class DroneConnection
    {
        public Socket Socket { get; set; }
        public IPEndPoint EndPoint { get; set; }
    }
}
