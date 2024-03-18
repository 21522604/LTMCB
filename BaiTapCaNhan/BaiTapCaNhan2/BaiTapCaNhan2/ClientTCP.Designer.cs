namespace BaiTapCaNhan2
{
    partial class ClientTCP
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
            SendHelloMessageButton = new Button();
            SuspendLayout();
            // 
            // SendHelloMessageButton
            // 
            SendHelloMessageButton.Location = new Point(240, 29);
            SendHelloMessageButton.Name = "SendHelloMessageButton";
            SendHelloMessageButton.Size = new Size(285, 29);
            SendHelloMessageButton.TabIndex = 0;
            SendHelloMessageButton.Text = "Send Hello Message To Server";
            SendHelloMessageButton.UseVisualStyleBackColor = true;
            SendHelloMessageButton.Click += SendHelloMessageButton_Click;
            // 
            // ClientTCP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 86);
            Controls.Add(SendHelloMessageButton);
            Name = "ClientTCP";
            Text = "ClientTCP";
            FormClosing += ClientTCP_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button SendHelloMessageButton;
    }
}