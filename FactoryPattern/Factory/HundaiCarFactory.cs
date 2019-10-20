using FactoryPattern.Concrete;
using System;

namespace FactoryPattern.Factory
{
    public class HundaiCarFactory : CarFactory
    {
        public override Car CreatCarInstance(Enum CarModel)
        {
            switch (CarModel.ToString())
            {
                case "5": return new HundaiI10();
                case "6": return new HundaiI20();
                default: throw new ArgumentException("Invalid model", CarModel.ToString());

            }
        }
    }

}


