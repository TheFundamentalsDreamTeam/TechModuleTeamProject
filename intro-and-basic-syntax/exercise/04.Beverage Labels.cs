//CONFIRMED from valeria_g
using System;

namespace _04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
			//READ A PRODUCT NAME...
            var productName = Console.ReadLine(); 	//Read product name from Console.
            int productVolume = int.Parse(Console.ReadLine());		//Read volume of product by “Mililiters” form Console.
            var energyOfProduct = int.Parse(Console.ReadLine());		//Read energy of product by “Kcal” from Console.
            var sugarContentOfProduct = int.Parse(Console.ReadLine());	//Read sugar of product by “Grams” from Console.

			//CALCULATIONS...
            var kaloriesInKCal = productVolume * energyOfProduct / 100.0;		//Calculate “kalories” of product by “Kcal” (energy content per 100ml).
            var sugarInProduct = productVolume * sugarContentOfProduct / 100.0;	//Calculate “sugars” of product by “Grams”. (sugar content per 100ml).
			
			//PRINT ON CONSOLE RESULT OF CALCULATIONS...
            Console.WriteLine($"{productVolume}ml {productName}:");	//Print volume of product by “Mililiters” and name of product.
            Console.WriteLine($"{kaloriesInKCal}kcal, {sugarInProduct}g sugars");	//Print kalories of product by “Kcal” and sugar of product by “Grams”.
        }
    }
}
