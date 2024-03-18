namespace Lab1
{
    partial class Bai1
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
            SoHang1Label = new Label();
            SoHang2Label = new Label();
            KetQuaLabel = new Label();
            label1 = new Label();
            SoThuNhatTextBox = new TextBox();
            SoThuHaiTextBox = new TextBox();
            KetQuaTextBox = new TextBox();
            TinhButton = new Button();
            XoaButton = new Button();
            ThoatButton = new Button();
            SuspendLayout();
            // 
            // SoHang1Label
            // 
            SoHang1Label.AutoSize = true;
            SoHang1Label.Location = new Point(63, 99);
            SoHang1Label.Name = "SoHang1Label";
            SoHang1Label.Size = new Size(92, 20);
            SoHang1Label.TabIndex = 0;
            SoHang1Label.Text = "Số thứ nhất: ";
            // 
            // SoHang2Label
            // 
            SoHang2Label.AutoSize = true;
            SoHang2Label.Location = new Point(63, 174);
            SoHang2Label.Name = "SoHang2Label";
            SoHang2Label.Size = new Size(79, 20);
            SoHang2Label.TabIndex = 1;
            SoHang2Label.Text = "Số thứ hai:";
            // 
            // KetQuaLabel
            // 
            KetQuaLabel.AutoSize = true;
            KetQuaLabel.Location = new Point(63, 255);
            KetQuaLabel.Name = "KetQuaLabel";
            KetQuaLabel.Size = new Size(67, 20);
            KetQuaLabel.TabIndex = 2;
            KetQuaLabel.Text = "Kết quả: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(179, 29);
            label1.Name = "label1";
            label1.Size = new Size(379, 46);
            label1.TabIndex = 3;
            label1.Text = "Tính tổng 2 số nguyên";
            // 
            // SoThuNhatTextBox
            // 
            SoThuNhatTextBox.Location = new Point(179, 94);
            SoThuNhatTextBox.Name = "SoThuNhatTextBox";
            SoThuNhatTextBox.Size = new Size(568, 27);
            SoThuNhatTextBox.TabIndex = 4;
            // 
            // SoThuHaiTextBox
            // 
            SoThuHaiTextBox.Location = new Point(179, 174);
            SoThuHaiTextBox.Name = "SoThuHaiTextBox";
            SoThuHaiTextBox.Size = new Size(568, 27);
            SoThuHaiTextBox.TabIndex = 5;
            // 
            // KetQuaTextBox
            // 
            KetQuaTextBox.Location = new Point(179, 248);
            KetQuaTextBox.Name = "KetQuaTextBox";
            KetQuaTextBox.ReadOnly = true;
            KetQuaTextBox.Size = new Size(568, 27);
            KetQuaTextBox.TabIndex = 6;
            // 
            // TinhButton
            // 
            TinhButton.Location = new Point(509, 340);
            TinhButton.Name = "TinhButton";
            TinhButton.Size = new Size(94, 29);
            TinhButton.TabIndex = 7;
            TinhButton.Text = "Tính";
            TinhButton.UseVisualStyleBackColor = true;
            TinhButton.Click += TinhButton_Click;
            // 
            // XoaButton
            // 
            XoaButton.Location = new Point(627, 340);
            XoaButton.Name = "XoaButton";
            XoaButton.Size = new Size(94, 29);
            XoaButton.TabIndex = 8;
            XoaButton.Text = "Xóa ";
            XoaButton.UseVisualStyleBackColor = true;
            XoaButton.Click += XoaButton_Click;
            // 
            // ThoatButton
            // 
            ThoatButton.Location = new Point(627, 397);
            ThoatButton.Name = "ThoatButton";
            ThoatButton.Size = new Size(94, 29);
            ThoatButton.TabIndex = 9;
            ThoatButton.Text = "Thoát ";
            ThoatButton.UseVisualStyleBackColor = true;
            ThoatButton.Click += ThoatButton_Click;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ThoatButton);
            Controls.Add(XoaButton);
            Controls.Add(TinhButton);
            Controls.Add(KetQuaTextBox);
            Controls.Add(SoThuHaiTextBox);
            Controls.Add(SoThuNhatTextBox);
            Controls.Add(label1);
            Controls.Add(KetQuaLabel);
            Controls.Add(SoHang2Label);
            Controls.Add(SoHang1Label);
            Name = "Bai1";
            Text = "Bài 1";
            FormClosing += Bai1_FormClosing;
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SoHang1Label;
        private Label SoHang2Label;
        private Label KetQuaLabel;
        private Label label1;
        private TextBox SoThuNhatTextBox;
        private TextBox SoThuHaiTextBox;
        private TextBox KetQuaTextBox;
        private Button TinhButton;
        private Button XoaButton;
        private Button ThoatButton;
    }
}