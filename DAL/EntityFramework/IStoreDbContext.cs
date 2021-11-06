using Domain.EntityFarmeworkModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntityFramework
{
    public interface IStoreDbContext
    {
        int SaveChanges();
        DbSet<Product> Products { get; set; }
        string DbPath { get; }
    }
}
