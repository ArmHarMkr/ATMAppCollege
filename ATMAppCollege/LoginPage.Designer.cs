namespace ATMAppCollege
{
    partial class LoginPage
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
            PasswordInput = new TextBox();
            EmailInput = new TextBox();
            RegisterButton = new Button();
            LoginButton = new Button();
            label2 = new Label();
            RulesCheckBox = new CheckBox();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.Font = new Font("Segoe UI Emoji", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(82, 24);
            label1.Name = "label1";
            label1.Size = new Size(103, 43);
            label1.TabIndex = 11;
            label1.Text = "Login";
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.DarkCyan;
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Location = new Point(40, 158);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '•';
            PasswordInput.PlaceholderText = "Password";
            PasswordInput.Size = new Size(218, 16);
            PasswordInput.TabIndex = 10;
            // 
            // EmailInput
            // 
            EmailInput.BackColor = Color.DarkCyan;
            EmailInput.BorderStyle = BorderStyle.None;
            EmailInput.Location = new Point(39, 100);
            EmailInput.Name = "EmailInput";
            EmailInput.PlaceholderText = "Email";
            EmailInput.Size = new Size(218, 16);
            EmailInput.TabIndex = 9;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.FromArgb(255, 128, 0);
            RegisterButton.Location = new Point(71, 302);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(149, 42);
            RegisterButton.TabIndex = 13;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.FromArgb(255, 128, 0);
            LoginButton.Location = new Point(71, 233);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(149, 42);
            LoginButton.TabIndex = 14;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 67);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 15;
            // 
            // RulesCheckBox
            // 
            RulesCheckBox.AutoSize = true;
            RulesCheckBox.Location = new Point(82, 195);
            RulesCheckBox.Name = "RulesCheckBox";
            RulesCheckBox.Size = new Size(133, 19);
            RulesCheckBox.TabIndex = 16;
            RulesCheckBox.Text = "I have learnt all rules";
            RulesCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(40, 120);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(217, 2);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(40, 174);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.Yes;
            panel2.Size = new Size(217, 3);
            panel2.TabIndex = 18;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(294, 401);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(RulesCheckBox);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Controls.Add(label1);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginPage";
            Text = "Login Page";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox PasswordInput;
        private TextBox EmailInput;
        private Button RegisterButton;
        private Button LoginButton;
        private Label label2;
        private CheckBox RulesCheckBox;
        private Panel panel1;
        private Panel panel2;
    }
}