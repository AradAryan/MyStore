using Domain.EntityFarmeworkModels;
using Domain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Product : IProduct
    {
        IStoreDbContext DbContext;
        public Product(IStoreDbContext storeDbContext)
        {
            DbContext = storeDbContext;
        }

        public IList<Products> GetProducts()
        {
            var result = DbContext.Products.ToList();
            return result;
        }

        public bool SaveProduct()
        {
            DbContext.Products.Add(new Products { Name = new Random().Next(1, 10000).ToString(), Price = new Random().Next(1, 10000) });
            return DbContext.SaveChanges() == 1;
        }
    }
}
