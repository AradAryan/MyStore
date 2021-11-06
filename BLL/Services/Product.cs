using Application.ViewModels;
using Domain.EntityFarmeworkModels;
using Domain.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class Product : IProduct
    {
        private readonly IStoreDbContext DbContext;
        private readonly IMapper<Domain.EntityFarmeworkModels.Product> Mapper;
        public Product(IStoreDbContext storeDbContext, IMapper<Domain.EntityFarmeworkModels.Product> mapper)
        {
            DbContext = storeDbContext;
            Mapper = mapper;
        }

        public IList<Domain.EntityFarmeworkModels.Product> GetProducts()
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
