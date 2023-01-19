using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASAISA.HasA
{
    public interface IRightOrLeftBehavior
    {
        void Right();
        void Left();
    }

    public interface IBackwardBehavior
    {
        void Backward();
    }

    public class NormalBackwardBehavior : IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("Normal Backward");
        }
    }


    public class SuperBackwardBehavior:IBackwardBehavior
    {
        public void Backward()
        {
            Console.WriteLine("Super Backward");
        }
    }


    public class NormalRightOrLeftBehavior : IRightOrLeftBehavior
    {
        public void Left()
        {
            Console.WriteLine("Normal Left");
        }

        public void Right()
        {
            Console.WriteLine("Normal Right");
        }
    }


    public abstract class Vehicle
    {

        protected IBackwardBehavior _backBehavior;
        protected IRightOrLeftBehavior _rightOrleftBehavior;


        public void SetBackwardBehavior(IBackwardBehavior backwardBehavior)
        {
            _backBehavior= backwardBehavior;
        }


        //protected Vehicle(IRightOrLeftBehavior rightOrleftBehavior, IBackwardBehavior backBehavior)
        //{
        //    _rightOrleftBehavior = rightOrleftBehavior;
        //    _backBehavior = backBehavior;
        //}

        public void Forward()
        {
            Console.WriteLine("Forward");
        }

        public void Backward()
        {
            _backBehavior.Backward();
        }
        public void Left()
        {
            _rightOrleftBehavior.Left();
        }
        public void Right()
        {
            _rightOrleftBehavior.Right();
        }



    }


    public class Car1 : Vehicle
    {

        public Car1()
        {
            _rightOrleftBehavior = new NormalRightOrLeftBehavior();
            _backBehavior = new NormalBackwardBehavior();
        }
      





    }


    public class Car2:Vehicle
    {
        public Car2()
        {
            _rightOrleftBehavior = new NormalRightOrLeftBehavior();
            _backBehavior = new SuperBackwardBehavior();
        }



    }
}
