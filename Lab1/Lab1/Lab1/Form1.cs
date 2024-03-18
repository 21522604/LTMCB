using System.Runtime.Intrinsics.X86;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
            this.Hide();
        }
        private static Form1? instance;
        public static Form1 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form1();
            }
            return instance;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.Show();
            this.Hide();
        }

        private void Bai3Button_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
            this.Hide();
        }

        private void Bai4Button_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.Show();
            this.Hide();
        }

        private void Bai5Button_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.Show();
            this.Hide();
        }
    }
}
