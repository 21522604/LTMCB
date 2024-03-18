namespace Lab1
{
    partial class Bai2
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
            SoThuNhatLabel = new Label();
            SoThuHaiLabel = new Label();
            SoThuBaLabel = new Label();
            SoThuNhatTextBox = new TextBox();
            SoThuHaiTextBox = new TextBox();
            SoThuBaTextBox = new TextBox();
            DeBaiLabel = new Label();
            TimButton = new Button();
            XoaButton = new Button();
            ThoatButton = new Button();
            SoLonNhatLabel = new Label();
            SoBeNhatLabel = new Label();
            SoLonNhatTextBox = new TextBox();
            SoBeNhatTextBox = new TextBox();
            SuspendLayout();
            // 
            // SoThuNhatLabel
            // 
            SoThuNhatLabel.AutoSize = true;
            SoThuNhatLabel.Location = new Point(33, 116);
            SoThuNhatLabel.Name = "SoThuNhatLabel";
            SoThuNhatLabel.Size = new Size(85, 20);
            SoThuNhatLabel.TabIndex = 0;
            SoThuNhatLabel.Text = "Số thứ nhất";
            // 
            // SoThuHaiLabel
            // 
            SoThuHaiLabel.AutoSize = true;
            SoThuHaiLabel.Location = new Point(33, 168);
            SoThuHaiLabel.Name = "SoThuHaiLabel";
            SoThuHaiLabel.Size = new Size(80, 20);
            SoThuHaiLabel.TabIndex = 1;
            SoThuHaiLabel.Text = "Số thứ hai ";
            // 
            // SoThuBaLabel
            // 
            SoThuBaLabel.AutoSize = true;
            SoThuBaLabel.Location = new Point(33, 216);
            SoThuBaLabel.Name = "SoThuBaLabel";
            SoThuBaLabel.Size = new Size(73, 20);
            SoThuBaLabel.TabIndex = 2;
            SoThuBaLabel.Text = "Số thứ ba";
            // 
            // SoThuNhatTextBox
            // 
            SoThuNhatTextBox.Location = new Point(135, 109);
            SoThuNhatTextBox.Name = "SoThuNhatTextBox";
            SoThuNhatTextBox.Size = new Size(581, 27);
            SoThuNhatTextBox.TabIndex = 3;
            // 
            // SoThuHaiTextBox
            // 
            SoThuHaiTextBox.Location = new Point(135, 165);
            SoThuHaiTextBox.Name = "SoThuHaiTextBox";
            SoThuHaiTextBox.Size = new Size(581, 27);
            SoThuHaiTextBox.TabIndex = 4;
            // 
            // SoThuBaTextBox
            // 
            SoThuBaTextBox.Location = new Point(135, 213);
            SoThuBaTextBox.Name = "SoThuBaTextBox";
            SoThuBaTextBox.Size = new Size(581, 27);
            SoThuBaTextBox.TabIndex = 5;
            // 
            // DeBaiLabel
            // 
            DeBaiLabel.AutoSize = true;
            DeBaiLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            DeBaiLabel.Location = new Point(121, 25);
            DeBaiLabel.Name = "DeBaiLabel";
            DeBaiLabel.Size = new Size(595, 46);
            DeBaiLabel.TabIndex = 6;
            DeBaiLabel.Text = "TÌM SỐ LỚN NHẤT VÀ SỐ BÉ NHẤT ";
            // 
            // TimButton
            // 
            TimButton.Location = new Point(135, 358);
            TimButton.Name = "TimButton";
            TimButton.Size = new Size(94, 29);
            TimButton.TabIndex = 7;
            TimButton.Text = "Tìm";
            TimButton.UseVisualStyleBackColor = true;
            TimButton.Click += TimButton_Click;
            // 
            // XoaButton
            // 
            XoaButton.Location = new Point(365, 358);
            XoaButton.Name = "XoaButton";
            XoaButton.Size = new Size(94, 29);
            XoaButton.TabIndex = 8;
            XoaButton.Text = "Xóa";
            XoaButton.UseVisualStyleBackColor = true;
            XoaButton.Click += XoaButton_Click;
            // 
            // ThoatButton
            // 
            ThoatButton.Location = new Point(622, 358);
            ThoatButton.Name = "ThoatButton";
            ThoatButton.Size = new Size(94, 29);
            ThoatButton.TabIndex = 9;
            ThoatButton.Text = "Thoát";
            ThoatButton.UseVisualStyleBackColor = true;
            ThoatButton.Click += ThoatButton_Click;
            // 
            // SoLonNhatLabel
            // 
            SoLonNhatLabel.AutoSize = true;
            SoLonNhatLabel.Location = new Point(33, 272);
            SoLonNhatLabel.Name = "SoLonNhatLabel";
            SoLonNhatLabel.Size = new Size(88, 20);
            SoLonNhatLabel.TabIndex = 11;
            SoLonNhatLabel.Text = "Số lớn nhất ";
            // 
            // SoBeNhatLabel
            // 
            SoBeNhatLabel.AutoSize = true;
            SoBeNhatLabel.Location = new Point(33, 317);
            SoBeNhatLabel.Name = "SoBeNhatLabel";
            SoBeNhatLabel.Size = new Size(84, 20);
            SoBeNhatLabel.TabIndex = 12;
            SoBeNhatLabel.Text = "Số bé nhất ";
            // 
            // SoLonNhatTextBox
            // 
            SoLonNhatTextBox.Location = new Point(135, 269);
            SoLonNhatTextBox.Name = "SoLonNhatTextBox";
            SoLonNhatTextBox.ReadOnly = true;
            SoLonNhatTextBox.Size = new Size(581, 27);
            SoLonNhatTextBox.TabIndex = 13;
            // 
            // SoBeNhatTextBox
            // 
            SoBeNhatTextBox.Location = new Point(135, 314);
            SoBeNhatTextBox.Name = "SoBeNhatTextBox";
            SoBeNhatTextBox.ReadOnly = true;
            SoBeNhatTextBox.Size = new Size(581, 27);
            SoBeNhatTextBox.TabIndex = 14;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SoBeNhatTextBox);
            Controls.Add(SoLonNhatTextBox);
            Controls.Add(SoBeNhatLabel);
            Controls.Add(SoLonNhatLabel);
            Controls.Add(ThoatButton);
            Controls.Add(XoaButton);
            Controls.Add(TimButton);
            Controls.Add(DeBaiLabel);
            Controls.Add(SoThuBaTextBox);
            Controls.Add(SoThuHaiTextBox);
            Controls.Add(SoThuNhatTextBox);
            Controls.Add(SoThuBaLabel);
            Controls.Add(SoThuHaiLabel);
            Controls.Add(SoThuNhatLabel);
            Name = "Bai2";
            Text = "Bai2";
            FormClosing += Bai2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SoThuNhatLabel;
        private Label SoThuHaiLabel;
        private Label SoThuBaLabel;
        private TextBox SoThuNhatTextBox;
        private TextBox SoThuHaiTextBox;
        private TextBox SoThuBaTextBox;
        private Label DeBaiLabel;
        private Button TimButton;
        private Button XoaButton;
        private Button ThoatButton;
        private Label SoLonNhatLabel;
        private Label SoBeNhatLabel;
        private TextBox SoLonNhatTextBox;
        private TextBox SoBeNhatTextBox;
    }
}