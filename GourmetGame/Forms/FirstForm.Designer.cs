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
            StartGame = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // StartGame
            // 
            StartGame.Location = new Point(93, 65);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(75, 23);
            StartGame.TabIndex = 0;
            StartGame.Text = "Ok";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Click += StartGame_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 29);
            label1.Name = "label1";
            label1.Size = new Size(165, 15);
            label1.TabIndex = 1;
            label1.Text = "Pense em um prato que gosta";
            // 
            // FirstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(267, 110);
            Controls.Add(label1);
            Controls.Add(StartGame);
            Name = "FirstForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo Gourmet";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartGame;
        private Label label1;
    }
}
