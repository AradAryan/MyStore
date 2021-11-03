using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.EntityFarmeworkModels;

namespace Application
{
    public interface IProduct
    {
        IList<Products> GetProducts();
        bool SaveProduct();

    }
}
