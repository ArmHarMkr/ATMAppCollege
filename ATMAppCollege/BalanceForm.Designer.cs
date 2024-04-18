namespace ATMAppCollege
{
    partial class BalanceForm
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
            BalanceLabel = new Label();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // BalanceLabel
            // 
            BalanceLabel.AutoSize = true;
            BalanceLabel.Location = new Point(150, 9);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(38, 15);
            BalanceLabel.TabIndex = 0;
            BalanceLabel.Text = "label1";
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(139, 48);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(75, 47);
            GoBackButton.TabIndex = 1;
            GoBackButton.Text = "Go Back";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // BalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 107);
            Controls.Add(GoBackButton);
            Controls.Add(BalanceLabel);
            Name = "BalanceForm";
            Text = "BalanceForm";
            Load += BalanceForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BalanceLabel;
        private Button GoBackButton;
    }
}