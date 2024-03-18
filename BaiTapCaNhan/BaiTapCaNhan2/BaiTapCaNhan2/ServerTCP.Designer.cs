namespace BaiTapCaNhan2
{
    partial class ServerTCP
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
            ListenButton = new Button();
            ReceivedTextbox = new RichTextBox();
            SuspendLayout();
            // 
            // ListenButton
            // 
            ListenButton.Location = new Point(652, 39);
            ListenButton.Name = "ListenButton";
            ListenButton.Size = new Size(94, 29);
            ListenButton.TabIndex = 0;
            ListenButton.Text = "Listen";
            ListenButton.UseVisualStyleBackColor = true;
            ListenButton.Click += ListenButton_Click;
            // 
            // ReceivedTextbox
            // 
            ReceivedTextbox.Location = new Point(33, 89);
            ReceivedTextbox.Name = "ReceivedTextbox";
            ReceivedTextbox.Size = new Size(713, 316);
            ReceivedTextbox.TabIndex = 1;
            ReceivedTextbox.Text = "";
            // 
            // ServerTCP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReceivedTextbox);
            Controls.Add(ListenButton);
            Name = "ServerTCP";
            Text = "ServerTCP";
            FormClosing += ServerTCP_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button ListenButton;
        private RichTextBox ReceivedTextbox;
    }
}