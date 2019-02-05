using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dtheodoridesHW7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] customerNames = new string[100]; //array to store customer names
        string[] boughtSoftware = new string[100];  //array to store software bought
        int counter = 0; //keeps track of number of software stored in the above arrays 
        decimal totalSoftware = 0; //total sales amount of software

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Reads Software App names from file and display in the combobox

                StreamReader applicationReader = new StreamReader("Software.txt");

                while (applicationReader.EndOfStream == false)
                {
                    cboNamesOfSoftwareApplications.Items.Add(applicationReader.ReadLine());
                }

                applicationReader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculateCharge_Click(object sender, EventArgs e)
        {
            const decimal payrollManagement = 2000;
            const decimal projectManagement = 800;
            const decimal virtualTeam = 4500;
            const decimal appointmentsManager = 1000;

            decimal maintenancePackage = 1000;
            
            decimal charge = 0;

            decimal totalFee = 0;
            try
            {
                string customerName = txtCustomerName.Text;

                decimal numberOfLicencesToBePurchased = Convert.ToDecimal(txtNumberOfLicenses.Text);

                string NamesOfSoftwareApplication = cboNamesOfSoftwareApplications.SelectedItem.ToString();

                lstDisplay.Items.Clear();



                if (txtCustomerName.Text.Length == 0)
                {
                    erpError.SetError(txtCustomerName, "Enter customer name");
                    txtCustomerName.Focus();
                    txtCustomerName.SelectAll();
                }
                else
                {

                    if (decimal.TryParse(txtNumberOfLicenses.Text, out numberOfLicencesToBePurchased) == false)
                    {
                        erpError.SetError(txtNumberOfLicenses, "Enter number of licenses to be purchased!");
                        txtNumberOfLicenses.Focus();
                        txtNumberOfLicenses.SelectAll();
                    }

                    else
                    {


                        //Determine charge based on software selection

                        if (NamesOfSoftwareApplication == "Payroll Management")
                            charge = payrollManagement * numberOfLicencesToBePurchased;
                        else if (NamesOfSoftwareApplication == "Project Management")
                            charge = projectManagement * numberOfLicencesToBePurchased;
                        else if (NamesOfSoftwareApplication == "VirtualTeam")
                            charge = virtualTeam * numberOfLicencesToBePurchased;
                        else if (NamesOfSoftwareApplication == "Appointments Manager")
                            charge = appointmentsManager * numberOfLicencesToBePurchased;

                        //Add maintenance package charge
                        if (rdbAddMaintenancePackage.Checked == true)
                            totalFee = charge + maintenancePackage;
                        else if (rdbDeclinedMaintenancePackage.Checked == true)
                            maintenancePackage = 0;

                        //Calculate totalFee
                        totalFee = charge + maintenancePackage;

                        //Display 

                        lstDisplay.Items.Add("Customer Invoice");
                        lstDisplay.Items.Add("Customer Name: " + customerName);
                        lstDisplay.Items.Add("Charge: " + charge.ToString("C"));
                        lstDisplay.Items.Add("Maintenance package fee " + maintenancePackage.ToString("C"));
                        lstDisplay.Items.Add("Total charge " + totalFee.ToString("C"));

                        //Save data to Sales.txt file

                        StreamWriter salesWriter = new StreamWriter("Sales.txt", true);

                        salesWriter.WriteLine(customerName + "," + NamesOfSoftwareApplication + "," + totalFee);

                        salesWriter.Close();

                    }
                }
            }

            catch
            {
                MessageBox.Show("An error occured! Please check your submission sheet.");
            }



        }

        private void btnDisplaySalesReport_Click(object sender, EventArgs e)
        {
            
            lstDisplay.Items.Clear();
            //Display all rentals
            lstDisplay.Items.Add("-----Sales Report-----");
            readTextFile();
            for (int i = 0; i < counter; i++)
            {
                lstDisplay.Items.Add("Customer: " + customerNames[i] + "; Software Purchased: " + boughtSoftware[i]);
            }

            lstDisplay.Items.Add("All customer sales: " + totalSoftware);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtNumberOfLicenses.Clear();
            lstDisplay.Items.Clear();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            int result = 0;
          
            try
            {
                string[] fields = new string[3];

                lstDisplay.Items.Clear();

                readTextFile();

                for (int i = 0; i < customerNames.Length; i++)
                {
                    if (txtCustomerName.Text.Trim().Equals(customerNames[i]))
                    {
                        lstDisplay.Items.Add(customerNames[i] + " " + boughtSoftware[i]);
                        result++;
                    }
                }

                if (result == 0)
                {
                    MessageBox.Show("Customer not found");
                }
            }
            catch (Exception) {
                MessageBox.Show("Customer not found");

            }
            
        }

        private void readTextFile()
        {  

                string currentLine;
                string[] fields = new string[2]; // array to store items in a line
            string [] tcustomerNames = new string[100];
            string [] tboughtSoftware = new string[100];
                StreamReader customerReader = new StreamReader("Sales.txt");
                while (customerReader.EndOfStream == false)
                {
                    // Read each line, split it, and store customer name and bought software into two arrays.
                    currentLine = customerReader.ReadLine();
                    fields = currentLine.Split(',');  // split the line
                    tcustomerNames[counter] = fields[0]; //Store customer name into the array
                    tboughtSoftware[counter] = fields[1]; //Store bought software in the corresponding array
                    counter++;

                    //Total Purchases in the end 
                    totalSoftware += decimal.Parse(fields[2]);

                }
            customerNames = tcustomerNames;
            boughtSoftware = tboughtSoftware;
                customerReader.Close();
            
            
        }
    }
}

    
    

