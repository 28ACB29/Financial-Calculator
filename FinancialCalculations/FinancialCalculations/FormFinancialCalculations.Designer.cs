namespace FinancialCalculations
{
	partial class FormFinancialCalculations
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
			this.tabControlFinancialCalculations = new System.Windows.Forms.TabControl();
			this.tabPageDepreciation = new System.Windows.Forms.TabPage();
			this.labelSYDDepreciation = new System.Windows.Forms.Label();
			this.listBoxDepreciation = new System.Windows.Forms.ListBox();
			this.comboBoxLife = new System.Windows.Forms.ComboBox();
			this.textBoxFinalValue = new System.Windows.Forms.TextBox();
			this.textBoxInitialCost = new System.Windows.Forms.TextBox();
			this.labelLifeOfAssetInYears = new System.Windows.Forms.Label();
			this.labelFinalValueOfAsset = new System.Windows.Forms.Label();
			this.labelInitialCostOfAsset = new System.Windows.Forms.Label();
			this.tabPageFutureValue = new System.Windows.Forms.TabPage();
			this.textBoxFutureValue = new System.Windows.Forms.TextBox();
			this.textBoxYears = new System.Windows.Forms.TextBox();
			this.textBoxInterestRate = new System.Windows.Forms.TextBox();
			this.textBoxMonthlyInvestment = new System.Windows.Forms.TextBox();
			this.labelFutureValue = new System.Windows.Forms.Label();
			this.labelNumberOfYears = new System.Windows.Forms.Label();
			this.labelYearlyInterestRate = new System.Windows.Forms.Label();
			this.labelMonthlyInvestment = new System.Windows.Forms.Label();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.tabControlFinancialCalculations.SuspendLayout();
			this.tabPageDepreciation.SuspendLayout();
			this.tabPageFutureValue.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlFinancialCalculations
			// 
			this.tabControlFinancialCalculations.Controls.Add(this.tabPageDepreciation);
			this.tabControlFinancialCalculations.Controls.Add(this.tabPageFutureValue);
			this.tabControlFinancialCalculations.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControlFinancialCalculations.Location = new System.Drawing.Point(0, 0);
			this.tabControlFinancialCalculations.Margin = new System.Windows.Forms.Padding(8);
			this.tabControlFinancialCalculations.Name = "tabControlFinancialCalculations";
			this.tabControlFinancialCalculations.SelectedIndex = 0;
			this.tabControlFinancialCalculations.Size = new System.Drawing.Size(288, 226);
			this.tabControlFinancialCalculations.TabIndex = 0;
			// 
			// tabPageDepreciation
			// 
			this.tabPageDepreciation.Controls.Add(this.labelSYDDepreciation);
			this.tabPageDepreciation.Controls.Add(this.listBoxDepreciation);
			this.tabPageDepreciation.Controls.Add(this.comboBoxLife);
			this.tabPageDepreciation.Controls.Add(this.textBoxFinalValue);
			this.tabPageDepreciation.Controls.Add(this.textBoxInitialCost);
			this.tabPageDepreciation.Controls.Add(this.labelLifeOfAssetInYears);
			this.tabPageDepreciation.Controls.Add(this.labelFinalValueOfAsset);
			this.tabPageDepreciation.Controls.Add(this.labelInitialCostOfAsset);
			this.tabPageDepreciation.Location = new System.Drawing.Point(4, 22);
			this.tabPageDepreciation.Name = "tabPageDepreciation";
			this.tabPageDepreciation.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDepreciation.Size = new System.Drawing.Size(280, 200);
			this.tabPageDepreciation.TabIndex = 0;
			this.tabPageDepreciation.Text = "Depreciation";
			this.tabPageDepreciation.UseVisualStyleBackColor = true;
			// 
			// labelSYDDepreciation
			// 
			this.labelSYDDepreciation.Location = new System.Drawing.Point(40, 96);
			this.labelSYDDepreciation.Name = "labelSYDDepreciation";
			this.labelSYDDepreciation.Size = new System.Drawing.Size(120, 24);
			this.labelSYDDepreciation.TabIndex = 25;
			this.labelSYDDepreciation.Text = "SYD Depreciation:";
			// 
			// listBoxDepreciation
			// 
			this.listBoxDepreciation.FormattingEnabled = true;
			this.listBoxDepreciation.Location = new System.Drawing.Point(40, 120);
			this.listBoxDepreciation.Name = "listBoxDepreciation";
			this.listBoxDepreciation.Size = new System.Drawing.Size(208, 69);
			this.listBoxDepreciation.TabIndex = 24;
			this.listBoxDepreciation.TabStop = false;
			// 
			// comboBoxLife
			// 
			this.comboBoxLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLife.FormattingEnabled = true;
			this.comboBoxLife.Location = new System.Drawing.Point(160, 72);
			this.comboBoxLife.Name = "comboBoxLife";
			this.comboBoxLife.Size = new System.Drawing.Size(88, 21);
			this.comboBoxLife.TabIndex = 23;
			this.comboBoxLife.Tag = "Life";
			// 
			// textBoxFinalValue
			// 
			this.textBoxFinalValue.Location = new System.Drawing.Point(160, 40);
			this.textBoxFinalValue.Name = "textBoxFinalValue";
			this.textBoxFinalValue.Size = new System.Drawing.Size(88, 20);
			this.textBoxFinalValue.TabIndex = 20;
			this.textBoxFinalValue.Tag = "Final Value";
			this.textBoxFinalValue.Text = "100";
			// 
			// textBoxInitialCost
			// 
			this.textBoxInitialCost.Location = new System.Drawing.Point(160, 16);
			this.textBoxInitialCost.Name = "textBoxInitialCost";
			this.textBoxInitialCost.Size = new System.Drawing.Size(88, 20);
			this.textBoxInitialCost.TabIndex = 18;
			this.textBoxInitialCost.Tag = "Initial Cost";
			this.textBoxInitialCost.Text = "500";
			// 
			// labelLifeOfAssetInYears
			// 
			this.labelLifeOfAssetInYears.Location = new System.Drawing.Point(40, 64);
			this.labelLifeOfAssetInYears.Name = "labelLifeOfAssetInYears";
			this.labelLifeOfAssetInYears.Size = new System.Drawing.Size(112, 24);
			this.labelLifeOfAssetInYears.TabIndex = 22;
			this.labelLifeOfAssetInYears.Text = "Life of Asset in Years:";
			this.labelLifeOfAssetInYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelFinalValueOfAsset
			// 
			this.labelFinalValueOfAsset.Location = new System.Drawing.Point(40, 40);
			this.labelFinalValueOfAsset.Name = "labelFinalValueOfAsset";
			this.labelFinalValueOfAsset.Size = new System.Drawing.Size(112, 24);
			this.labelFinalValueOfAsset.TabIndex = 21;
			this.labelFinalValueOfAsset.Text = "Final Value of Asset:";
			this.labelFinalValueOfAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelInitialCostOfAsset
			// 
			this.labelInitialCostOfAsset.Location = new System.Drawing.Point(40, 16);
			this.labelInitialCostOfAsset.Name = "labelInitialCostOfAsset";
			this.labelInitialCostOfAsset.Size = new System.Drawing.Size(112, 24);
			this.labelInitialCostOfAsset.TabIndex = 19;
			this.labelInitialCostOfAsset.Text = "Initial Cost of Asset:";
			this.labelInitialCostOfAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tabPageFutureValue
			// 
			this.tabPageFutureValue.Controls.Add(this.textBoxFutureValue);
			this.tabPageFutureValue.Controls.Add(this.textBoxYears);
			this.tabPageFutureValue.Controls.Add(this.textBoxInterestRate);
			this.tabPageFutureValue.Controls.Add(this.textBoxMonthlyInvestment);
			this.tabPageFutureValue.Controls.Add(this.labelFutureValue);
			this.tabPageFutureValue.Controls.Add(this.labelNumberOfYears);
			this.tabPageFutureValue.Controls.Add(this.labelYearlyInterestRate);
			this.tabPageFutureValue.Controls.Add(this.labelMonthlyInvestment);
			this.tabPageFutureValue.Location = new System.Drawing.Point(4, 22);
			this.tabPageFutureValue.Name = "tabPageFutureValue";
			this.tabPageFutureValue.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFutureValue.Size = new System.Drawing.Size(280, 200);
			this.tabPageFutureValue.TabIndex = 1;
			this.tabPageFutureValue.Text = "Future Value";
			this.tabPageFutureValue.UseVisualStyleBackColor = true;
			// 
			// textBoxFutureValue
			// 
			this.textBoxFutureValue.Location = new System.Drawing.Point(160, 128);
			this.textBoxFutureValue.Name = "textBoxFutureValue";
			this.textBoxFutureValue.ReadOnly = true;
			this.textBoxFutureValue.Size = new System.Drawing.Size(84, 20);
			this.textBoxFutureValue.TabIndex = 38;
			this.textBoxFutureValue.TabStop = false;
			// 
			// textBoxYears
			// 
			this.textBoxYears.Location = new System.Drawing.Point(160, 104);
			this.textBoxYears.Name = "textBoxYears";
			this.textBoxYears.Size = new System.Drawing.Size(84, 20);
			this.textBoxYears.TabIndex = 37;
			this.textBoxYears.Text = "3";
			// 
			// textBoxInterestRate
			// 
			this.textBoxInterestRate.Location = new System.Drawing.Point(160, 72);
			this.textBoxInterestRate.Name = "textBoxInterestRate";
			this.textBoxInterestRate.Size = new System.Drawing.Size(84, 20);
			this.textBoxInterestRate.TabIndex = 36;
			this.textBoxInterestRate.Text = "3";
			// 
			// textBoxMonthlyInvestment
			// 
			this.textBoxMonthlyInvestment.Location = new System.Drawing.Point(160, 48);
			this.textBoxMonthlyInvestment.Name = "textBoxMonthlyInvestment";
			this.textBoxMonthlyInvestment.Size = new System.Drawing.Size(84, 20);
			this.textBoxMonthlyInvestment.TabIndex = 35;
			this.textBoxMonthlyInvestment.Tag = "";
			this.textBoxMonthlyInvestment.Text = "100";
			// 
			// labelFutureValue
			// 
			this.labelFutureValue.Location = new System.Drawing.Point(40, 128);
			this.labelFutureValue.Name = "labelFutureValue";
			this.labelFutureValue.Size = new System.Drawing.Size(114, 20);
			this.labelFutureValue.TabIndex = 34;
			this.labelFutureValue.Text = "Future Value:";
			this.labelFutureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelNumberOfYears
			// 
			this.labelNumberOfYears.Location = new System.Drawing.Point(40, 104);
			this.labelNumberOfYears.Name = "labelNumberOfYears";
			this.labelNumberOfYears.Size = new System.Drawing.Size(112, 24);
			this.labelNumberOfYears.TabIndex = 33;
			this.labelNumberOfYears.Text = "Number of Years:";
			this.labelNumberOfYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelYearlyInterestRate
			// 
			this.labelYearlyInterestRate.Location = new System.Drawing.Point(40, 72);
			this.labelYearlyInterestRate.Name = "labelYearlyInterestRate";
			this.labelYearlyInterestRate.Size = new System.Drawing.Size(112, 24);
			this.labelYearlyInterestRate.TabIndex = 32;
			this.labelYearlyInterestRate.Text = "Yearly Interest Rate:";
			this.labelYearlyInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelMonthlyInvestment
			// 
			this.labelMonthlyInvestment.Location = new System.Drawing.Point(40, 48);
			this.labelMonthlyInvestment.Name = "labelMonthlyInvestment";
			this.labelMonthlyInvestment.Size = new System.Drawing.Size(112, 24);
			this.labelMonthlyInvestment.TabIndex = 31;
			this.labelMonthlyInvestment.Text = "Monthly Investment:";
			this.labelMonthlyInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonCalculate.Location = new System.Drawing.Point(0, 226);
			this.buttonCalculate.Margin = new System.Windows.Forms.Padding(8);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(288, 40);
			this.buttonCalculate.TabIndex = 1;
			this.buttonCalculate.Text = "Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
			this.buttonExit.Location = new System.Drawing.Point(216, 226);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(8);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(72, 40);
			this.buttonExit.TabIndex = 2;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Dock = System.Windows.Forms.DockStyle.Left;
			this.buttonClear.Location = new System.Drawing.Point(0, 226);
			this.buttonClear.Margin = new System.Windows.Forms.Padding(8);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(72, 40);
			this.buttonClear.TabIndex = 3;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// FormFinancialCalculations
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 266);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.tabControlFinancialCalculations);
			this.Name = "FormFinancialCalculations";
			this.Text = "Financial Calculations";
			this.Load += new System.EventHandler(this.FormFinancialCalculations_Load);
			this.tabControlFinancialCalculations.ResumeLayout(false);
			this.tabPageDepreciation.ResumeLayout(false);
			this.tabPageDepreciation.PerformLayout();
			this.tabPageFutureValue.ResumeLayout(false);
			this.tabPageFutureValue.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlFinancialCalculations;
		private System.Windows.Forms.TabPage tabPageDepreciation;
		private System.Windows.Forms.TabPage tabPageFutureValue;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelSYDDepreciation;
		private System.Windows.Forms.ListBox listBoxDepreciation;
		private System.Windows.Forms.ComboBox comboBoxLife;
		private System.Windows.Forms.TextBox textBoxFinalValue;
		private System.Windows.Forms.TextBox textBoxInitialCost;
		private System.Windows.Forms.Label labelLifeOfAssetInYears;
		private System.Windows.Forms.Label labelFinalValueOfAsset;
		private System.Windows.Forms.Label labelInitialCostOfAsset;
		private System.Windows.Forms.TextBox textBoxFutureValue;
		private System.Windows.Forms.TextBox textBoxYears;
		private System.Windows.Forms.TextBox textBoxInterestRate;
		private System.Windows.Forms.TextBox textBoxMonthlyInvestment;
		private System.Windows.Forms.Label labelFutureValue;
		private System.Windows.Forms.Label labelYearlyInterestRate;
		private System.Windows.Forms.Label labelMonthlyInvestment;
		private System.Windows.Forms.Label labelNumberOfYears;
		private System.Windows.Forms.Button buttonClear;
	}
}

