using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASAISA.IsA
{


    public interface IRightOrLeft
    {
        public  void Right();
        public  void Left();
    }
   public abstract class Vehicle
    {
        public void Forward()
        {
            Console.WriteLine("Forward");
        }

        public abstract void Backward();

       
    }


    public class Car1 : Vehicle,IRightOrLeft
    {
        public override void Backward()
        {
            Console.WriteLine("Basic Backward");
        }

        public  void Left()
        {
            Console.WriteLine("Basic Left");
        }

        public  void Right()
        {
            Console.WriteLine("Basic Right");
        }
    }

    public class Car2 : Vehicle,IRightOrLeft
    {
        public override void Backward()
        {
            throw new NotImplementedException();
        }

        public  void Left()
        {
            Console.WriteLine("Basic2 Left");
        }

        public  void Right()
        {
            Console.WriteLine("Basic2 Right");
        }
    }

    public class Car3 : Vehicle,IRightOrLeft
    {
        public override void Backward()
        {
            Console.WriteLine("Basic Backward");
        }

        public  void Left()
        {
            throw new NotImplementedException();
        }

        public  void Right()
        {
            throw new NotImplementedException();
        }
    }


    public class Train : Vehicle
    {
        public override void Backward()
        {
            throw new NotImplementedException();
        }

      
    }


}
