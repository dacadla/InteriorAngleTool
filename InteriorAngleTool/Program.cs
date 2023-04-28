using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InteriorAngleTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Interior Angle Tool";
            Start();
        }
        static void Start()
        {
            Console.Clear();
            // Intro
            Console.WriteLine("Hello there! Welcome to my Interior Angle Tool!");
            Console.WriteLine("You can use this tool to calculate the total interior angle and the angle of the center.");
            Console.WriteLine("Please enter the number of sides of the interior polygon below:");
            try
            {
                // Create variables
                int totalinteriorangle;
                int sides;
                int angleofcenter;
                // Convert to integer
                sides = Convert.ToInt32(Console.ReadLine());
                // edge case
                if (sides < 3)
                {
                    Console.WriteLine("This polygon cannot exist.");
                    Console.WriteLine("Please try again.");
                    Console.ReadKey();
                    Start();
                }
                // Calculate values
                totalinteriorangle = (sides - 2) * 180;
                angleofcenter = 360 / sides;
                // Print them out. PLEASE IF THERE IS AN EASIER WAY TELL ME
                Console.Write("Your total interor angle is ");
                Console.Write(totalinteriorangle);
                Console.WriteLine(" degrees.");
                Console.Write("Your angle of the center is ");
                Console.Write(angleofcenter);
                Console.WriteLine(" degrees.");
                Console.WriteLine("Written by Radovan Mihalik.");
                Console.WriteLine("Press any key to use my tool again.");
                Console.ReadKey();
                Start();
            }
            catch
            {
                // If NaN
                Console.WriteLine("That was not a number.");
                Console.WriteLine("Please try again.");
                Console.ReadKey();
                Start();
            }
            
        }
    }
}
