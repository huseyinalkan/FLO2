using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.BDP.Fluent
{

    public interface ICarBuilderFluent
    {
        ICarBuilderFluent SetModel(string model);
        ICarBuilderFluent SetSeat();
        ICarBuilderFluent SetGear();
        ICarBuilderFluent SetWindShield();

        Car GetCar();


    }

    public class HatchbackCarBuilderFluent : ICarBuilderFluent
    {
        private Car _car = new();
        public Car GetCar()
        {
            return _car;
        }

        public ICarBuilderFluent SetGear()
        {
            _car.Gear = Gear.Manuel;
            return this;
        }

        public ICarBuilderFluent SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilderFluent SetSeat()
        {
            _car.Seat = Seat.Four;
            return this;
        }

        public ICarBuilderFluent SetWindShield()
        {
            _car.WindShield = new WindShield() { Model = "Dark", Type = 20 };
            return this;
        }
    }


    public class SedanbackCarBuilderFluent : ICarBuilderFluent
    {
        private Car _car = new();
        public Car GetCar()
        {
            return _car;
        }

        public ICarBuilderFluent SetGear()
        {
            _car.Gear = Gear.Automatic;
            return this;
        }

        public ICarBuilderFluent SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilderFluent SetSeat()
        {
            _car.Seat = Seat.Six;
            return this;
        }

        public ICarBuilderFluent SetWindShield()
        {
            _car.WindShield = new WindShield() { Model = "Light", Type = 15 };
            return this;
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
