using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlanner1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double annualAmount, targetAmount, rate;
            string retirementPlan;
            double currentInvestment = 0;
            int years = 0; 

            double.TryParse(txtAnnualAmount.Text, out annualAmount);
            double.TryParse(txtTargetAmount.Text, out targetAmount);

            // Store current user selection in the variable retirmentPlan

            retirementPlan = cmbRetirementPlan.SelectedItem.ToString();

            if(retirementPlan == "Retirement Plan 2050")
            {
                rate = 7.0;
            }

            else
            {
                rate = 6.0;
            }

            // The while loop will execute until currentInvestment is >= targetAmount

            while (currentInvestment < targetAmount)
            {
                currentInvestment = (currentInvestment + annualAmount) * (1 + rate / 100);
                years = years + 1;
            }

            txtResult.Text = years.ToString();

        }
    }
}
