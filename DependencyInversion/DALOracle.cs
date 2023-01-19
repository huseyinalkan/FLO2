using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class DALOracle : IDAL
    {
        public List<Product> GetProduct()
        {
            return new List<Product>(){
               new(){Id=1,Name="Kalem 1 Oracle"},
               new(){Id=2,Name="Kalem 2 Oracle"},
            };
        }
    }
}
