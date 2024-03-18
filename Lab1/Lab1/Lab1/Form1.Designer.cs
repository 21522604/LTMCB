namespace Lab1
{
    partial class Form1
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
            button1 = new Button();
            Bai2 = new Button();
            Bai3Button = new Button();
            Bai4Button = new Button();
            Bai5Button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(113, 64);
            button1.Name = "button1";
            button1.Size = new Size(209, 55);
            button1.TabIndex = 0;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai2
            // 
            Bai2.Location = new Point(454, 64);
            Bai2.Name = "Bai2";
            Bai2.Size = new Size(209, 55);
            Bai2.TabIndex = 1;
            Bai2.Text = "Bài 2";
            Bai2.UseVisualStyleBackColor = true;
            Bai2.Click += Bai2_Click;
            // 
            // Bai3Button
            // 
            Bai3Button.Location = new Point(113, 173);
            Bai3Button.Name = "Bai3Button";
            Bai3Button.Size = new Size(209, 55);
            Bai3Button.TabIndex = 2;
            Bai3Button.Text = "Bài 3 ";
            Bai3Button.UseVisualStyleBackColor = true;
            Bai3Button.Click += Bai3Button_Click;
            // 
            // Bai4Button
            // 
            Bai4Button.Location = new Point(454, 173);
            Bai4Button.Name = "Bai4Button";
            Bai4Button.Size = new Size(209, 55);
            Bai4Button.TabIndex = 3;
            Bai4Button.Text = "Bài 4 ";
            Bai4Button.UseVisualStyleBackColor = true;
            Bai4Button.Click += Bai4Button_Click;
            // 
            // Bai5Button
            // 
            Bai5Button.Location = new Point(113, 299);
            Bai5Button.Name = "Bai5Button";
            Bai5Button.Size = new Size(209, 55);
            Bai5Button.TabIndex = 4;
            Bai5Button.Text = "Bài 5";
            Bai5Button.UseVisualStyleBackColor = true;
            Bai5Button.Click += Bai5Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Bai5Button);
            Controls.Add(Bai4Button);
            Controls.Add(Bai3Button);
            Controls.Add(Bai2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Lab 1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button Bai2;
        private Button Bai3Button;
        private Button Bai4Button;
        private Button Bai5Button;
    }
}
