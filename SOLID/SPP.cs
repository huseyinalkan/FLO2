using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
   

    public class ProductRepository
    {
        private readonly List<Product> _productRepository = new();

        void Add(Product product)
        {
            _productRepository.Add(product);
        }


    }
    public class ProductPresenter
    {

        void WriteToConsole(List<Product> _productRepository)
        {
            _productRepository.ForEach(x =>
            {
                Console.WriteLine($"{x.Id} {x.Name}");
            });
        }
    }


    public class Product
    {
        public int? Id { get; set; }
        public string? Name { get; set; }

       

        
        

       


    }
}
