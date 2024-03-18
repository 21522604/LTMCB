namespace Lab1
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DanhSachLabel = new Label();
            DanhSachTextBox = new TextBox();
            XuatButton = new Button();
            groupBox1 = new GroupBox();
            DiemLabel = new Label();
            DiemTrungBinhLabel = new Label();
            MonCoDiemCaoNhatLabel = new Label();
            SoMonDauLabel = new Label();
            XepLoaiHocLucLabel = new Label();
            MonCoDiemThapNhatLabel = new Label();
            SoMonKhongDauLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DanhSachLabel
            // 
            DanhSachLabel.AutoSize = true;
            DanhSachLabel.Location = new Point(12, 65);
            DanhSachLabel.Name = "DanhSachLabel";
            DanhSachLabel.Size = new Size(122, 20);
            DanhSachLabel.TabIndex = 0;
            DanhSachLabel.Text = "Danh sách điểm: ";
            // 
            // DanhSachTextBox
            // 
            DanhSachTextBox.Location = new Point(160, 58);
            DanhSachTextBox.Name = "DanhSachTextBox";
            DanhSachTextBox.Size = new Size(628, 27);
            DanhSachTextBox.TabIndex = 1;
            // 
            // XuatButton
            // 
            XuatButton.Location = new Point(694, 103);
            XuatButton.Name = "XuatButton";
            XuatButton.Size = new Size(94, 29);
            XuatButton.TabIndex = 2;
            XuatButton.Text = "Xuất";
            XuatButton.UseVisualStyleBackColor = true;
            XuatButton.Click += XuatButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DiemLabel);
            groupBox1.Location = new Point(61, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 168);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách môn học và điểm ";
            // 
            // DiemLabel
            // 
            DiemLabel.AutoSize = true;
            DiemLabel.Location = new Point(6, 23);
            DiemLabel.Name = "DiemLabel";
            DiemLabel.Size = new Size(0, 20);
            DiemLabel.TabIndex = 0;
            // 
            // DiemTrungBinhLabel
            // 
            DiemTrungBinhLabel.AutoSize = true;
            DiemTrungBinhLabel.Location = new Point(67, 336);
            DiemTrungBinhLabel.Name = "DiemTrungBinhLabel";
            DiemTrungBinhLabel.Size = new Size(120, 20);
            DiemTrungBinhLabel.TabIndex = 4;
            DiemTrungBinhLabel.Text = "Điểm trung bình:";
            // 
            // MonCoDiemCaoNhatLabel
            // 
            MonCoDiemCaoNhatLabel.AutoSize = true;
            MonCoDiemCaoNhatLabel.Location = new Point(67, 373);
            MonCoDiemCaoNhatLabel.Name = "MonCoDiemCaoNhatLabel";
            MonCoDiemCaoNhatLabel.Size = new Size(161, 20);
            MonCoDiemCaoNhatLabel.TabIndex = 5;
            MonCoDiemCaoNhatLabel.Text = "Môn có điểm cao nhất:";
            // 
            // SoMonDauLabel
            // 
            SoMonDauLabel.AutoSize = true;
            SoMonDauLabel.Location = new Point(67, 405);
            SoMonDauLabel.Name = "SoMonDauLabel";
            SoMonDauLabel.Size = new Size(92, 20);
            SoMonDauLabel.TabIndex = 6;
            SoMonDauLabel.Text = "Số môn đậu:";
            // 
            // XepLoaiHocLucLabel
            // 
            XepLoaiHocLucLabel.AutoSize = true;
            XepLoaiHocLucLabel.Location = new Point(411, 336);
            XepLoaiHocLucLabel.Name = "XepLoaiHocLucLabel";
            XepLoaiHocLucLabel.Size = new Size(123, 20);
            XepLoaiHocLucLabel.TabIndex = 7;
            XepLoaiHocLucLabel.Text = "Xếp loại học lực: ";
            // 
            // MonCoDiemThapNhatLabel
            // 
            MonCoDiemThapNhatLabel.AutoSize = true;
            MonCoDiemThapNhatLabel.Location = new Point(411, 373);
            MonCoDiemThapNhatLabel.Name = "MonCoDiemThapNhatLabel";
            MonCoDiemThapNhatLabel.Size = new Size(168, 20);
            MonCoDiemThapNhatLabel.TabIndex = 8;
            MonCoDiemThapNhatLabel.Text = "Môn có điểm thấp nhất ";
            // 
            // SoMonKhongDauLabel
            // 
            SoMonKhongDauLabel.AutoSize = true;
            SoMonKhongDauLabel.Location = new Point(411, 405);
            SoMonKhongDauLabel.Name = "SoMonKhongDauLabel";
            SoMonKhongDauLabel.Size = new Size(138, 20);
            SoMonKhongDauLabel.TabIndex = 9;
            SoMonKhongDauLabel.Text = "Số môn không đậu ";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SoMonKhongDauLabel);
            Controls.Add(MonCoDiemThapNhatLabel);
            Controls.Add(XepLoaiHocLucLabel);
            Controls.Add(SoMonDauLabel);
            Controls.Add(MonCoDiemCaoNhatLabel);
            Controls.Add(DiemTrungBinhLabel);
            Controls.Add(groupBox1);
            Controls.Add(XuatButton);
            Controls.Add(DanhSachTextBox);
            Controls.Add(DanhSachLabel);
            Name = "Bai5";
            Text = "Bai5";
            FormClosing += Bai5_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DanhSachLabel;
        private TextBox DanhSachTextBox;
        private Button XuatButton;
        private GroupBox groupBox1;
        private Label DiemLabel;
        private Label DiemTrungBinhLabel;
        private Label MonCoDiemCaoNhatLabel;
        private Label SoMonDauLabel;
        private Label XepLoaiHocLucLabel;
        private Label MonCoDiemThapNhatLabel;
        private Label SoMonKhongDauLabel;
    }
}