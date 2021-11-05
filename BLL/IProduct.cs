using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.EntityFarmeworkModels;

namespace Application
{
    public interface IProduct
    {
        IList<Products> GetProducts();
        bool SaveProduct(ProductVM product);

    }
}
