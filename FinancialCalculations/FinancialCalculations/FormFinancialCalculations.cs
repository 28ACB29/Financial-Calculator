using System;
using System.Windows.Forms;

namespace FinancialCalculations
{
	public partial class FormFinancialCalculations : Form
	{
		private const int DEPRECIATION_TAB = 0;

		private const int FUTURE_VALUE_TAB = 1;
	
		public FormFinancialCalculations()
		{
			InitializeComponent();
		}

		public bool depreciationDataIsValid()
		{
			return
				// Validate the Initial Cost text box
				Validator.IsPresent(textBoxInitialCost) &&
				Validator.IsDecimal(textBoxInitialCost) &&
				Validator.IsWithinRange(textBoxInitialCost, 500, 1000000) &&

				// Validate the Final Value text box
				Validator.IsPresent(textBoxFinalValue) &&
				Validator.IsDecimal(textBoxFinalValue) &&
				Validator.IsWithinRange(textBoxFinalValue, 0, 10000000);
		}

		public bool futureValueDataIsValid()
		{
			return
				// Validate the Monthly Investment text box
				Validator.IsPresent(textBoxMonthlyInvestment) &&
				Validator.IsDecimal(textBoxMonthlyInvestment) &&
				Validator.IsWithinRange(textBoxMonthlyInvestment, 1, 1000) &&

				// Validate the Yearly Interest Rate text box
				Validator.IsPresent(textBoxInterestRate) &&
				Validator.IsDecimal(textBoxInterestRate) &&
				Validator.IsWithinRange(textBoxInterestRate, 1, 20) &&

				// Validate the Number of Years text box
				Validator.IsPresent(textBoxYears) &&
				Validator.IsInt32(textBoxYears) &&
				Validator.IsWithinRange(textBoxYears, 1, 40);
		}

		private double calculateDepreciation(double cost, double salvage, double life, double period)
		{
			double value = (cost - salvage) * (life - period + 1) * 2 / ((life) * (life + 1));
			return value;
		}

		private decimal calculateFutureValue(decimal monthlyInvestment, decimal interestRateMonthly, int months)
		{
			decimal futureValue = 0m;
			for (int i = 0; i < months; i++)
			{
				futureValue = (futureValue + monthlyInvestment) * (1 + interestRateMonthly);
			}

			return futureValue;
		}

		private void clearDepreciationEvent(object sender, EventArgs e)
		{
			textBoxInitialCost.Text = "";
			textBoxFinalValue.Text = "";
			comboBoxLife.SelectedIndex = 0;
			listBoxDepreciation.Items.Clear();
		}

		private void clearFutureValueEvent(object sender, EventArgs e)
		{
			textBoxMonthlyInvestment.Text = "";
			textBoxInterestRate.Text = "";
			textBoxYears.Text = "";
			textBoxFutureValue.Text = "";
		}

		private void calculateDepreciationEvent(object sender, EventArgs e)
		{
			try
			{
				if (this.depreciationDataIsValid())
				{
					double cost = Convert.ToDouble(textBoxInitialCost.Text);
					double salvage = Convert.ToDouble(textBoxFinalValue.Text);
					listBoxDepreciation.Items.Clear();
					int life = Convert.ToInt32(comboBoxLife.Text);
					double dLife = (double)life;

					for (int i = 1; i <= life; i++)
					{
						double period = (double)i;
						double yearlyAllowance = calculateDepreciation(cost, salvage, dLife, period);
						listBoxDepreciation.Items.Add("Year " + i + ": " + yearlyAllowance.ToString("c"));
					}
					textBoxInitialCost.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
			}
		}

		private void calculateFutureValueEvent(object sender, EventArgs e)
		{
			try
			{
				if (this.futureValueDataIsValid())
				{
					decimal monthlyInvestment = Convert.ToDecimal(textBoxMonthlyInvestment.Text);
					decimal interestRateYearly = Convert.ToDecimal(textBoxInterestRate.Text);
					int years = Convert.ToInt32(textBoxYears.Text);

					int months = years * 12;
					decimal interestRateMonthly = interestRateYearly / 12 / 100;
					decimal futureValue = calculateFutureValue(monthlyInvestment, interestRateMonthly, months);

					textBoxFutureValue.Text = futureValue.ToString("c");
					textBoxMonthlyInvestment.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
			}
		}

		private void FormFinancialCalculations_Load(object sender, EventArgs e)
		{
			// populate the Life combo box with ints from 1 to 40
			for (int i = 1; i <= 40; i++)
			{
				comboBoxLife.Items.Add(i);
			}
			comboBoxLife.SelectedIndex = 4;
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			switch (tabControlFinancialCalculations.SelectedIndex)
			{
				case FormFinancialCalculations.DEPRECIATION_TAB:
					this.clearDepreciationEvent(sender, e);
					break;
				case FormFinancialCalculations.FUTURE_VALUE_TAB:
					this.clearFutureValueEvent(sender, e);
					break;
				default:
					break;
			}
		}

		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			switch (tabControlFinancialCalculations.SelectedIndex)
			{
				case FormFinancialCalculations.DEPRECIATION_TAB:
					this.calculateDepreciationEvent(sender, e);
					break;
				case FormFinancialCalculations.FUTURE_VALUE_TAB:
					this.calculateFutureValueEvent(sender, e);
					break;
				default:
					break;
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
