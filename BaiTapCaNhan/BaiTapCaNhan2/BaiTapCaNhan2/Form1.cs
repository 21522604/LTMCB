namespace BaiTapCaNhan2
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void ServerButton_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.Show();

        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.Show();
        }

        private void MENU_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ServerTCPButton_Click(object sender, EventArgs e)
        {
            ServerTCP serverTCP = new ServerTCP();
            serverTCP.Show();
        }

        private void ClientTCPButton_Click(object sender, EventArgs e)
        {
            ClientTCP clientTCP = new ClientTCP();
            clientTCP.Show();
        }
    }
}
