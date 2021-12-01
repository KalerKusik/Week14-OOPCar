using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string markName;
            string model;
            string reg;
            string color;
            int odometer;
            int fuel;
            
            public Car(string _markName, string _model, string _reg, string _color)
            {
                markName = _markName;
                model = _model;
                reg = _reg;
                color = _color;
                odometer = 0;
                fuel = 60;
                Console.WriteLine($"{color} {markName} {model} has been bought.");
            }
            
            public string Model
            {
                get { return model; }
            }

            public string Mark
            {
                get { return markName; }
            }

            public string Registration
            {
                get { return reg; }
            }

            public string Color
            {
                get { return color; }
            }

            public int OdoMeter
            {
                get { return odometer; }
            }

            public int Fuel
            {
                get { return fuel; }
            }

            public void Drive()
            {
                odometer += 100;
                fuel -= 5;
                Console.WriteLine("Lap done.");
                Console.WriteLine($"Fuel level is now at: {fuel}");
                Console.WriteLine($"Odometer is now showing: {odometer}");
            }
            public void ShowCarData()
            {
                Console.WriteLine($"Car name: {markName} {model}");
                Console.WriteLine($"Registration: {reg}");
                Console.WriteLine($"Fuel: {fuel}");
                Console.WriteLine($"Odometer: {odometer}");
                Console.WriteLine($"Color: {color}");
            }
            static void Main(string[] args)
            {
                Car myCar = new Car("Dodge", "Charger R/T (1969)", "LOL420", "Orange");
                while (myCar.Fuel > 0)
                {
                    myCar.Drive();
                }
                myCar.ShowCarData();
            }
        }
    }
}
