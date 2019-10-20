using FactoryPattern.Concrete;
using System;

namespace FactoryPattern.Factory
{
    public class FordCarFactory : CarFactory
    {
        public override Car CreatCarInstance(Enum CarModel)
        {
            switch (CarModel.ToString())
            {
                case "3": return new FordFigo();
                case "4": return new FordLaura();
                default: throw new ArgumentException("Invalid model", CarModel.ToString());

            }
        }
    }
}
