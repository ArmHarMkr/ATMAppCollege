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
            this.NominalOpt = new System.Windows.Forms.ComboBox();
            this.ConvertingMoney = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToNominalOpt = new System.Windows.Forms.ComboBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConvertResultLabel = new System.Windows.Forms.Label();
            this.GoToActions = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NominalOpt
            // 
            this.NominalOpt.FormattingEnabled = true;
            this.NominalOpt.Items.AddRange(new object[] {
            "AMD",
            "Dollar"});
            this.NominalOpt.Location = new System.Drawing.Point(6, 21);
            this.NominalOpt.Name = "NominalOpt";
            this.NominalOpt.Size = new System.Drawing.Size(156, 23);
            this.NominalOpt.TabIndex = 0;
            // 
            // ConvertingMoney
            // 
            this.ConvertingMoney.Location = new System.Drawing.Point(6, 51);
            this.ConvertingMoney.Mask = "000000";
            this.ConvertingMoney.Name = "ConvertingMoney";
            this.ConvertingMoney.Size = new System.Drawing.Size(156, 23);
            this.ConvertingMoney.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TO: ";
            // 
            // ToNominalOpt
            // 
            this.ToNominalOpt.FormattingEnabled = true;
            this.ToNominalOpt.Items.AddRange(new object[] {
            "Dollar",
            "AMD"});
            this.ToNominalOpt.Location = new System.Drawing.Point(6, 121);
            this.ToNominalOpt.Name = "ToNominalOpt";
            this.ToNominalOpt.Size = new System.Drawing.Size(156, 23);
            this.ToNominalOpt.TabIndex = 3;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(6, 173);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(156, 69);
            this.ConvertButton.TabIndex = 4;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NominalOpt);
            this.groupBox1.Controls.Add(this.ConvertButton);
            this.groupBox1.Controls.Add(this.ConvertingMoney);
            this.groupBox1.Controls.Add(this.ToNominalOpt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finances input";
            // 
            // ConvertResultLabel
            // 
            this.ConvertResultLabel.AutoSize = true;
            this.ConvertResultLabel.Location = new System.Drawing.Point(240, 108);
            this.ConvertResultLabel.Name = "ConvertResultLabel";
            this.ConvertResultLabel.Size = new System.Drawing.Size(80, 15);
            this.ConvertResultLabel.TabIndex = 6;
            this.ConvertResultLabel.Text = "Convert place";
            // 
            // GoToActions
            // 
            this.GoToActions.Location = new System.Drawing.Point(240, 185);
            this.GoToActions.Name = "GoToActions";
            this.GoToActions.Size = new System.Drawing.Size(92, 68);
            this.GoToActions.TabIndex = 7;
            this.GoToActions.Text = "Go Back";
            this.GoToActions.UseVisualStyleBackColor = true;
            this.GoToActions.Click += new System.EventHandler(this.GoToActions_Click);
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 265);
            this.Controls.Add(this.GoToActions);
            this.Controls.Add(this.ConvertResultLabel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox NominalOpt;
        private MaskedTextBox ConvertingMoney;
        private Label label1;
        private ComboBox ToNominalOpt;
        private Button ConvertButton;
        private GroupBox groupBox1;
        private Label ConvertResultLabel;
        private Button GoToActions;
    }
}