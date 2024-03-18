namespace Lab1
{
    partial class Bai4
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
            NhapThongTinComboBox = new GroupBox();
            ThucHienButton = new Button();
            SangLabel = new Label();
            ChuyenTuLabel = new Label();
            NhapLabel = new Label();
            DichComboBox = new ComboBox();
            NguonComboBox = new ComboBox();
            SoCanChuyenTextBox = new TextBox();
            KetQuaLabel = new Label();
            KetQuaTextBox = new TextBox();
            ThoatButton = new Button();
            XoaButton = new Button();
            NhapThongTinComboBox.SuspendLayout();
            SuspendLayout();
            // 
            // NhapThongTinComboBox
            // 
            NhapThongTinComboBox.Controls.Add(ThucHienButton);
            NhapThongTinComboBox.Controls.Add(SangLabel);
            NhapThongTinComboBox.Controls.Add(ChuyenTuLabel);
            NhapThongTinComboBox.Controls.Add(NhapLabel);
            NhapThongTinComboBox.Controls.Add(DichComboBox);
            NhapThongTinComboBox.Controls.Add(NguonComboBox);
            NhapThongTinComboBox.Controls.Add(SoCanChuyenTextBox);
            NhapThongTinComboBox.Location = new Point(44, 54);
            NhapThongTinComboBox.Name = "NhapThongTinComboBox";
            NhapThongTinComboBox.Size = new Size(700, 240);
            NhapThongTinComboBox.TabIndex = 0;
            NhapThongTinComboBox.TabStop = false;
            NhapThongTinComboBox.Text = "Nhập thông tin";
            // 
            // ThucHienButton
            // 
            ThucHienButton.BackColor = SystemColors.ActiveCaptionText;
            ThucHienButton.ForeColor = SystemColors.ButtonFace;
            ThucHienButton.Location = new Point(231, 162);
            ThucHienButton.Name = "ThucHienButton";
            ThucHienButton.Size = new Size(431, 29);
            ThucHienButton.TabIndex = 6;
            ThucHienButton.Text = "Thực hiện";
            ThucHienButton.UseVisualStyleBackColor = false;
            ThucHienButton.Click += ThucHienButton_Click;
            // 
            // SangLabel
            // 
            SangLabel.AutoSize = true;
            SangLabel.Location = new Point(425, 103);
            SangLabel.Name = "SangLabel";
            SangLabel.Size = new Size(42, 20);
            SangLabel.TabIndex = 5;
            SangLabel.Text = "Sang";
            // 
            // ChuyenTuLabel
            // 
            ChuyenTuLabel.AutoSize = true;
            ChuyenTuLabel.Location = new Point(110, 103);
            ChuyenTuLabel.Name = "ChuyenTuLabel";
            ChuyenTuLabel.Size = new Size(82, 20);
            ChuyenTuLabel.TabIndex = 4;
            ChuyenTuLabel.Text = "Chuyển từ :";
            // 
            // NhapLabel
            // 
            NhapLabel.AutoSize = true;
            NhapLabel.Location = new Point(90, 51);
            NhapLabel.Name = "NhapLabel";
            NhapLabel.Size = new Size(102, 20);
            NhapLabel.TabIndex = 3;
            NhapLabel.Text = "Nhập một số :";
            // 
            // DichComboBox
            // 
            DichComboBox.FormattingEnabled = true;
            DichComboBox.Items.AddRange(new object[] { "Decimal", "Binary", "Hex" });
            DichComboBox.Location = new Point(511, 100);
            DichComboBox.Name = "DichComboBox";
            DichComboBox.Size = new Size(151, 28);
            DichComboBox.TabIndex = 2;
            DichComboBox.Text = "Chọn hệ cơ số ";
            // 
            // NguonComboBox
            // 
            NguonComboBox.FormattingEnabled = true;
            NguonComboBox.Items.AddRange(new object[] { "Decimal", "Binary", "Hex" });
            NguonComboBox.Location = new Point(231, 100);
            NguonComboBox.Name = "NguonComboBox";
            NguonComboBox.Size = new Size(151, 28);
            NguonComboBox.TabIndex = 1;
            NguonComboBox.Text = "Chọn hệ cơ số ";
            // 
            // SoCanChuyenTextBox
            // 
            SoCanChuyenTextBox.Location = new Point(231, 48);
            SoCanChuyenTextBox.Name = "SoCanChuyenTextBox";
            SoCanChuyenTextBox.Size = new Size(431, 27);
            SoCanChuyenTextBox.TabIndex = 0;
            // 
            // KetQuaLabel
            // 
            KetQuaLabel.AutoSize = true;
            KetQuaLabel.Location = new Point(169, 332);
            KetQuaLabel.Name = "KetQuaLabel";
            KetQuaLabel.Size = new Size(67, 20);
            KetQuaLabel.TabIndex = 4;
            KetQuaLabel.Text = "Kết quả :";
            // 
            // KetQuaTextBox
            // 
            KetQuaTextBox.Location = new Point(275, 329);
            KetQuaTextBox.Name = "KetQuaTextBox";
            KetQuaTextBox.Size = new Size(431, 27);
            KetQuaTextBox.TabIndex = 7;
            // 
            // ThoatButton
            // 
            ThoatButton.Location = new Point(650, 390);
            ThoatButton.Name = "ThoatButton";
            ThoatButton.Size = new Size(94, 29);
            ThoatButton.TabIndex = 7;
            ThoatButton.Text = "Thoát";
            ThoatButton.UseVisualStyleBackColor = true;
            ThoatButton.Click += ThoatButton_Click;
            // 
            // XoaButton
            // 
            XoaButton.Location = new Point(469, 390);
            XoaButton.Name = "XoaButton";
            XoaButton.Size = new Size(94, 29);
            XoaButton.TabIndex = 8;
            XoaButton.Text = "Xóa";
            XoaButton.UseVisualStyleBackColor = true;
            XoaButton.Click += XoaButton_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(XoaButton);
            Controls.Add(ThoatButton);
            Controls.Add(KetQuaTextBox);
            Controls.Add(KetQuaLabel);
            Controls.Add(NhapThongTinComboBox);
            Name = "Bai4";
            Text = "Bai4";
            FormClosing += Bai4_FormClosing;
            NhapThongTinComboBox.ResumeLayout(false);
            NhapThongTinComboBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox NhapThongTinComboBox;
        private Label SangLabel;
        private Label ChuyenTuLabel;
        private Label NhapLabel;
        private ComboBox DichComboBox;
        private ComboBox NguonComboBox;
        private TextBox SoCanChuyenTextBox;
        private Button ThucHienButton;
        private Label KetQuaLabel;
        private TextBox KetQuaTextBox;
        private Button ThoatButton;
        private Button XoaButton;
    }
}