using System.Globalization;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        private void ThucHienButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(NguonComboBox != null && DichComboBox != null)
                {
                    if (NguonComboBox.SelectedIndex == 1 && DichComboBox.SelectedIndex == 0)
                    {
                        int decimalResult = Convert.ToInt32(SoCanChuyenTextBox.ToString(), 2);
                        KetQuaTextBox.Text = decimalResult.ToString();
                    }
                    else if (NguonComboBox.SelectedIndex == 0 && DichComboBox.SelectedIndex == 1)
                    {
                        int BinaryResult = int.Parse(SoCanChuyenTextBox.ToString());
                        KetQuaTextBox.Text = Convert.ToString(BinaryResult, 2);
                    }
                    else if (NguonComboBox.SelectedIndex == 0 && DichComboBox.SelectedIndex == 2)
                    {
                        int decimalNumber = int.Parse(SoCanChuyenTextBox.ToString());
                        KetQuaTextBox.Text = decimalNumber.ToString("X");
                    }
                    else if (NguonComboBox.SelectedIndex == 2 && DichComboBox.SelectedIndex == 0)
                    {
                        int decimalValue = Convert.ToInt32(SoCanChuyenTextBox.Text.ToString(), 16);
                        KetQuaTextBox.Text = decimalValue.ToString();
                    }
                    else if (NguonComboBox.SelectedIndex == 1 && DichComboBox.SelectedIndex == 2)
                    {
                        int decimalNumber = Convert.ToInt32(SoCanChuyenTextBox.ToString(), 2);
                        KetQuaTextBox.Text = decimalNumber.ToString("X");
                    }
                    else if (NguonComboBox.SelectedIndex == 2 && DichComboBox.SelectedIndex == 1)
                    {
                        int BinaryResult = Convert.ToInt32(SoCanChuyenTextBox.Text.ToString(), 16);
                        KetQuaTextBox.Text = Convert.ToString(BinaryResult, 2);
                    }
                    if(NguonComboBox.SelectedIndex == DichComboBox.SelectedIndex)
                    {
                        MessageBox.Show("Đã cùng 1 cơ số! Không cần chuyển đổi");
                    }
                    else MessageBox.Show("Đã chuyển đổi!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void XoaButton_Click(object sender, EventArgs e)
        {
            NguonComboBox.SelectedIndex = -1;
            DichComboBox.SelectedIndex = -1;
            SoCanChuyenTextBox.Text = "";
            KetQuaTextBox.Text = "";
        }

        private void ThoatButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }

        private void Bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form1 form1 = Form1.GetInstance();
            form1.Show();
        }
    }
}

