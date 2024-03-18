using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void DocButton_Click(object sender, EventArgs e)
        {
            if (SoCanDocTextBox.Text == "")
            {
                MessageBox.Show("Số chưa được nhập");
            }
            else
            {
                if (Int64.TryParse(SoCanDocTextBox.Text, out Int64 result))
                {
                    long NumberLength = result.ToString().Length;
                    if (NumberLength >= 19)
                    {
                        MessageBox.Show("Số nhập quá lớn, hãy nhập số dương từ 1 - 19 chữ số");
                    } 
                    else
                    {
                        String ResultString = result.ToString();
                        for (int i = 0; i < NumberLength; i++)
                        {
                            switch (ResultString[i])
                            {
                                case '0':
                                    if ((NumberLength - i) % 3 != 0) break;
                                    KetQuaTextBox.Text += " Không";
                                    break;
                                case '1':
                                    if ((NumberLength - i) % 3 == 2) break;
                                    if ((NumberLength - i) % 3 == 1 && ResultString[i-1] != 1 && i != 0)
                                    {
                                        KetQuaTextBox.Text += " Mốt";
                                        break;
                                    }
                                    KetQuaTextBox.Text += " Một";
                                    break;
                                case '2':
                                    KetQuaTextBox.Text += " Hai";
                                    break;
                                case '3':
                                    KetQuaTextBox.Text += " Ba";
                                    break;
                                case '4':
                                    KetQuaTextBox.Text += " Bốn";
                                    break;
                                case '5':
                                    KetQuaTextBox.Text += " Năm";
                                    break;
                                case '6':
                                    KetQuaTextBox.Text += " Sáu";
                                    break;
                                case '7':
                                    KetQuaTextBox.Text += " Bảy";
                                    break;
                                case '8':
                                    KetQuaTextBox.Text += " Tám";
                                    break;
                                default:
                                    KetQuaTextBox.Text += " Chín";
                                    break;
                            }
                            if ((NumberLength - i) % 3 == 1)
                            {
                                switch (NumberLength - i)
                                {
                                    case 16:
                                        KetQuaTextBox.Text += " Triệu Tỷ";
                                        break;
                                    case 13:
                                        KetQuaTextBox.Text += " Nghìn Tỷ";
                                        break;
                                    case 10:
                                        KetQuaTextBox.Text += " Tỷ";
                                        break;
                                    case 7:
                                        KetQuaTextBox.Text += " Triệu";
                                        break;
                                    case 4:
                                        KetQuaTextBox.Text += " Nghìn";
                                        break;
                                }
                            }

                            switch ((NumberLength - i) % 3)
                            {
                                case 0:
                                    KetQuaTextBox.Text += " Trăm";
                                    break;
                                case 2:
                                    if (ResultString[i] == '0' && ResultString[i + 1] != '0') KetQuaTextBox.Text += " Lẻ";
                                    else if (ResultString[i] == '0' && ResultString[i + 1] == '0') break;
                                    else if (ResultString[i] == '1') KetQuaTextBox.Text += " Mười";
                                    else KetQuaTextBox.Text += " Mươi";
                                    break;
                            }
                        }
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Giá trị nhập vào không hợp lệ");
                }
            }
        }

        private void XoaButton_Click(object sender, EventArgs e)
        {
            SoCanDocTextBox.Text = "";
            KetQuaTextBox.Text = "";
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }

        private void Bai3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }
    }
}
