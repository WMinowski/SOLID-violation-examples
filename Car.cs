using System;

namespace SOLID_violation
{
    public abstract class Car : ICar
    {
        string Name { get; set; }

        string Sound { get; set; }

        public Car(string name)
        {
            Name = name;
        }
        

        public string CarSound(List<Car> cars)
        {
            foreach (Car c in cars)
            {
                if (c.Name == "BMW") return "Wroom-wroom";
                if (c.Name == "VAZ") return "I can`t start";

            }
            return string.Empty;
        }
        public int CarPowerCount(List<Car> cars)
        {
            foreach (Car c in cars)
            {
                if (c.Name == "BMW") return BMWPowerCount(c);
                if (c.Name == "VAZ") return VAZPowerCount(c);
            }
            return 0;
        }
        public int BMWPowerCount(Car c)
        {
            if (c.Name == "BMW") return 500;
            else return 0;
        }
        public int VAZPowerCount(Car c)
        {
            if (c.Name == "VAZ") return 65;
            else return 0;
        }

    }
}
