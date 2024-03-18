using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void TimButton_Click(object sender, EventArgs e)
        {
            if (SoThuNhatTextBox.Text == "")
            {
                MessageBox.Show("Số thứ nhất chưa được nhập");
            }
            else if (SoThuHaiTextBox.Text == "")
            {
                MessageBox.Show("Số thứ hai chưa được nhập");
            }
            else if (SoThuBaTextBox.Text == "")
            {
                MessageBox.Show("Số thứ ba chưa được nhập");
            }
            else
            {
                if (Int64.TryParse(SoThuNhatTextBox.Text, out Int64 result1))
                {
                    if (Int64.TryParse(SoThuHaiTextBox.Text, out Int64 result2))
                    {
                        if (Int64.TryParse(SoThuBaTextBox.Text, out Int64 result3))
                        {
                            SoLonNhatTextBox.Text = Math.Max(Math.Max(result1, result2)
                                                                    , result3).ToString();
                            SoBeNhatTextBox.Text = Math.Min(Math.Min(result1, result2)
                                                                    , result3).ToString();
                        }
                        else MessageBox.Show("Giá trị nhập vào không hợp lệ");
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
            SoThuBaTextBox.Text = "";
            SoLonNhatTextBox.Text = "";
            SoBeNhatTextBox.Text = "";
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }
        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }
    }
}
