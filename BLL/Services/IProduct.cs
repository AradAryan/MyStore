using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.EntityFarmeworkModels;

namespace Application.Services
{
    public interface IProduct
    {
        IList<Domain.EntityFarmeworkModels.Product> GetProducts();
        bool SaveProduct(ProductVM product);

    }
}
