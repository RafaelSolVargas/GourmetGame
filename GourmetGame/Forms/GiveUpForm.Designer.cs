

namespace GourmetGame.Forms
{
    partial class GiveUpForm
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
            actualFoodInputText = new TextBox();
            confirmNewFoodButton = new Button();
            cancelNewFoodButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 22);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 0;
            label1.Text = "Qual prato você pensou?";
            // 
            // actualFoodInputText
            // 
            actualFoodInputText.Location = new Point(61, 52);
            actualFoodInputText.Name = "actualFoodInputText";
            actualFoodInputText.Size = new Size(186, 23);
            actualFoodInputText.TabIndex = 1;
            // 
            // confirmNewFoodButton
            // 
            confirmNewFoodButton.Location = new Point(75, 84);
            confirmNewFoodButton.Name = "confirmNewFoodButton";
            confirmNewFoodButton.Size = new Size(75, 23);
            confirmNewFoodButton.TabIndex = 2;
            confirmNewFoodButton.Text = "Ok";
            confirmNewFoodButton.UseVisualStyleBackColor = true;
            confirmNewFoodButton.Click += ConfirmNewFoodButton_Click;
            // 
            // cancelNewFoodButton
            // 
            cancelNewFoodButton.Location = new Point(156, 84);
            cancelNewFoodButton.Name = "cancelNewFoodButton";
            cancelNewFoodButton.Size = new Size(75, 23);
            cancelNewFoodButton.TabIndex = 3;
            cancelNewFoodButton.Text = "Cancelar";
            cancelNewFoodButton.UseVisualStyleBackColor = true;
            cancelNewFoodButton.Click += CancelNewFoodButton_Click;
            // 
            // GiveUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(316, 119);
            Controls.Add(cancelNewFoodButton);
            Controls.Add(confirmNewFoodButton);
            Controls.Add(actualFoodInputText);
            Controls.Add(label1);
            Name = "GiveUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desisto";
            Load += GiveUpForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox actualFoodInputText;
        private Button confirmNewFoodButton;
        private Button cancelNewFoodButton;
    }
}