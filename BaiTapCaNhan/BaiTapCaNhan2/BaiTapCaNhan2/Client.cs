using System.Net.Sockets;
using System.Net;
using System.Text;

namespace BaiTapCaNhan2
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            //Lấy địa chỉ IP từ textbox và chuyển thành kiểuIPAddress
            IPAddress ipadd = IPAddress.Parse(IPRemoteHostTextbox.Text);
            int port = Convert.ToInt32(PortTextbox.Text);
            IPEndPoint ipend = new IPEndPoint(ipadd, port);
            //Chuyển chuỗi dữ liệu nhập sang kiểu byte
            Byte[] sendBytes =
            Encoding.UTF8.GetBytes(MessagesTextbox.Text);
            //Gởi dữ liệu đến IPEndPoint đã định nghĩa địa chỉ IP và Port
            udpClient.Send(sendBytes, sendBytes.Length, ipend);
            //Xóa dữ liệu vừa gửi ở ô nhập
            MessagesTextbox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
