using System;
using System.Net.Sockets;
using System.Text;

class TCPSender
{
    TcpClient client;
    public TCPSender(string ipAddress, int port)
    {
        this.client = new TcpClient(ipAddress, port);
    }

    public void SendMessage(string message)
    {
        NetworkStream stream = client.GetStream();
        byte[] messageBytes = Encoding.UTF8.GetBytes(message);
        stream.Write(messageBytes, 0, messageBytes.Length);
    }
}