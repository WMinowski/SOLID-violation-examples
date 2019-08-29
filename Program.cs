using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_violation
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }


    public class Car
    {
        public CarService carService; // Violating Dependency Inversion principle
        string Name { get; set; }
        public Car(string name)
        {
            Name = name;
        }
        public string GetCarName()
        {
            return Name;
        }
        public void SaveCarToDB()
        {
            // saving to DB
        } // Violating Single responsibility principle

        public string CarSound(List<Car> cars)
        {
            foreach (Car c in cars)
            {
                if (c.Name == "BMW") return "Wroom-wroom";
                if (c.Name == "VAZ") return "I can`t start";
                
            }
            return string.Empty;
        } // Violating Open-Closed principle
        public int CarPowerCount(List<Car> cars)
        {
            foreach(Car c in cars)
            {
                if (c.Name == "BMW") return BMWPowerCount(c);
                if (c.Name == "VAZ") return VAZPowerCount(c);
            }
            return 0;
        } // Violating Liskov substitution principle
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

    public interface ICar
    {
        Car CreateBMW();
        Car CreateVAZ();
    } // Violating Interface Segregation principle

    public class CarService
    {
        public void Wash() { }
    }

}
