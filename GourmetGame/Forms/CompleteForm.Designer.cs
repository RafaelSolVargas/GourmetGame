﻿namespace GourmetGame.Forms
{
    partial class CompleteForm
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
            completeQuestion = new Label();
            confirmCompleteButton = new Button();
            cancelCompleteButton = new Button();
            newQualityInput = new TextBox();
            SuspendLayout();
            // 
            // completeQuestion
            // 
            completeQuestion.AutoSize = true;
            completeQuestion.Location = new Point(102, 27);
            completeQuestion.Name = "completeQuestion";
            completeQuestion.Size = new Size(69, 15);
            completeQuestion.TabIndex = 0;
            completeQuestion.Text = "Default Text";
            // 
            // confirmCompleteButton
            // 
            confirmCompleteButton.Location = new Point(64, 90);
            confirmCompleteButton.Name = "confirmCompleteButton";
            confirmCompleteButton.Size = new Size(75, 23);
            confirmCompleteButton.TabIndex = 1;
            confirmCompleteButton.Text = "Ok";
            confirmCompleteButton.UseVisualStyleBackColor = true;
            confirmCompleteButton.Click += ConfirmClick;
            // 
            // cancelCompleteButton
            // 
            cancelCompleteButton.Location = new Point(145, 90);
            cancelCompleteButton.Name = "cancelCompleteButton";
            cancelCompleteButton.Size = new Size(75, 23);
            cancelCompleteButton.TabIndex = 2;
            cancelCompleteButton.Text = "Cancelar";
            cancelCompleteButton.UseVisualStyleBackColor = true;
            cancelCompleteButton.Click += CancelButton_Click;
            // 
            // newQualityInput
            // 
            newQualityInput.Location = new Point(53, 54);
            newQualityInput.Name = "newQualityInput";
            newQualityInput.Size = new Size(178, 23);
            newQualityInput.TabIndex = 3;
            // 
            // CompleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(284, 136);
            Controls.Add(newQualityInput);
            Controls.Add(cancelCompleteButton);
            Controls.Add(confirmCompleteButton);
            Controls.Add(completeQuestion);
            Name = "CompleteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complete";
            Load += CompleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label completeQuestion;
        private Button confirmCompleteButton;
        private Button cancelCompleteButton;
        private TextBox newQualityInput;
    }
}