using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private void TinhButton_Click(object sender, EventArgs e)
        {
            if (SoThuNhatTextBox.Text == "" && SoThuHaiTextBox.Text == "")
            {
                MessageBox.Show("Cả hai số chưa được nhập");
            }
            else if (SoThuNhatTextBox.Text == "")
            {
                MessageBox.Show("Số thứ nhất chưa được nhập");
            }
            else if (SoThuHaiTextBox.Text == "")
            {
                MessageBox.Show("Số thứ hai chưa được nhập");
            }
            else
            {
                if (Int128.TryParse(SoThuNhatTextBox.Text, out Int128 result1))
                {
                    if (Int128.TryParse(SoThuHaiTextBox.Text, out Int128 result2))
                    {
                        KetQuaTextBox.Text = (result1 + result2).ToString();
                    }
                    else MessageBox.Show("Giá trị nhập vào không hợp lệ");
                }
                else MessageBox.Show("Giá trị nhập vào không hợp lệ");
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            SoThuNhatTextBox.Text = "";
            SoThuHaiTextBox.Text = "";
            KetQuaTextBox.Text = "";
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {
        }
        private void Bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }
    }
}
