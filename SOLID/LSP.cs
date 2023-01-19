using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    
    public interface ITakePhoto
    {
        public  void TakePhoto();
    }

    public abstract class Phone
    {

         public void Call()
        {
            Console.WriteLine("Arama yapıldı.");
        }

       
    }

    public class IPhone12 : Phone,ITakePhoto
    {
        public  void TakePhoto()
        {
            Console.WriteLine("Fotoğgraf çekildi.");
        }
    }

    public class Nokia3310 : Phone
    {
       
    }


}
