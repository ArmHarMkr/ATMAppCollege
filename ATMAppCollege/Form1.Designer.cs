namespace ATMAppCollege
{
    partial class Form1
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
            EmailInput = new TextBox();
            PasswordInput = new TextBox();
            RegisterButton = new Button();
            emailError = new Label();
            NameError = new Label();
            PasswordError = new Label();
            LoginReference = new Button();
            groupBox1 = new GroupBox();
            FemaleRadio = new RadioButton();
            MaleRadio = new RadioButton();
            label1 = new Label();
            panel1 = new Panel();
            FullNameInput = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            progressBar1 = new ProgressBar();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EmailInput
            // 
            EmailInput.BackColor = Color.DarkCyan;
            EmailInput.BorderStyle = BorderStyle.None;
            EmailInput.Location = new Point(22, 149);
            EmailInput.Name = "EmailInput";
            EmailInput.PlaceholderText = "Mail";
            EmailInput.Size = new Size(218, 16);
            EmailInput.TabIndex = 1;
            EmailInput.TextChanged += EmailInput_TextChanged;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.DarkCyan;
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Location = new Point(22, 185);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PasswordChar = '•';
            PasswordInput.PlaceholderText = "Password";
            PasswordInput.Size = new Size(218, 16);
            PasswordInput.TabIndex = 2;
            PasswordInput.TextChanged += PasswordInput_TextChanged;
            // 
            // RegisterButton
            // 
            RegisterButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.FromArgb(255, 128, 0);
            RegisterButton.Location = new Point(49, 316);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(149, 42);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // emailError
            // 
            emailError.AutoSize = true;
            emailError.Location = new Point(45, 103);
            emailError.Name = "emailError";
            emailError.Size = new Size(0, 15);
            emailError.TabIndex = 5;
            // 
            // NameError
            // 
            NameError.AutoSize = true;
            NameError.Location = new Point(45, 75);
            NameError.Name = "NameError";
            NameError.Size = new Size(0, 15);
            NameError.TabIndex = 6;
            // 
            // PasswordError
            // 
            PasswordError.AutoSize = true;
            PasswordError.Location = new Point(155, 90);
            PasswordError.Name = "PasswordError";
            PasswordError.Size = new Size(0, 15);
            PasswordError.TabIndex = 7;
            // 
            // LoginReference
            // 
            LoginReference.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginReference.ForeColor = Color.FromArgb(255, 128, 0);
            LoginReference.Location = new Point(51, 373);
            LoginReference.Name = "LoginReference";
            LoginReference.Size = new Size(149, 42);
            LoginReference.TabIndex = 8;
            LoginReference.Text = "Login";
            LoginReference.UseVisualStyleBackColor = true;
            LoginReference.Click += LoginReference_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkCyan;
            groupBox1.Controls.Add(FemaleRadio);
            groupBox1.Controls.Add(MaleRadio);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(39, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(171, 73);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FemaleRadio
            // 
            FemaleRadio.AutoSize = true;
            FemaleRadio.Location = new Point(10, 45);
            FemaleRadio.Name = "FemaleRadio";
            FemaleRadio.Size = new Size(73, 19);
            FemaleRadio.TabIndex = 1;
            FemaleRadio.TabStop = true;
            FemaleRadio.Text = "Female";
            FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // MaleRadio
            // 
            MaleRadio.AutoSize = true;
            MaleRadio.Location = new Point(10, 20);
            MaleRadio.Name = "MaleRadio";
            MaleRadio.Size = new Size(57, 19);
            MaleRadio.TabIndex = 0;
            MaleRadio.TabStop = true;
            MaleRadio.Text = "Male";
            MaleRadio.UseVisualStyleBackColor = true;
            MaleRadio.CheckedChanged += MaleRadio_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Tahoma", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 35);
            label1.TabIndex = 12;
            label1.Text = "REGISTER";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(22, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 1);
            panel1.TabIndex = 14;
            // 
            // FullNameInput
            // 
            FullNameInput.BackColor = Color.DarkCyan;
            FullNameInput.BorderStyle = BorderStyle.None;
            FullNameInput.Location = new Point(22, 111);
            FullNameInput.Name = "FullNameInput";
            FullNameInput.PlaceholderText = "Name";
            FullNameInput.Size = new Size(218, 16);
            FullNameInput.TabIndex = 0;
            FullNameInput.TextChanged += FullNameInput_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(22, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 1);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(22, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 1);
            panel3.TabIndex = 16;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 52);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 20);
            progressBar1.TabIndex = 17;
            progressBar1.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(260, 477);
            Controls.Add(progressBar1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(LoginReference);
            Controls.Add(PasswordError);
            Controls.Add(NameError);
            Controls.Add(emailError);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordInput);
            Controls.Add(EmailInput);
            Controls.Add(FullNameInput);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Register";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox EmailInput;
        private TextBox PasswordInput;
        private Button RegisterButton;
        private Label emailError;
        private Label NameError;
        private Label PasswordError;
        private Button LoginReference;
        private GroupBox groupBox1;
        private RadioButton FemaleRadio;
        private RadioButton MaleRadio;
        private Label label1;
        private Panel panel1;
        private TextBox FullNameInput;
        private Panel panel2;
        private Panel panel3;
        private ProgressBar progressBar1;
    }
}