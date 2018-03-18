using System;

namespace _04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
			//READ A PRODUCT NAME...
            var name = Console.ReadLine(); 	//Read product name from Console.
            int productVolume = int.Parse(Console.ReadLine());		//Read volume of product by “Mililiters” form Console.
            var energy = int.Parse(Console.ReadLine());		//Read energy of product by “Kcal” from Console.
            var sugarContent = int.Parse(Console.ReadLine());	//Read sugar of product by “Grams” from Console.

			//CALCULATIONS...
            var kalories = volume * energy / 100.0;		//Calculate “kalories” of product by “Kcal” (energy content per 100ml).
            var sugar = volume * sugarContent / 100.0;	//Calculate “sugars” of product by “Grams”. (sugar content per 100ml).
			
			//PRINT ON CONSOLE RESULT OF CALCULATIONS...
            Console.WriteLine($"{volume}ml {name}:");	//Print volume of product by “Mililiters” and name of product.
            Console.WriteLine($"{kalories}kcal, {sugar}g sugars");	//Print kalories of product by “Kcal” and sugar of product by “Grams”.
        }
    }
}
