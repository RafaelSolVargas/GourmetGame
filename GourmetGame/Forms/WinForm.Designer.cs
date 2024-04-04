namespace GourmetGame.Forms
{
    partial class WinForm
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
            label1 = new Label();
            closeWinButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(80, 25);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Acertei de novo!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeWinButton
            // 
            closeWinButton.Location = new Point(82, 52);
            closeWinButton.Name = "closeWinButton";
            closeWinButton.Size = new Size(74, 27);
            closeWinButton.TabIndex = 1;
            closeWinButton.Text = "Ok";
            closeWinButton.UseVisualStyleBackColor = true;
            closeWinButton.Click += CloseWinButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ImageLocation = "E:\\Work\\Objective\\GourmetGame\\GourmetGame\\Images\\exclamation-icon.png";
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // WinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(245, 91);
            Controls.Add(pictureBox1);
            Controls.Add(closeWinButton);
            Controls.Add(label1);
            Name = "WinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            Load += WinForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button closeWinButton;
        private PictureBox pictureBox1;
    }
}