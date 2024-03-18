using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void XuatButton_Click(object sender, EventArgs e)
        {

            DiemTrungBinhLabel.Text = "Điểm trung bình:";
            MonCoDiemCaoNhatLabel.Text = "Môn có điểm cao nhất:";
            SoMonDauLabel.Text = "Số môn đậu:";
            XepLoaiHocLucLabel.Text = "Xếp loại học lực:";
            MonCoDiemThapNhatLabel.Text = "Môn có điểm thấp nhất:";
            SoMonKhongDauLabel.Text = "Số môn không đậu:";
            DiemLabel.Text = "";
            int SoMon = 1;
            try
            {
                string DanhSachDiemString = DanhSachTextBox.Text.ToString();
                double[] DanhSachDiem = new double[100];
                if (DanhSachDiemString.Length == 0)
                {
                    SoMon = 0;
                }
                else
                {
                    string number = "";
                    for (int i = 0; i < DanhSachDiemString.Length; i++)
                    {
                        if (DanhSachDiemString[i] == ' ')
                        {
                            DanhSachDiem[SoMon] = double.Parse(number);
                            number = "";
                            SoMon++;
                        }
                        else
                        {
                            number = number + DanhSachDiemString[i];
                        }
                    }
                    DanhSachDiem[SoMon] = double.Parse(number);
                    number = "";
                }
                for (int i = 1; i <= SoMon; i++)
                {
                    DiemLabel.Text += $"Môn {i}: {DanhSachDiem[i]}".PadRight(20);
                    if (i % 6 == 0)
                    {
                        DiemLabel.Text += "\n";
                    }
                }
                double DiemTrungBinh = 0;
                double MonDiemCaoNhat = 0;
                double MonDiemThapNhat = 10;
                int SoMonDau = 0;
                int SoMonKhongDau = 0;
                for (int i = 1; i <= SoMon; i++)
                {
                    DiemTrungBinh += DanhSachDiem[i];
                    MonDiemCaoNhat = Math.Max(MonDiemCaoNhat, DanhSachDiem[i]);
                    MonDiemThapNhat = Math.Min(MonDiemThapNhat, DanhSachDiem[i]);
                    if (DanhSachDiem[i] < 5.0)
                    {
                        SoMonKhongDau++;
                    }
                }
                MonCoDiemCaoNhatLabel.Text += $" {MonDiemCaoNhat} đ";
                MonCoDiemThapNhatLabel.Text += $" {MonDiemThapNhat} đ";
                SoMonKhongDauLabel.Text += $" {SoMonKhongDau}";
                SoMonDau = SoMon - SoMonKhongDau;
                SoMonDauLabel.Text += $" {SoMonDau}";
                DiemTrungBinh = DiemTrungBinh / SoMon;
                DiemTrungBinhLabel.Text += $" {DiemTrungBinh}"; 
                if(DiemTrungBinh >= 8 && KiemTraHocLuc(6.5, SoMon, DanhSachDiem))
                {
                    XepLoaiHocLucLabel.Text += " Giỏi";
                }
                else if(DiemTrungBinh >= 6.5 && KiemTraHocLuc(5, SoMon, DanhSachDiem))
                {
                    XepLoaiHocLucLabel.Text += " Khá";
                }
                else if (DiemTrungBinh >= 5 && KiemTraHocLuc(3.5, SoMon, DanhSachDiem))
                {
                    XepLoaiHocLucLabel.Text += " Trung Bình";
                }
                else if (DiemTrungBinh >= 3.5 && KiemTraHocLuc(2, SoMon, DanhSachDiem))
                {
                    XepLoaiHocLucLabel.Text += " Yếu";
                }
                else XepLoaiHocLucLabel.Text += "Khác";
                MessageBox.Show("Đã xuất dữ liệu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private bool KiemTraHocLuc(double Thap, int SoMon, double[] DanhSachDiem)
        {
            for (int i = 1; i <= SoMon; i++)
            {
                if (DanhSachDiem[i] < Thap)
                {
                    return false;
                }
            }
            return true;
        }
        private void Bai5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
