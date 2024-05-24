namespace ATMAppCollege
{
    partial class UserInfoForm
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
            NameLabel = new Label();
            CardNumberLabel = new Label();
            PinCodeLabel = new Label();
            EmailLabel = new Label();
            PasswordLabel = new Label();
            GoBackBtn = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(38, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "label1";
            // 
            // CardNumberLabel
            // 
            CardNumberLabel.AutoSize = true;
            CardNumberLabel.Location = new Point(196, 9);
            CardNumberLabel.Name = "CardNumberLabel";
            CardNumberLabel.Size = new Size(38, 15);
            CardNumberLabel.TabIndex = 1;
            CardNumberLabel.Text = "label2";
            // 
            // PinCodeLabel
            // 
            PinCodeLabel.AutoSize = true;
            PinCodeLabel.Location = new Point(356, 9);
            PinCodeLabel.Name = "PinCodeLabel";
            PinCodeLabel.Size = new Size(38, 15);
            PinCodeLabel.TabIndex = 2;
            PinCodeLabel.Text = "label3";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(12, 52);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(38, 15);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "label2";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(356, 52);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(38, 15);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "label2";
            // 
            // GoBackBtn
            // 
            GoBackBtn.BackColor = Color.Chartreuse;
            GoBackBtn.Location = new Point(159, 79);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(119, 67);
            GoBackBtn.TabIndex = 6;
            GoBackBtn.Text = "Go Back";
            GoBackBtn.UseVisualStyleBackColor = false;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // UserInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(454, 150);
            Controls.Add(GoBackBtn);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Controls.Add(PinCodeLabel);
            Controls.Add(CardNumberLabel);
            Controls.Add(NameLabel);
            Name = "UserInfoForm";
            Text = "UserInfoForm";
            Load += UserInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label CardNumberLabel;
        private Label PinCodeLabel;
        private Label EmailLabel;
        private Label PasswordLabel;
        private Button GoBackBtn;
    }
}