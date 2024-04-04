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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(67, 22);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Acertei denovo!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeWinButton
            // 
            closeWinButton.Location = new Point(67, 49);
            closeWinButton.Name = "closeWinButton";
            closeWinButton.Size = new Size(75, 23);
            closeWinButton.TabIndex = 1;
            closeWinButton.Text = "Ok";
            closeWinButton.UseVisualStyleBackColor = true;
            closeWinButton.Click += CloseWinButton_Click;
            // 
            // WinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(220, 91);
            Controls.Add(closeWinButton);
            Controls.Add(label1);
            Name = "WinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button closeWinButton;
    }
}