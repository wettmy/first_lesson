using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace first_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car BMW = new Car("BMW", "M5", 120, 2022);
            
            BMW.Accelerate(3);
            Console.WriteLine("Первая машина: ");
            BMW.ShowCarInfo();

            Car Mazda = new Car("Mazda", "RX-8", 100, 2004);
            Mazda.Accelerate(30);
            Console.WriteLine("Вторая машина: ");
            Mazda.ShowCarInfo();
        }
    }

    class Car
    {
        private string _brand;
        private string _model;
        private int _speed;
        private int _year;

        public string Brand
        {
            get { return _brand; }
            set
            {
                if (value != null && value != _brand && value != "") { _brand = value; }
                else { throw new ArgumentException("Invalid car brand"); }
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                if (value != null && value != _model && value != "") { _model = value; }
                else { throw new ArgumentException("Invalid student name"); }

            }
        }

        public int Speed
        {
            get { return _speed; }
            private set 
            {
                if (value >= 0)
                    _speed = value;
                else
                    _speed = 0;
            }
        }

        public int Year
        {
            get { return _year; }
            private set { _year = value; }
        }
        public Car()
        {
            _brand = "unknown";
            _model = "unknown";
            _speed = 0;
            _year = 0; 
        }

        public Car(string brand, string model, int speed, int year)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
            Year = year;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine("Car brand: " + _brand);
            Console.WriteLine("Car model: " + _model);
            Console.WriteLine("Car speed: " + _speed + " k/m");
            Console.WriteLine("Car year: " + _year);
        }
          
        public void Accelerate(int value)
        {
            Speed += value;
        }

    }
}
