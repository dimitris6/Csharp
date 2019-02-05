using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.IO;



namespace SynecticsLtd
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] delimeter = new string[] { "##" };
            string[] synectlines = System.IO.File.ReadAllLines(@" C:\Users\DimitrisTh\Desktop\devdata.txt");

            int count = 0;
            List<Double> rawinput = new List<double>();
            foreach (string line in synectlines)
            {
                string[] numbers = line.Split(delimeter, StringSplitOptions.RemoveEmptyEntries);
                if (numbers[0].Contains("2000"))
                {
                    count++;
                    rawinput.Add(Double.Parse(numbers[1]));
                }
            }

            Console.WriteLine("Total number of entries found for the year 2000 is " + count);


            double totalElements = count;
            Program p = new Program();

            double mean = p.Mean(rawinput, totalElements);

            Console.WriteLine("Mean::" + mean);

    

            double Variance = p.Variance(rawinput, totalElements, mean);

            Console.WriteLine("Variance::" + Variance);




            double stdDeviation = StandardDeviation(Variance);

            Console.WriteLine("Standard Deviation :::" + stdDeviation);
            Console.ReadLine();
        }

        private static double StandardDeviation(double Variance)
        {
            //Standard Deviation

            return Math.Sqrt(Variance);
           
        }

        public double Variance(List<double> rawinput, double totalElements,double meanValue)
        {
            //Variance

            double tVariance1 = 0.0d;
            double tVariance2 = 0.0d;
            foreach (double varSingle in rawinput)
            {
                double tVariance0 = varSingle - meanValue;
                tVariance1 = tVariance0 * tVariance0;
                tVariance2 += tVariance1;
            }
            double Variance = tVariance2 / totalElements;
            return Variance;
        }

        public double Mean(List<Double> rawinput,double totalElements) {
            //Mean

            double TSum = 0;

            foreach (double varSingle in rawinput)
            {
                TSum += varSingle;
            }
            Console.WriteLine("Sum of all values :::" + TSum);

            double meanValue = TSum / totalElements;

            return meanValue;

        }

    }
    
}

