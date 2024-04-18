namespace ATMAppCollege
{
    partial class LoginCard
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
            cardLoginInput = new MaskedTextBox();
            label1 = new Label();
            LoginCardButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // cardLoginInput
            // 
            cardLoginInput.Location = new Point(110, 62);
            cardLoginInput.Mask = "0000";
            cardLoginInput.Name = "cardLoginInput";
            cardLoginInput.Size = new Size(88, 23);
            cardLoginInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 31);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Input password";
            // 
            // LoginCardButton
            // 
            LoginCardButton.Location = new Point(110, 91);
            LoginCardButton.Name = "LoginCardButton";
            LoginCardButton.Size = new Size(88, 41);
            LoginCardButton.TabIndex = 2;
            LoginCardButton.Text = "Login card";
            LoginCardButton.UseVisualStyleBackColor = true;
            LoginCardButton.Click += LoginCardButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(110, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit button";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LoginCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 156);
            Controls.Add(ExitButton);
            Controls.Add(LoginCardButton);
            Controls.Add(label1);
            Controls.Add(cardLoginInput);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginCard";
            Text = "LoginCard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox cardLoginInput;
        private Label label1;
        private Button LoginCardButton;
        private Button ExitButton;
    }
}