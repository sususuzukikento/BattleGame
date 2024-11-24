using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
class TCPReceiver
{
    TcpListener listener;

    public TCPReceiver(int port)
    {
        this.listener = new TcpListener(IPAddress.Any, port);
    }

    public string StartReceiving()
    {
        listener.Start();
        // クライアントからの接続を待機
        TcpClient client = listener.AcceptTcpClient();
        // ネットワークストリームの取得
        NetworkStream stream = client.GetStream();
        // データの受信
        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string receivedMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        // 接続を閉じる
        stream.Close();
        client.Close();
        listener.Stop();
        return receivedMessage;
    }
}