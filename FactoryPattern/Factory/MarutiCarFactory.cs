using FactoryPattern.Concrete;
using System;

namespace FactoryPattern.Factory
{
    public class MarutiCarFactory : CarFactory
    {
        public override Car CreatCarInstance(Enum CarModel)
        {
            switch (CarModel.ToString())
            {
                case "MarutiEightHundred": return new MarutiEightHundred();
                case "MarutiSwift": return new MarutiSwift();
                default: throw new ArgumentException("Invalid model", CarModel.ToString());

            }
        }
    }
}
