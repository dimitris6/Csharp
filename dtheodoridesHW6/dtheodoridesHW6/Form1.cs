using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dtheodoridesHW6
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtYesOrNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {  //Closes the form
            this.Close();
        }

        private void btnCalculateMonthlyBill_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaring variables
                string customerName = Convert.ToString(txtCustomerName.Text);
                decimal amountOfStorageInGB = Convert.ToDecimal(txtAmountOfStorageInGB.Text);
                string yesOrno = Convert.ToString(txtYesOrNo.Text);

                //Calls CalculateStorageFee
                decimal calculateStorageFee = CalculateStorageFee(amountOfStorageInGB);

                //Calls Discount
                decimal discount = Discount(yesOrno, calculateStorageFee);

                //Calls DisplayResults
                DisplayResults(customerName, calculateStorageFee, discount);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the correct value for customer name");
            }
        }

        private decimal CalculateStorageFee(decimal amountOfStorageInGB)
        {    // Calculating charge
            
            decimal charge = 0;
            
            if (amountOfStorageInGB <= 500)
            { charge = amountOfStorageInGB * 1.50m; }
            else if (amountOfStorageInGB > 500)
            { charge =  750 + (amountOfStorageInGB * 2) - 1000  ; }

            return charge; 
        }

        private decimal Discount(string yesOrno ,decimal calculateStorageFee)
        {   //Determining if discount should be applied

            yesOrno = yesOrno.ToUpper();

            decimal discountAmount = 0;

            if (yesOrno == "YES")
            { discountAmount = (calculateStorageFee * 20) / 100; }
            else if (yesOrno == "NO")
             { discountAmount = 0; }

            return discountAmount;
        }

        private void ClearAll()
        {  // Clears listBox and textboxes
            txtAmountOfStorageInGB.Clear();
            txtCustomerName.Clear();
            txtYesOrNo.Clear();
            lstDisplay.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {  //Calling ClearAll
            ClearAll();
        }

        private void DisplayResults(string customerName , decimal calculateStorageFee , decimal discount)
        {        
            decimal totalFee = calculateStorageFee - discount;

            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(string.Format("{0,20}{1,10}", "Customer Name: ", customerName));
            lstDisplay.Items.Add(string.Format("{0,20}{1,10}", "Storage Fee ", calculateStorageFee));
            lstDisplay.Items.Add(string.Format("{0,20}{1,10}", "Discount: " , discount));            
            lstDisplay.Items.Add(string.Format("{0,20}{1,10}", "Total Fee:", totalFee));
                                                                   

        }

        private void txtAmountOfStorageInGB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmountOfStorageInGB_Validating(object sender, CancelEventArgs e)
        {
            decimal amountOfStorageInGB;

            if (decimal.TryParse(txtAmountOfStorageInGB.Text, out amountOfStorageInGB ) == false)
            {
                MessageBox.Show("Enter a correct valid value for: Amount of storage", txtAmountOfStorageInGB.Text);
                e.Cancel = true;
                return;
            }
        }

        private void txtYesOrNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtYesOrNo.Text.ToUpper() == "YES" || txtYesOrNo.Text.ToUpper() == "NO")
            {
                erpYesOrNo.SetError(txtYesOrNo, "");
            }
            else
            {
                erpYesOrNo.SetError(txtYesOrNo, "Enter a valid value: YES OR NO.");              
                return;
            }
        }

        private void txtCustomerName_Validating(object sender, CancelEventArgs e)
        {
            if (txtCustomerName.Text.Length <= 0)
            {

                erpCustomerName.SetError(txtCustomerName, "Enter a valid value for: Customer Name.");
                txtCustomerName.Focus();
                txtCustomerName.SelectAll();
                return;
            }
            else
            {
                erpCustomerName.SetError(txtCustomerName, "");
            }

        }

     }
    
    }

