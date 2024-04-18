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
            ChashInAmount = new MaskedTextBox();
            CashInButton = new Button();
            toolStrip1 = new ToolStrip();
            CashInProgress = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ChashInAmount
            // 
            ChashInAmount.Location = new Point(79, 28);
            ChashInAmount.Mask = "000000";
            ChashInAmount.Name = "ChashInAmount";
            ChashInAmount.Size = new Size(100, 23);
            ChashInAmount.TabIndex = 0;
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { CashInProgress });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(247, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // CashInProgress
            // 
            CashInProgress.Margin = new Padding(45, 2, 1, 1);
            CashInProgress.Name = "CashInProgress";
            CashInProgress.Size = new Size(150, 22);
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CashIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 111);
            Controls.Add(toolStrip1);
            Controls.Add(CashInButton);
            Controls.Add(ChashInAmount);
            Name = "CashIn";
            Text = "Cash in";
            Load += CashIn_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox ChashInAmount;
        private Button CashInButton;
        private ToolStrip toolStrip1;
        private ToolStripProgressBar CashInProgress;
        private System.Windows.Forms.Timer timer1;
    }
}