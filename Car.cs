using System;
using System.Collections.Generic;

namespace SOLID_violation
{
    public abstract class Car : ICar
    {
        public abstract string Name { get; set; }

        public abstract string Sound { get;}

        public abstract int PowerCount();

    }
}
