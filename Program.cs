using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monthly_Sales_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June",
                           "July", "August", "September", "October", "November", "December" };

            float[] sales = new float[12];
            float totalSales = 0f;
            int highestMonthIndex = 0;
            int lowestMonthIndex = 0;

            Console.WriteLine("Enter monthly sales for the year:");

            for (int i = 0; i < sales.Length; i++)
            {
                Console.Write($"{months[i]}: ");
                while (!float.TryParse(Console.ReadLine(), out sales[i]) || sales[i] < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    Console.Write($"{months[i]}: ");
                }
                totalSales += sales[i];
            }
            for (int i = 1; i < sales.Length; i++)
            {
                if (sales[i] > sales[highestMonthIndex])
                    highestMonthIndex = i;

                if (sales[i] < sales[lowestMonthIndex])
                    lowestMonthIndex = i;
            }
            
            float average = totalSales / sales.Length;

            Console.WriteLine("\nSales Analysis Results:");
            Console.WriteLine($"Highest Sales: {months[highestMonthIndex]} (${sales[highestMonthIndex]})");
            Console.WriteLine($"Lowest Sales: {months[lowestMonthIndex]} (${sales[lowestMonthIndex]})");
            Console.WriteLine($"Average Sales: ${average:F2}");

        }
    }
}
