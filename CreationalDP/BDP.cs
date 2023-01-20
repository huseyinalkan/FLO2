using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.BDP
{

    public interface ICarBuilder
    {
        void SetModel(string model);
        void SetSeat();
        void SetGear();
        void SetWindShield();

        Car GetCar();


    }

    public class HatchbackCarBuilder : ICarBuilder
    {
        private Car _car = new();
        public Car GetCar()
        {
            return _car;
        }

        public void SetGear()
        {
            _car.Gear = Gear.Manuel;
        }

        public void SetModel(string model)
        {
            _car.Model = model;
        }

        public void SetSeat()
        {
            _car.Seat = Seat.Four;
        }

        public void SetWindShield()
        {
            _car.WindShield = new WindShield() { Model = "Dark", Type = 20 };
        }
    }

    public class SedanbackCarBuilder : ICarBuilder
    {
        private Car _car = new();
        public Car GetCar()
        {
            return _car;
        }

        public void SetGear()
        {
            _car.Gear = Gear.Automatic;
        }

        public void SetModel(string model)
        {
            _car.Model = model;
        }

        public void SetSeat()
        {
            _car.Seat = Seat.Six;
        }

        public void SetWindShield()
        {
            _car.WindShield = new WindShield() { Model = "Light", Type = 15 };
        }
    }


    public class CarDirector
    {
        private readonly ICarBuilder _carBuilder;

        public CarDirector(ICarBuilder carBuilder)
        {
            _carBuilder = carBuilder;
        }

        public Car GetCar(string model)
        {
            _carBuilder.SetModel(model);
            _carBuilder.SetGear();
            _carBuilder.SetSeat();
            _carBuilder.SetWindShield();
            return _carBuilder.GetCar();



        }
    }




 







    public class Car
    {
        public string Model { get; set; } = null!;
        public Seat Seat { get; set; }
        public Gear Gear { get; set; }
        public WindShield WindShield { get; set; } = null!;

        public override string ToString()
        {
            return $"{Model} {Seat} {Gear}";
        }


    }




    public enum Seat
    {
        Two,
        Four,
        Six,
        
    }
    public enum Gear
    {
        Automatic,
        Manuel
    }
    public class WindShield
    {
        public string Model { get; set; }
        public int Type { get; set; }
    }



}
