using System.Net.Sockets;
using System.Net;
using System.Text;

namespace BaiTapCaNhan2
{
    public partial class Server : Form
    {
        private Thread thread2 = null;
        private delegate void SafeCallDelegate(string text);
        public Server()
        {
            InitializeComponent();
        }

        private void ListenButton_Click(object sender, EventArgs e)
        {
            /*serverThread();*/
            thread2 = new Thread(new ThreadStart(serverThread));
            thread2.Start(); 
        }
        public void InfoMessage(string message)
        {
            /*ReceivedTextbox.Text = message;*/
            if (ReceivedTextbox.InvokeRequired)
            {
                var d = new SafeCallDelegate(InfoMessage);
                ReceivedTextbox.Invoke(d, new object[] { message });
            }
            else
            {
                ReceivedTextbox.Text = message;
            }
        }
        public void serverThread()
        {
            try
            {
                int port = Convert.ToInt32(PortTextbox.Text);
                UdpClient udpClient = new UdpClient(port);
                while (true)
                {
                    IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, 0);
                    //Đón nhận và đẩy dữ liệu nhận được vào mảng Byte
                    Byte[] recvBytes = udpClient.Receive(ref IpEnd);
                    string Data = Encoding.UTF8.GetString(recvBytes);
                    string mess = IpEnd.Address.ToString() + ":" +

                    IpEnd.Port.ToString() + ": " + Data.ToString();
                    // Gọi hàm hiển thị thông điệp nhận được lên màn hình
                    InfoMessage(mess);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
