namespace ATMAppCollege
{
    partial class ActionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionsForm));
            ExchangeButton = new Button();
            TransOtherButton = new Button();
            TransOwnBank = new Button();
            Balance = new Button();
            CashOutButton = new Button();
            CashInButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            testNameLabel = new Label();
            testCardLabel = new Label();
            SuspendLayout();
            // 
            // ExchangeButton
            // 
            ExchangeButton.BackColor = SystemColors.ActiveBorder;
            ExchangeButton.Location = new Point(-73, 22);
            ExchangeButton.Name = "ExchangeButton";
            ExchangeButton.Size = new Size(128, 44);
            ExchangeButton.TabIndex = 0;
            ExchangeButton.UseVisualStyleBackColor = false;
            ExchangeButton.Click += ExchangeButton_Click;
            // 
            // TransOtherButton
            // 
            TransOtherButton.BackColor = SystemColors.ActiveBorder;
            TransOtherButton.Location = new Point(-73, 118);
            TransOtherButton.Name = "TransOtherButton";
            TransOtherButton.Size = new Size(128, 44);
            TransOtherButton.TabIndex = 1;
            TransOtherButton.UseVisualStyleBackColor = false;
            TransOtherButton.Click += TransOtherButton_Click;
            // 
            // TransOwnBank
            // 
            TransOwnBank.BackColor = SystemColors.ActiveBorder;
            TransOwnBank.Location = new Point(-73, 214);
            TransOwnBank.Name = "TransOwnBank";
            TransOwnBank.Size = new Size(128, 44);
            TransOwnBank.TabIndex = 2;
            TransOwnBank.UseVisualStyleBackColor = false;
            TransOwnBank.Click += TransOwnBank_Click;
            // 
            // Balance
            // 
            Balance.BackColor = SystemColors.ActiveBorder;
            Balance.Location = new Point(508, 214);
            Balance.Name = "Balance";
            Balance.Size = new Size(128, 44);
            Balance.TabIndex = 5;
            Balance.UseVisualStyleBackColor = false;
            Balance.Click += Balance_Click;
            // 
            // CashOutButton
            // 
            CashOutButton.BackColor = SystemColors.ActiveBorder;
            CashOutButton.Location = new Point(508, 118);
            CashOutButton.Name = "CashOutButton";
            CashOutButton.Size = new Size(128, 44);
            CashOutButton.TabIndex = 4;
            CashOutButton.UseVisualStyleBackColor = false;
            CashOutButton.Click += CashOutButton_Click;
            // 
            // CashInButton
            // 
            CashInButton.BackColor = SystemColors.ActiveBorder;
            CashInButton.Location = new Point(508, 22);
            CashInButton.Name = "CashInButton";
            CashInButton.Size = new Size(128, 44);
            CashInButton.TabIndex = 3;
            CashInButton.UseVisualStyleBackColor = false;
            CashInButton.Click += CashInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 6;
            label1.Text = "Exchange";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(61, 133);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 7;
            label2.Text = "Transfer (other Bank)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(61, 229);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 8;
            label3.Text = "Transfer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(454, 37);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 9;
            label4.Text = "Cash in";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(446, 133);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 10;
            label5.Text = "Cash out";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Silver;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(446, 229);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 11;
            label6.Text = "Balance";
            // 
            // testNameLabel
            // 
            testNameLabel.AutoSize = true;
            testNameLabel.Location = new Point(273, 84);
            testNameLabel.Name = "testNameLabel";
            testNameLabel.Size = new Size(38, 15);
            testNameLabel.TabIndex = 13;
            testNameLabel.Text = "label8";
            testNameLabel.Click += testNameLabel_Click;
            // 
            // testCardLabel
            // 
            testCardLabel.AutoSize = true;
            testCardLabel.Location = new Point(273, 118);
            testCardLabel.Name = "testCardLabel";
            testCardLabel.Size = new Size(38, 15);
            testCardLabel.TabIndex = 14;
            testCardLabel.Text = "label8";
            // 
            // ActionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(566, 288);
            Controls.Add(testCardLabel);
            Controls.Add(testNameLabel);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Balance);
            Controls.Add(CashOutButton);
            Controls.Add(CashInButton);
            Controls.Add(TransOwnBank);
            Controls.Add(TransOtherButton);
            Controls.Add(ExchangeButton);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ActionsForm";
            Text = "ActionsForm";
            Load += ActionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExchangeButton;
        private Button TransOtherButton;
        private Button TransOwnBank;
        private Button Balance;
        private Button CashOutButton;
        private Button CashInButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label testNameLabel;
        private Label testCardLabel;
    }
}