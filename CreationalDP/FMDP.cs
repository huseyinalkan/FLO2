using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CreationalDP.FMDP
{

    public class Response<T>
    {
        public T? Data { get; set; }
        public List<string>? Erros { get; set; }

        [JsonIgnore]
        public int Status { get; set; }


        public static Response<T> Success(T data,int statusCode)
        {
            return new Response<T> { Data = data, Status = statusCode, Erros = null };
        }
        public static Response<T> Fail(List<string> errors,int statusCode)
        {
            return new Response<T> { Data = default(T), Status = statusCode, Erros = errors };
        }

        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T> { Data = default(T), Status = statusCode, Erros = new List<string>() { error } };
        }

    }










    public class PDF {

        public Color    BackgroundColor { get; set; }
        public Color ForegroundColor { get; set; }
        public Color HeaerColor { get; set; }
    }

    public class PDFFactory
    {
        public PDF CreateWithA4Shape(string header,string content)
        {
            return new PDF() { BackgroundColor = Color.Red, ForegroundColor = Color.Green, HeaerColor = Color.Blue };
        }


        public PDF CreateWithA4Shape(string header, string content, Color HeaderColor)
        {
            return new PDF() { BackgroundColor = Color.Red, ForegroundColor = Color.Green, HeaerColor = HeaderColor };
        }
        public PDF CreateWithA3Shape(string header, string content)
        {
            return new PDF();
        }
    }



    public interface ICustomer
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Type { get; }
    }


    public class ManagerCustomer : ICustomer
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Type { get; } = 1;
    }
    public class BaseCustomer:ICustomer
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Type { get; } = 2;
    }


    public interface ICustomerFactory
    {
        ICustomer CreateBaseCustomer(string name);
        ICustomer CreateManagerCustomer(string name);
    }


    public  class CustomerFactory:ICustomerFactory
    {
       public ICustomer CreateBaseCustomer(string name) { return new BaseCustomer(); }
       public ICustomer CreateManagerCustomer(string name) { return new ManagerCustomer(); }



    }

    public class CustomerFactoryWithAlfa : ICustomerFactory
    {
        public ICustomer CreateBaseCustomer(string name) { return new BaseCustomer(); }
        public ICustomer CreateManagerCustomer(string name) { return new ManagerCustomer(); }



    }



    public abstract class BaseEntity
    {
        public DateTime Created { get; set; }
        
    }


   public class Product:BaseEntity
    {

        public string Name { get; set; }
        public int Type { get; set; } // Sea // Land // Air
    }

    public interface  IFactory
    {

        BaseEntity Create();
    }

    public class ProductFactory : IFactory
    {
        public BaseEntity Create()
        {
            return new Product() { Created = DateTime.Now ,Type=1};
        }

        public BaseEntity  CreateWithSea(string Name)
        {
            return new Product() { Created = DateTime.Now, Type = 1 ,Name=Name };
        }

        public BaseEntity CreateWithLand(string Name)
        {
            return new Product() { Created = DateTime.Now, Type = 2, Name=Name };
        }

        public BaseEntity CreateWithAir(string Name)
        {
            return new Product() { Created = DateTime.Now, Type = 3, Name=Name };
        }
    }






}
