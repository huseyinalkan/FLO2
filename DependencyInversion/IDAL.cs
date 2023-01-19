using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal interface IDAL
    {
        public List<Product> GetProduct();
    }
}
