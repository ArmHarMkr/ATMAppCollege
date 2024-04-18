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
            SendAmountInput = new MaskedTextBox();
            CardNumberInput = new TextBox();
            SuspendLayout();
            // 
            // MoneyTransfer
            // 
            MoneyTransfer.Location = new Point(12, 70);
            MoneyTransfer.Name = "MoneyTransfer";
            MoneyTransfer.Size = new Size(181, 38);
            MoneyTransfer.TabIndex = 7;
            MoneyTransfer.Text = "Send";
            MoneyTransfer.UseVisualStyleBackColor = true;
            MoneyTransfer.Click += MoneyTransfer_Click;
            // 
            // SendAmountInput
            // 
            SendAmountInput.Location = new Point(12, 41);
            SendAmountInput.Mask = "000000";
            SendAmountInput.Name = "SendAmountInput";
            SendAmountInput.Size = new Size(181, 23);
            SendAmountInput.TabIndex = 6;
            // 
            // CardNumberInput
            // 
            CardNumberInput.Location = new Point(12, 12);
            CardNumberInput.Name = "CardNumberInput";
            CardNumberInput.PlaceholderText = "Input receiver card number";
            CardNumberInput.Size = new Size(181, 23);
            CardNumberInput.TabIndex = 5;
            // 
            // TransferOwnBank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 120);
            Controls.Add(MoneyTransfer);
            Controls.Add(SendAmountInput);
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
        private MaskedTextBox SendAmountInput;
        private TextBox CardNumberInput;
    }
}