namespace ATMAppCollege
{
    partial class TransferOwnBank
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
            MoneyTransfer = new Button();
            CardNumberInput = new TextBox();
            SendAmountInput = new TextBox();
            GoBackBtn = new Button();
            SuspendLayout();
            // 
            // MoneyTransfer
            // 
            MoneyTransfer.Location = new Point(12, 70);
            MoneyTransfer.Name = "MoneyTransfer";
            MoneyTransfer.Size = new Size(91, 38);
            MoneyTransfer.TabIndex = 7;
            MoneyTransfer.Text = "Send";
            MoneyTransfer.UseVisualStyleBackColor = true;
            MoneyTransfer.Click += MoneyTransfer_Click;
            // 
            // CardNumberInput
            // 
            CardNumberInput.Location = new Point(12, 12);
            CardNumberInput.Name = "CardNumberInput";
            CardNumberInput.PlaceholderText = "Input receiver card number";
            CardNumberInput.Size = new Size(181, 23);
            CardNumberInput.TabIndex = 5;
            // 
            // SendAmountInput
            // 
            SendAmountInput.Location = new Point(12, 41);
            SendAmountInput.Name = "SendAmountInput";
            SendAmountInput.Size = new Size(181, 23);
            SendAmountInput.TabIndex = 8;
            // 
            // GoBackBtn
            // 
            GoBackBtn.Location = new Point(109, 70);
            GoBackBtn.Name = "GoBackBtn";
            GoBackBtn.Size = new Size(84, 38);
            GoBackBtn.TabIndex = 9;
            GoBackBtn.Text = "Go Back";
            GoBackBtn.UseVisualStyleBackColor = true;
            GoBackBtn.Click += GoBackBtn_Click;
            // 
            // TransferOwnBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 120);
            Controls.Add(GoBackBtn);
            Controls.Add(SendAmountInput);
            Controls.Add(MoneyTransfer);
            Controls.Add(CardNumberInput);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TransferOwnBank";
            Text = "TransferOwnBank";
            Load += TransferOwnBank_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MoneyTransfer;
        private TextBox CardNumberInput;
        private TextBox SendAmountInput;
        private Button GoBackBtn;
    }
}