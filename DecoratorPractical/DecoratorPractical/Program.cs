using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorBeverageExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage1 = new Coffee(); // Creating a Coffee beverage with milk and 1 sugar
            beverage1 = new Milk(beverage1);
            beverage1 = new Sugar(beverage1);
            Console.WriteLine(beverage1.GetDescription()); // Printing the description of the beverage


            Beverage beverage2 = new Tea();// Creating a Tea beverage with lemon
            beverage2 = new Lemon(beverage2);
            Console.WriteLine(beverage2.GetDescription()); // Printing the description of the beverage


            Beverage beverage3 = new Hotchocololate(); // Creating a Hot chocololate beverage with 3 Marshmallows
            beverage3 = new Marshmallow(beverage3);
            beverage3 = new Marshmallow(beverage3);
            beverage3 = new Marshmallow(beverage3);
            Console.WriteLine(beverage3.GetDescription()); // Printing the description of the beverage

            Beverage beverage4 = new BlackCoffee(); // Creating a Black Coffee beverage with no milk and 1 sweetner
            beverage4 = new Sweetner(beverage4);
            Console.WriteLine(beverage4.GetDescription()); // Printing the description of the beverage

            Beverage beverage5 = new Hotchocololate(); // Creating a Hot chocololate beverage with 1 Sugar
            beverage5 = new Sugar(beverage5);
            Console.ReadLine();
        }
    }
}