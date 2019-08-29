using System;

namespace SOLID_violation
{
    public class CarService : IWashing
    {
        public void Wash(Car c) { }

        public void SaveCarToDB(Car c)
        {
            // saving to DB
        }
    }
}
