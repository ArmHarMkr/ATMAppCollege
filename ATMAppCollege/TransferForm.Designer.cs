namespace ATMAppCollege
{
    partial class TransferForm
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
            BankNames = new ComboBox();
            CardNumberInput = new TextBox();
            MoneyTransfer = new Button();
            SendAmountInput = new TextBox();
            SuspendLayout();
            // 
            // BankNames
            // 
            BankNames.FormattingEnabled = true;
            BankNames.Items.AddRange(new object[] { "Bless Bank", "Ameriabank", "ArmBussinessBank", "Inecobank", "AcbaBank", "Central Bank", "UniBank" });
            BankNames.Location = new Point(31, 26);
            BankNames.Name = "BankNames";
            BankNames.Size = new Size(181, 23);
            BankNames.TabIndex = 0;
            // 
            // CardNumberInput
            // 
            CardNumberInput.Location = new Point(31, 71);
            CardNumberInput.Name = "CardNumberInput";
            CardNumberInput.PlaceholderText = "Input receiver card number";
            CardNumberInput.Size = new Size(181, 23);
            CardNumberInput.TabIndex = 1;
            // 
            // MoneyTransfer
            // 
            MoneyTransfer.Location = new Point(31, 162);
            MoneyTransfer.Name = "MoneyTransfer";
            MoneyTransfer.Size = new Size(181, 38);
            MoneyTransfer.TabIndex = 3;
            MoneyTransfer.Text = "Send";
            MoneyTransfer.UseVisualStyleBackColor = true;
            MoneyTransfer.Click += MoneyTransfer_Click;
            // 
            // SendAmountInput
            // 
            SendAmountInput.Location = new Point(31, 110);
            SendAmountInput.Name = "SendAmountInput";
            SendAmountInput.Size = new Size(181, 23);
            SendAmountInput.TabIndex = 4;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 212);
            Controls.Add(SendAmountInput);
            Controls.Add(MoneyTransfer);
            Controls.Add(CardNumberInput);
            Controls.Add(BankNames);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "TransferForm";
            Text = "TransferForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox BankNames;
        private TextBox CardNumberInput;
        private Button MoneyTransfer;
        private TextBox SendAmountInput;
    }
}