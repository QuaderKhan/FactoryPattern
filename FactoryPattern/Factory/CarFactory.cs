using System;

namespace FactoryPattern.Factory
{
    public abstract class CarFactory
    {
        public abstract Car CreatCarInstance(Enum CarModel);
    }
}
