//CONFIRMED from stefoeli

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers
{
    class MilesToKilometers
    {
        static void Main(string[] args)
        {	 //We recieve from Console
		   //mile values in floating format
            double miles = double.Parse(Console.ReadLine());

		 //In this line we calculate how kilometers
		   //corresponds to miles from above line
            double kmSum = miles * 1.60934;

		//Finally we print the result next to second
		  //floating point.
            Console.WriteLine($"{kmSum:f2}");
        }
    }
}