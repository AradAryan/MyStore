using Application.ViewModels;
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
        private readonly IStoreDbContext DbContext;
        private readonly IMapper<Products> Mapper;
        public Product(IStoreDbContext storeDbContext, IMapper<Products> mapper)
        {
            DbContext = storeDbContext;
            Mapper = mapper;
        }

        public IList<Products> GetProducts()
        {
            var result = DbContext.Products.ToList();
            return result;
        }

        public bool SaveProduct(ProductVM product)
        {
            DbContext.Products.Add(Mapper.Map(product));
            return DbContext.SaveChanges() == 1;
        }
    }
}
