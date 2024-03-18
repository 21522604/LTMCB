namespace BaiTapCaNhan2
{
    partial class MENU
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ServerButton = new Button();
            ClientButton = new Button();
            UDPLabel = new Label();
            TCPLabel = new Label();
            ServerTCPButton = new Button();
            ClientTCPButton = new Button();
            SuspendLayout();
            // 
            // ServerButton
            // 
            ServerButton.Location = new Point(100, 110);
            ServerButton.Name = "ServerButton";
            ServerButton.Size = new Size(206, 86);
            ServerButton.TabIndex = 0;
            ServerButton.Text = "Server";
            ServerButton.UseVisualStyleBackColor = true;
            ServerButton.Click += ServerButton_Click;
            // 
            // ClientButton
            // 
            ClientButton.Location = new Point(477, 110);
            ClientButton.Name = "ClientButton";
            ClientButton.Size = new Size(206, 86);
            ClientButton.TabIndex = 1;
            ClientButton.Text = "Client";
            ClientButton.UseVisualStyleBackColor = true;
            ClientButton.Click += ClientButton_Click;
            // 
            // UDPLabel
            // 
            UDPLabel.AutoSize = true;
            UDPLabel.Location = new Point(54, 53);
            UDPLabel.Name = "UDPLabel";
            UDPLabel.Size = new Size(38, 20);
            UDPLabel.TabIndex = 2;
            UDPLabel.Text = "UDP";
            // 
            // TCPLabel
            // 
            TCPLabel.AutoSize = true;
            TCPLabel.Location = new Point(54, 251);
            TCPLabel.Name = "TCPLabel";
            TCPLabel.Size = new Size(33, 20);
            TCPLabel.TabIndex = 3;
            TCPLabel.Text = "TCP";
            // 
            // ServerTCPButton
            // 
            ServerTCPButton.Location = new Point(100, 305);
            ServerTCPButton.Name = "ServerTCPButton";
            ServerTCPButton.Size = new Size(206, 86);
            ServerTCPButton.TabIndex = 4;
            ServerTCPButton.Text = "Server";
            ServerTCPButton.UseVisualStyleBackColor = true;
            ServerTCPButton.Click += ServerTCPButton_Click;
            // 
            // ClientTCPButton
            // 
            ClientTCPButton.Location = new Point(477, 305);
            ClientTCPButton.Name = "ClientTCPButton";
            ClientTCPButton.Size = new Size(206, 86);
            ClientTCPButton.TabIndex = 5;
            ClientTCPButton.Text = "Client";
            ClientTCPButton.UseVisualStyleBackColor = true;
            ClientTCPButton.Click += ClientTCPButton_Click;
            // 
            // MENU
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClientTCPButton);
            Controls.Add(ServerTCPButton);
            Controls.Add(TCPLabel);
            Controls.Add(UDPLabel);
            Controls.Add(ClientButton);
            Controls.Add(ServerButton);
            Name = "MENU";
            Text = "MENU";
            FormClosing += MENU_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ServerButton;
        private Button ClientButton;
        private Label UDPLabel;
        private Label TCPLabel;
        private Button ServerTCPButton;
        private Button ClientTCPButton;
    }
}
