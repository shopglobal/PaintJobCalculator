// Mark Evans
// Valencia College
using System;

namespace PaintJobCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants
            const double SquareFeetPerGallon = 15;
            const double HoursPerGallon = 8;
            const double LaborCostPerHour = 20.00;

            // Input: Get the square feet and price per gallon from the user
            Console.Write("Enter the square feet of wall space to be painted: ");
            double squareFeet = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the price of the paint per gallon: ");
            double pricePerGallon = Convert.ToDouble(Console.ReadLine());

            // Calculations
            double gallonsRequired = Math.Ceiling(squareFeet / SquareFeetPerGallon);
            double hoursRequired = gallonsRequired * HoursPerGallon;
            double paintCost = gallonsRequired * pricePerGallon;
            double laborCharges = hoursRequired * LaborCostPerHour;
            double totalCost = paintCost + laborCharges;

            // Output: Display the calculated data
            Console.WriteLine("\n----- Paint Job Cost Estimate -----\n");
            Console.WriteLine($"Gallons of paint required: {gallonsRequired}");
            Console.WriteLine($"Hours of labor required: {hoursRequired}");
            Console.WriteLine($"Cost of the paint: ${paintCost:F2}");
            Console.WriteLine($"Labor charges: ${laborCharges:F2}");
            Console.WriteLine($"Total cost of the paint job: ${totalCost:F2}");
        }
    }
}