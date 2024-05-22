namespace ATMAppCollege
{
    partial class CashOut
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
            CashOutButton = new Button();
            cashOutTextBox = new TextBox();
            ExitBtn = new Button();
            SuspendLayout();
            // 
            // CashOutButton
            // 
            CashOutButton.Location = new Point(42, 41);
            CashOutButton.Name = "CashOutButton";
            CashOutButton.Size = new Size(75, 54);
            CashOutButton.TabIndex = 1;
            CashOutButton.Text = "Cash out";
            CashOutButton.UseVisualStyleBackColor = true;
            CashOutButton.Click += CashOutButton_Click;
            // 
            // cashOutTextBox
            // 
            cashOutTextBox.Location = new Point(42, 12);
            cashOutTextBox.Name = "cashOutTextBox";
            cashOutTextBox.Size = new Size(158, 23);
            cashOutTextBox.TabIndex = 2;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(125, 41);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 54);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Go Back";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // CashOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 108);
            Controls.Add(ExitBtn);
            Controls.Add(cashOutTextBox);
            Controls.Add(CashOutButton);
            Name = "CashOut";
            Text = "CashOut";
            Load += CashOut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CashOutButton;
        private TextBox cashOutTextBox;
        private Button ExitBtn;
    }
}