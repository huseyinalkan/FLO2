using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    internal class DALFactory
    {
        public IDAL GetDAL()
        {
            return new DAL();
        }
        public IDAL GetDalWithOracle()
        {
            return new DALOracle();
        }
    }
}
