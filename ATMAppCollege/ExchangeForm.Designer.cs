namespace ATMAppCollege
{
    partial class ExchangeForm
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
            NominalOpt = new ComboBox();
            ConvertButton = new Button();
            groupBox1 = new GroupBox();
            ConvertingMoney = new TextBox();
            ConvertResultLabel = new Label();
            GoToActions = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NominalOpt
            // 
            NominalOpt.FormattingEnabled = true;
            NominalOpt.Items.AddRange(new object[] { "AMD", "Dollar" });
            NominalOpt.Location = new Point(6, 44);
            NominalOpt.Name = "NominalOpt";
            NominalOpt.Size = new Size(156, 23);
            NominalOpt.TabIndex = 0;
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(6, 173);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(156, 69);
            ConvertButton.TabIndex = 4;
            ConvertButton.Text = "Convert";
            ConvertButton.UseVisualStyleBackColor = true;
            ConvertButton.Click += ConvertButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ConvertingMoney);
            groupBox1.Controls.Add(NominalOpt);
            groupBox1.Controls.Add(ConvertButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(185, 250);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Finances input";
            // 
            // ConvertingMoney
            // 
            ConvertingMoney.Location = new Point(6, 88);
            ConvertingMoney.Name = "ConvertingMoney";
            ConvertingMoney.Size = new Size(156, 23);
            ConvertingMoney.TabIndex = 5;
            // 
            // ConvertResultLabel
            // 
            ConvertResultLabel.AutoSize = true;
            ConvertResultLabel.Location = new Point(240, 108);
            ConvertResultLabel.Name = "ConvertResultLabel";
            ConvertResultLabel.Size = new Size(80, 15);
            ConvertResultLabel.TabIndex = 6;
            ConvertResultLabel.Text = "Convert place";
            // 
            // GoToActions
            // 
            GoToActions.Location = new Point(240, 185);
            GoToActions.Name = "GoToActions";
            GoToActions.Size = new Size(92, 68);
            GoToActions.TabIndex = 7;
            GoToActions.Text = "Go Back";
            GoToActions.UseVisualStyleBackColor = true;
            GoToActions.Click += GoToActions_Click;
            // 
            // ExchangeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 265);
            Controls.Add(GoToActions);
            Controls.Add(ConvertResultLabel);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExchangeForm";
            Text = "ExchangeForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox NominalOpt;
        private Button ConvertButton;
        private GroupBox groupBox1;
        private Label ConvertResultLabel;
        private Button GoToActions;
        private TextBox ConvertingMoney;
    }
}