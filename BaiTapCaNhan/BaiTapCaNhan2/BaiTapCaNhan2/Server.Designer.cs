namespace BaiTapCaNhan2
{
    partial class Server
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
            ExitButton = new Button();
            ListenButton = new Button();
            ReceivedTextbox = new RichTextBox();
            PortTextbox = new TextBox();
            label2 = new Label();
            PortLabel = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(660, 91);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 11;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ListenButton
            // 
            ListenButton.Location = new Point(660, 46);
            ListenButton.Name = "ListenButton";
            ListenButton.Size = new Size(94, 29);
            ListenButton.TabIndex = 10;
            ListenButton.Text = "Listen";
            ListenButton.UseVisualStyleBackColor = true;
            ListenButton.Click += ListenButton_Click;
            // 
            // ReceivedTextbox
            // 
            ReceivedTextbox.Location = new Point(46, 142);
            ReceivedTextbox.Name = "ReceivedTextbox";
            ReceivedTextbox.Size = new Size(708, 262);
            ReceivedTextbox.TabIndex = 9;
            ReceivedTextbox.Text = "";
            // 
            // PortTextbox
            // 
            PortTextbox.Location = new Point(108, 52);
            PortTextbox.Name = "PortTextbox";
            PortTextbox.Size = new Size(125, 27);
            PortTextbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 95);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 7;
            label2.Text = "Received Messages";
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Location = new Point(46, 55);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(38, 20);
            PortLabel.TabIndex = 6;
            PortLabel.Text = "Port:";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(ListenButton);
            Controls.Add(ReceivedTextbox);
            Controls.Add(PortTextbox);
            Controls.Add(label2);
            Controls.Add(PortLabel);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button ListenButton;
        private RichTextBox ReceivedTextbox;
        private TextBox PortTextbox;
        private Label label2;
        private Label PortLabel;
    }
}