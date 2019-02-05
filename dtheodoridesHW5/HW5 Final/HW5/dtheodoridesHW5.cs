using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{ // Dimitris Theodorides
    //HW 5
    public partial class dtheodoridesHW5 : Form
    {
        public dtheodoridesHW5()
        {
            InitializeComponent();
        }
        

        private void btnStraightLineMethod_Click(object sender, EventArgs e)
        {  // Declaring variables
            try
            {
                string itemDescription = txtDescriptionOfItem.Text;
                double yearOfPurchase = double.Parse(txtYearOfPurchase.Text);
                double costOfItems = double.Parse(txtCostOfItem.Text);
                double numberOfYearsToBeDepreciated = double.Parse(txtNumberOfYearsToBeDepreciated.Text);
                double depreciationAmount;
                double accumulatedDepreciation = 0;

                //Dsplaying in listBox

                int year = 0;
                string formatCode = "{0,7}{1,22}{2,28}{3,15}";
                lstDisplay.Items.Clear();
                lstDisplay.Items.Add(string.Format(formatCode, "Year Of Purchase", "Depreciation Amount", "Accumulated Depreciation", "Current Value"));

                // Using while loop to calculate

                while (year < numberOfYearsToBeDepreciated)
                {

                    depreciationAmount = 1 / numberOfYearsToBeDepreciated;
                    depreciationAmount = depreciationAmount * costOfItems;
                    yearOfPurchase = yearOfPurchase + 1;
                    accumulatedDepreciation = accumulatedDepreciation + depreciationAmount;
                    double currentPriceOfItem = costOfItems - accumulatedDepreciation;
                   

                    lstDisplay.Items.Add(string.Format(formatCode, yearOfPurchase.ToString(), Math.Round(depreciationAmount, 2)
                        , Math.Round(accumulatedDepreciation, 2), Math.Round(currentPriceOfItem, 2)));
                    

                    year++;
                }
            }catch  (Exception)
            {
                MessageBox.Show("Please enter a valid value");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        { // Closes Application
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescriptionOfItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        { // Clears textboxes and listBox

            txtCostOfItem.Clear();
            txtDepreciationRate.Clear();
            txtDescriptionOfItem.Clear();
            txtNumberOfYearsToBeDepreciated.Clear();
            txtYearOfPurchase.Clear();
            lstDisplay.Items.Clear();
           
        }

        private void btnDecliningBalanceMethod_Click(object sender, EventArgs e)
        { // Declaring variable
            try
            {

            string itemDescription = txtDescriptionOfItem.Text;
            double yearOfPurchase = double.Parse(txtYearOfPurchase.Text);
            double costOfItems = double.Parse(txtCostOfItem.Text);
            double numberOfYearsToBeDepreciated = double.Parse(txtNumberOfYearsToBeDepreciated.Text);
            double deprecitiationRate = double.Parse(txtDepreciationRate.Text);
            double depreciationAmount;
            double accumulatedDepreciation = 0;

            
                //Displaying in listBox
                int year = 0;
                string formatCode = "{0,7}{1,22}{2,28}{3,15}";

                lstDisplay.Items.Clear();
                lstDisplay.Items.Add(string.Format(formatCode, "Year Of Purchase", "Depreciation Amount", "Accumulated Depreciation", "Current Value"));

                //Using while loop to calculate

                while ((costOfItems > 0.005) && (!(year >= numberOfYearsToBeDepreciated)))
                {
                    depreciationAmount = 1 / deprecitiationRate;
                    depreciationAmount = depreciationAmount * costOfItems;
                    yearOfPurchase = yearOfPurchase + 1;
                    accumulatedDepreciation = accumulatedDepreciation + depreciationAmount;
                    costOfItems = costOfItems - depreciationAmount;
                    lstDisplay.Items.Add(string.Format(formatCode, yearOfPurchase.ToString(), Math.Round(depreciationAmount, 2)
                    , Math.Round(accumulatedDepreciation, 2), Math.Round(costOfItems, 2)));
                    year++;

                } // try catch method
            }catch (Exception)
                  {
                MessageBox.Show("Please enter valid value");       
                  }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

