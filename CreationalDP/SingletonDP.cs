using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP.SingletonDP
{

    public class MySingletonLazy
    {
        private static readonly Lazy<MySingletonLazy> lazy = new Lazy<MySingletonLazy>(() => new MySingletonLazy());

        public static MySingletonLazy Instance = lazy.Value;



    }
    public class MySingletonThreadSafeShort
    {
        public static MySingletonThreadSafeShort Instance { get; } = new();

        public static MySingletonThreadSafeShort Instance2 => new();

    }
    public class MySingleton
    {
        private static MySingleton _instance = null!;
        private static readonly object _myLock = new();
        private MySingleton()
        {

           
            


        }
        public static MySingleton CreateInstance()
        {
            lock (_myLock)
            {
                if (_instance == default(MySingleton))
                {
                    _instance = new MySingleton();
                }
            }
            
            return _instance; ;
        }



    }
}
