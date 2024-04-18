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
            this.label1 = new System.Windows.Forms.Label();
            this.CreateCardButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create password";
            // 
            // CreateCardButton
            // 
            this.CreateCardButton.Location = new System.Drawing.Point(49, 92);
            this.CreateCardButton.Name = "CreateCardButton";
            this.CreateCardButton.Size = new System.Drawing.Size(228, 55);
            this.CreateCardButton.TabIndex = 2;
            this.CreateCardButton.Text = "Create a Card";
            this.CreateCardButton.UseVisualStyleBackColor = true;
            this.CreateCardButton.Click += new System.EventHandler(this.CreateCardButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(125, 53);
            this.passwordTextBox.Mask = "0000";
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(70, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.ValidatingType = typeof(int);
            // 
            // AddUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 159);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.CreateCardButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUserCard";
            this.Text = "Create Card";
            this.Load += new System.EventHandler(this.AddUserCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button CreateCardButton;
        private MaskedTextBox passwordTextBox;
    }
}