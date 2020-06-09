    using System;
using System.Collections.Generic;

namespace LAB4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter number :");
            int b = int.Parse(Console.ReadLine());
            Meteorological[] arr = new Meteorological[b];

            double d;
            double d1;
            string month; 
            double airtemperature;  
            double airtempreture1;
            for(int i=0;i<b;i++)
            {
                Console.WriteLine("Enter Month");
                month = Console.ReadLine();
                Console.WriteLine("Enter 2 days for each month");
                d = double.Parse(Console.ReadLine());
                d1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter airtempetature for 2 days in month ");
                airtemperature = double.Parse(Console.ReadLine());
                airtempreture1 = double.Parse(Console.ReadLine());

                arr[i] = new Meteorological(month, d, d1, airtemperature, airtempreture1);


            }
            for(int i =0; i<b; i++)
            {
                arr[i].printResult();
            }


        }
      
    }
}
