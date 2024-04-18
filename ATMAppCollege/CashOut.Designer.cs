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
            cashOutMasked = new MaskedTextBox();
            CashOutButton = new Button();
            SuspendLayout();
            // 
            // cashOutMasked
            // 
            cashOutMasked.Location = new Point(68, 12);
            cashOutMasked.Mask = "111111";
            cashOutMasked.Name = "cashOutMasked";
            cashOutMasked.Size = new Size(100, 23);
            cashOutMasked.TabIndex = 0;
            // 
            // CashOutButton
            // 
            CashOutButton.Location = new Point(80, 41);
            CashOutButton.Name = "CashOutButton";
            CashOutButton.Size = new Size(75, 54);
            CashOutButton.TabIndex = 1;
            CashOutButton.Text = "Cash out";
            CashOutButton.UseVisualStyleBackColor = true;
            CashOutButton.Click += CashOutButton_Click;
            // 
            // CashOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 108);
            Controls.Add(CashOutButton);
            Controls.Add(cashOutMasked);
            Name = "CashOut";
            Text = "CashOut";
            Load += CashOut_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox cashOutMasked;
        private Button CashOutButton;
    }
}