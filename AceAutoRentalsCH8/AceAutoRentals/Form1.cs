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
namespace AceAutoRentals
{
    public partial class aceAutoRentals : Form
    {
        public aceAutoRentals()
        {
            InitializeComponent();
        }

        string[] autoTypes = new string[100];
        string[] dailyRates = new string[100];
        int counter = 0;
             
     private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime startOfRental;
                DateTime dateReturned;

                decimal chargePerDay;
                //decimal daysRented;
                decimal daysRented;
                //float daysRented;
                decimal totalRentalCost;


                chargePerDay = Convert.ToDecimal(txtChargePerDay.Text);

                startOfRental = dtpStartOfRental.Value;

                dateReturned = dtpDateReturned.Value;


                /* int returntime=dateReturned.TimeOfDay.Hours;
                int rentedtime = 24-startOfRental.TimeOfDay.Hours;
                int timecalc = rentedtime + returntime;
                double timedaycalc = 0;
                if (timecalc == 24) { timedaycalc = 1; }else if(timecalc<24) { timedaycalc = 24 % timecalc; } else { timedaycalc = timecalc % 24; }
                */
                int returnday = dateReturned.DayOfYear;
                int rentedday = startOfRental.DayOfYear;
                int totalDays = returnday - rentedday;

                daysRented = totalDays + 1;//dateReturned.Date.Day + startOfRental.Date.Day ;

                // daysRented = dateReturned <= startOfRental ? 0: Convert.ToDecimal(( dateReturned.Date - startOfRental.Date ));



                totalRentalCost = Convert.ToDecimal(daysRented) * Convert.ToDecimal(chargePerDay);


                lstDisplay.Items.Add(string.Format("{0,12}{1,10:C}", "Total Rental Cost:", totalRentalCost));








            }
            catch { 
           
                MessageBox.Show("Invalid Value");
            }




        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceAutoRentals_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader autoTypesReader = new StreamReader("AutoTypes.txt");

                while (autoTypesReader.EndOfStream == false)
                {
                    comAutoTypes.Items.Add(autoTypesReader.ReadLine());
                }

                autoTypesReader.Close();


                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             }




        }

        private void btnFileToArray_Click(object sender, EventArgs e)
        {
            string currentLine;
           

            StreamReader VehichleReader = new StreamReader("AutoTypes.txt");

            while (VehichleReader.EndOfStream == false)
            {
                string[] fields;
                currentLine = VehichleReader.ReadLine();
                fields= currentLine.Split(',');
                autoTypes[counter] = fields[0];
                dailyRates[counter] = fields[1];
                counter++;

            }

            VehichleReader.Close();

            lstDisplay.Items.Clear();

            lstDisplay.Items.Add("---Split textfile entries into two arrays---");

            for (int i = 0; i < counter; i++)
            {
                lstDisplay.Items.Add("Types of vehicles:   " + autoTypes[i] + "   " + "Daily rates: " + dailyRates[i]);
            }

           
            





        }
    }
}
