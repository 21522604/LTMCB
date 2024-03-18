namespace BaiTapCaNhan2
{
    partial class Client
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
            IPRemoteHostLabel = new Label();
            MessagesLabel = new Label();
            PortLabel = new Label();
            IPRemoteHostTextbox = new TextBox();
            PortTextbox = new TextBox();
            MessagesTextbox = new RichTextBox();
            SendButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // IPRemoteHostLabel
            // 
            IPRemoteHostLabel.AutoSize = true;
            IPRemoteHostLabel.Location = new Point(28, 19);
            IPRemoteHostLabel.Name = "IPRemoteHostLabel";
            IPRemoteHostLabel.Size = new Size(112, 20);
            IPRemoteHostLabel.TabIndex = 0;
            IPRemoteHostLabel.Text = "IP Remote Host";
            // 
            // MessagesLabel
            // 
            MessagesLabel.AutoSize = true;
            MessagesLabel.Location = new Point(28, 119);
            MessagesLabel.Name = "MessagesLabel";
            MessagesLabel.Size = new Size(73, 20);
            MessagesLabel.TabIndex = 1;
            MessagesLabel.Text = "Messages";
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Location = new Point(525, 19);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(35, 20);
            PortLabel.TabIndex = 2;
            PortLabel.Text = "Port";
            // 
            // IPRemoteHostTextbox
            // 
            IPRemoteHostTextbox.Location = new Point(28, 52);
            IPRemoteHostTextbox.Name = "IPRemoteHostTextbox";
            IPRemoteHostTextbox.Size = new Size(258, 27);
            IPRemoteHostTextbox.TabIndex = 3;
            // 
            // PortTextbox
            // 
            PortTextbox.Location = new Point(525, 52);
            PortTextbox.Name = "PortTextbox";
            PortTextbox.Size = new Size(125, 27);
            PortTextbox.TabIndex = 4;
            // 
            // MessagesTextbox
            // 
            MessagesTextbox.Location = new Point(28, 155);
            MessagesTextbox.Name = "MessagesTextbox";
            MessagesTextbox.Size = new Size(718, 216);
            MessagesTextbox.TabIndex = 5;
            MessagesTextbox.Text = "";
            // 
            // SendButton
            // 
            SendButton.Location = new Point(333, 393);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(94, 29);
            SendButton.TabIndex = 6;
            SendButton.Text = "Send";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(679, 393);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(SendButton);
            Controls.Add(MessagesTextbox);
            Controls.Add(PortTextbox);
            Controls.Add(IPRemoteHostTextbox);
            Controls.Add(PortLabel);
            Controls.Add(MessagesLabel);
            Controls.Add(IPRemoteHostLabel);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IPRemoteHostLabel;
        private Label MessagesLabel;
        private Label PortLabel;
        private TextBox IPRemoteHostTextbox;
        private TextBox PortTextbox;
        private RichTextBox MessagesTextbox;
        private Button SendButton;
        private Button ExitButton;
    }
}