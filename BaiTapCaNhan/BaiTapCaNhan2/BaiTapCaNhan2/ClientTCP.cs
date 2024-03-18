using System.Net.Sockets;
using System.Text;

namespace BaiTapCaNhan2
{
    public partial class ClientTCP : Form
    {
        public ClientTCP()
        {
            InitializeComponent();
        }
        int port = 8080;
        string ipAddress = "127.0.0.1";
        string textToSend = "21522604 hello\n";

        private void SendHelloMessageButton_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();

            if (!client.Connected)
            {
                client.Connect(ipAddress, port);
            }

            NetworkStream stream = client.GetStream();
            byte[] byteToSend = ASCIIEncoding.ASCII.GetBytes(textToSend);
            stream.Write(byteToSend, 0, byteToSend.Length);
            stream.Close();
            client.Close();
        }

        private void ClientTCP_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
