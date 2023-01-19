using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class BL
    {
        private readonly IDAL _dal;

        public BL(IDAL dal)
        {
            _dal = dal;
        }

        public List<Product> GetProduct()
        {
           

            return _dal.GetProduct().Select(x => new Product() { Id = x.Id, Name = x.Name.ToUpper() }).ToList();

        }
    }
}
