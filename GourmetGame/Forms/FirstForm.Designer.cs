namespace GourmetGame
{
    partial class FirstForm
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
            startGameButton = new Button();
            textLabel = new Label();
            SuspendLayout();
            // 
            // StartGame
            // 
            startGameButton.Location = new Point(93, 65);
            startGameButton.Name = "StartGame";
            startGameButton.Size = new Size(75, 23);
            startGameButton.TabIndex = 0;
            startGameButton.Text = "Ok";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += StartGame_Click;
            // 
            // label1
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new Point(44, 29);
            textLabel.Name = "label1";
            textLabel.Size = new Size(165, 15);
            textLabel.TabIndex = 1;
            textLabel.Text = "Pense em um prato que gosta";
            // 
            // FirstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(267, 110);
            Controls.Add(textLabel);
            Controls.Add(startGameButton);
            Name = "FirstForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startGameButton;
        private Label textLabel;
    }
}
