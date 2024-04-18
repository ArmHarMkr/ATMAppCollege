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
            this.BankNames = new System.Windows.Forms.ComboBox();
            this.CardNumberInput = new System.Windows.Forms.TextBox();
            this.SendAmountInput = new System.Windows.Forms.MaskedTextBox();
            this.MoneyTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankNames
            // 
            this.BankNames.FormattingEnabled = true;
            this.BankNames.Items.AddRange(new object[] {
            "Bless Bank",
            "Ameriabank",
            "ArmBussinessBank",
            "Inecobank",
            "AcbaBank",
            "Central Bank",
            "UniBank"});
            this.BankNames.Location = new System.Drawing.Point(31, 26);
            this.BankNames.Name = "BankNames";
            this.BankNames.Size = new System.Drawing.Size(181, 23);
            this.BankNames.TabIndex = 0;
            // 
            // CardNumberInput
            // 
            this.CardNumberInput.Location = new System.Drawing.Point(31, 71);
            this.CardNumberInput.Name = "CardNumberInput";
            this.CardNumberInput.PlaceholderText = "Input receiver card number";
            this.CardNumberInput.Size = new System.Drawing.Size(181, 23);
            this.CardNumberInput.TabIndex = 1;
            // 
            // SendAmountInput
            // 
            this.SendAmountInput.Location = new System.Drawing.Point(31, 116);
            this.SendAmountInput.Mask = "000000";
            this.SendAmountInput.Name = "SendAmountInput";
            this.SendAmountInput.Size = new System.Drawing.Size(181, 23);
            this.SendAmountInput.TabIndex = 2;
            // 
            // MoneyTransfer
            // 
            this.MoneyTransfer.Location = new System.Drawing.Point(31, 162);
            this.MoneyTransfer.Name = "MoneyTransfer";
            this.MoneyTransfer.Size = new System.Drawing.Size(181, 38);
            this.MoneyTransfer.TabIndex = 3;
            this.MoneyTransfer.Text = "Send";
            this.MoneyTransfer.UseVisualStyleBackColor = true;
            this.MoneyTransfer.Click += new System.EventHandler(this.MoneyTransfer_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 212);
            this.Controls.Add(this.MoneyTransfer);
            this.Controls.Add(this.SendAmountInput);
            this.Controls.Add(this.CardNumberInput);
            this.Controls.Add(this.BankNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox BankNames;
        private TextBox CardNumberInput;
        private MaskedTextBox SendAmountInput;
        private Button MoneyTransfer;
    }
}