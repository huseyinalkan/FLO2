using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
  
    public interface IReadRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
    }

    public interface IWriteRepository
    {
        void Save(Product newProduct);
        void Update(Product updateProduct);
        void Delete(int id);
    }

    public interface ICustomRepository
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Save(Product newProduct);
    }



 

    public class ProductRepository : IReadRepository,IWriteRepository;
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public void Update(Product updateProduct)
        {
            throw new NotImplementedException();
        }
    }






}
