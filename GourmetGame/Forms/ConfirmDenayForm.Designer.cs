namespace GourmetGame.Forms
{
    partial class ConfirmDenayForm
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
            Question = new Label();
            confirmNo = new Button();
            confirmYes = new Button();
            SuspendLayout();
            // 
            // Question
            // 
            Question.AutoSize = true;
            Question.Location = new Point(78, 27);
            Question.Name = "Question";
            Question.Size = new Size(69, 15);
            Question.TabIndex = 0;
            Question.Text = "Default Text";
            // 
            // confirmNo
            // 
            confirmNo.Cursor = Cursors.Hand;
            confirmNo.Location = new Point(126, 73);
            confirmNo.Name = "confirmNo";
            confirmNo.RightToLeft = RightToLeft.Yes;
            confirmNo.Size = new Size(75, 23);
            confirmNo.TabIndex = 2;
            confirmNo.Text = "Não";
            confirmNo.UseVisualStyleBackColor = true;
            confirmNo.Click += ButtonNoClick;
            // 
            // confirmYes
            // 
            confirmYes.Location = new Point(35, 73);
            confirmYes.Name = "confirmYes";
            confirmYes.Size = new Size(75, 23);
            confirmYes.TabIndex = 3;
            confirmYes.Text = "Sim";
            confirmYes.UseVisualStyleBackColor = true;
            confirmYes.Click += ButtonYesClick;
            // 
            // ConfirmDenayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(243, 113);
            Controls.Add(confirmYes);
            Controls.Add(confirmNo);
            Controls.Add(Question);
            Name = "ConfirmDenayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm";
            Load += ConfirmDenayForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Question;
        private Button confirmNo;
        private Button confirmYes;
    }
}