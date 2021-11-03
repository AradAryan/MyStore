using Domain.EntityFarmeworkModels;
using Domain.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Domain.EntityFramework
{
    public class StoreDbContext : DbContext, IStoreDbContext
    {

        public StoreDbContext()
        {

        }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
            
        }

        public DbSet<Products> Products { get; set; }
        public string DbPath { get; }
    }
}