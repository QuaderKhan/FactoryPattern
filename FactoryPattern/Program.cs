using FactoryPattern.Factory;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Factory class with reference of the concrete factory class from which you need an object
            CarFactory maruti = new MarutiCarFactory(); 
            Car Maruti800 = maruti.CreatCarInstance(CarModel.MarutiEightHundred);
            Console.WriteLine(Maruti800.GetType());
            Console.ReadKey();
        }
    }
}
