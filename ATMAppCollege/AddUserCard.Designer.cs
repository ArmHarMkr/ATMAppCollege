namespace ATMAppCollege
{
    partial class AddUserCard
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
            CreateCardButton = new Button();
            passwordTextBox = new MaskedTextBox();
            CloseAppButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Create password";
            // 
            // CreateCardButton
            // 
            CreateCardButton.Location = new Point(22, 92);
            CreateCardButton.Name = "CreateCardButton";
            CreateCardButton.Size = new Size(118, 55);
            CreateCardButton.TabIndex = 2;
            CreateCardButton.Text = "Create a Card";
            CreateCardButton.UseVisualStyleBackColor = true;
            CreateCardButton.Click += CreateCardButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(125, 53);
            passwordTextBox.Mask = "0000";
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(70, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.ValidatingType = typeof(int);
            // 
            // CloseAppButton
            // 
            CloseAppButton.Location = new Point(153, 92);
            CloseAppButton.Name = "CloseAppButton";
            CloseAppButton.Size = new Size(125, 55);
            CloseAppButton.TabIndex = 4;
            CloseAppButton.Text = "Exit";
            CloseAppButton.UseVisualStyleBackColor = true;
            CloseAppButton.Click += CloseAppButton_Click;
            // 
            // AddUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 159);
            Controls.Add(CloseAppButton);
            Controls.Add(passwordTextBox);
            Controls.Add(CreateCardButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddUserCard";
            Text = "Create Card";
            Load += AddUserCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CreateCardButton;
        private MaskedTextBox passwordTextBox;
        private Button CloseAppButton;
    }
}