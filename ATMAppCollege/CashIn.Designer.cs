namespace ATMAppCollege
{
    partial class CashIn
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
            components = new System.ComponentModel.Container();
            CashInButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            CashInAmount = new TextBox();
            SuspendLayout();
            // 
            // CashInButton
            // 
            CashInButton.Location = new Point(79, 57);
            CashInButton.Name = "CashInButton";
            CashInButton.Size = new Size(100, 52);
            CashInButton.TabIndex = 1;
            CashInButton.Text = "Cash In";
            CashInButton.UseVisualStyleBackColor = true;
            CashInButton.Click += CashInButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CashInAmount
            // 
            CashInAmount.Location = new Point(51, 12);
            CashInAmount.Name = "CashInAmount";
            CashInAmount.Size = new Size(155, 23);
            CashInAmount.TabIndex = 3;
            CashInAmount.TextChanged += ChashInAmount_TextChanged;
            // 
            // CashIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 111);
            Controls.Add(CashInAmount);
            Controls.Add(CashInButton);
            Name = "CashIn";
            Text = "Cash in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CashInButton;
        private System.Windows.Forms.Timer timer1;
        private TextBox CashInAmount;
    }
}