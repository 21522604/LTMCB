namespace Lab1
{
    partial class Bai3
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
            NhapLabel = new Label();
            SoCanDocTextBox = new TextBox();
            KetQuaLabel = new Label();
            KetQuaTextBox = new TextBox();
            DocButton = new Button();
            XoaButton = new Button();
            ThoatButton = new Button();
            SuspendLayout();
            // 
            // NhapLabel
            // 
            NhapLabel.AutoSize = true;
            NhapLabel.Location = new Point(54, 62);
            NhapLabel.Name = "NhapLabel";
            NhapLabel.Size = new Size(144, 20);
            NhapLabel.TabIndex = 0;
            NhapLabel.Text = "Nhập vào số nguyên";
            // 
            // SoCanDocTextBox
            // 
            SoCanDocTextBox.Location = new Point(213, 59);
            SoCanDocTextBox.Name = "SoCanDocTextBox";
            SoCanDocTextBox.Size = new Size(506, 27);
            SoCanDocTextBox.TabIndex = 1;
            // 
            // KetQuaLabel
            // 
            KetQuaLabel.AutoSize = true;
            KetQuaLabel.Location = new Point(54, 121);
            KetQuaLabel.Name = "KetQuaLabel";
            KetQuaLabel.Size = new Size(64, 20);
            KetQuaLabel.TabIndex = 2;
            KetQuaLabel.Text = "Kết quả ";
            // 
            // KetQuaTextBox
            // 
            KetQuaTextBox.Location = new Point(213, 121);
            KetQuaTextBox.Multiline = true;
            KetQuaTextBox.Name = "KetQuaTextBox";
            KetQuaTextBox.ReadOnly = true;
            KetQuaTextBox.Size = new Size(506, 93);
            KetQuaTextBox.TabIndex = 3;
            // 
            // DocButton
            // 
            DocButton.Location = new Point(82, 236);
            DocButton.Name = "DocButton";
            DocButton.Size = new Size(94, 29);
            DocButton.TabIndex = 4;
            DocButton.Text = "Đọc";
            DocButton.UseVisualStyleBackColor = true;
            DocButton.Click += DocButton_Click;
            // 
            // XoaButton
            // 
            XoaButton.Location = new Point(328, 236);
            XoaButton.Name = "XoaButton";
            XoaButton.Size = new Size(94, 29);
            XoaButton.TabIndex = 5;
            XoaButton.Text = "Xóa";
            XoaButton.UseVisualStyleBackColor = true;
            XoaButton.Click += XoaButton_Click;
            // 
            // ThoatButton
            // 
            ThoatButton.Location = new Point(589, 236);
            ThoatButton.Name = "ThoatButton";
            ThoatButton.Size = new Size(94, 29);
            ThoatButton.TabIndex = 6;
            ThoatButton.Text = "Thoát";
            ThoatButton.UseVisualStyleBackColor = true;
            ThoatButton.Click += ThoatButton_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 299);
            Controls.Add(ThoatButton);
            Controls.Add(XoaButton);
            Controls.Add(DocButton);
            Controls.Add(KetQuaTextBox);
            Controls.Add(KetQuaLabel);
            Controls.Add(SoCanDocTextBox);
            Controls.Add(NhapLabel);
            Name = "Bai3";
            Text = "Bai3";
            FormClosing += Bai3_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NhapLabel;
        private TextBox SoCanDocTextBox;
        private Label KetQuaLabel;
        private TextBox KetQuaTextBox;
        private Button DocButton;
        private Button XoaButton;
        private Button ThoatButton;
    }
}