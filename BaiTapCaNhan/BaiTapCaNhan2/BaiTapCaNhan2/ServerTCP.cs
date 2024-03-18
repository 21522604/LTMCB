using System.Net.Sockets;
using System.Net;
using System.Text;

namespace BaiTapCaNhan2
{
    public partial class ServerTCP : Form
    {
        public ServerTCP()
        {
            InitializeComponent();
        }
        int port = 8080;
        string ipAddress = "127.0.0.1";

        private async void ListenButton_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(ipAddress), port);
            listener.Start();

            while (true)
            {
                TcpClient tcpClient = await listener.AcceptTcpClientAsync();
                ReceivedTextbox.Text += "Connected\n";
                await Task.Run(() => HandleClient(tcpClient)).ConfigureAwait(false);
            }
        }
        private void HandleClient(TcpClient tcpClient)
        {
            NetworkStream nwStream = tcpClient.GetStream();

            byte[] buffer = new byte[tcpClient.ReceiveBufferSize];
            int bytesRead;

            while ((bytesRead = nwStream.Read(buffer, 0, tcpClient.ReceiveBufferSize)) > 0)
            {
                string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                ReceivedTextbox.Invoke((Action)(() => ReceivedTextbox.Text += (dataReceived)));
            }

            tcpClient.Close();
        }

        private void ServerTCP_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
