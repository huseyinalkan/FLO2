using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.PDP
{

   
    public interface IPrototype
    {
        Object Clone();
    }


    public class Product : IPrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Address Address { get; set; }
        public object Clone()
        {


            var product = this.MemberwiseClone() as Product;
            product.Address = product.Address.Clone() as Address;
            return product;
        }
    }


    public class Address:IPrototype

    {

        public string Line { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

}
