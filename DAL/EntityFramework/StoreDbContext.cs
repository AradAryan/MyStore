using Domain.EntityFarmeworkModels;
using Domain.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Domain.EntityFramework
{
    public class StoreDbContext : DbContext, IStoreDbContext
    {
        #region [ Constructors ]
        public StoreDbContext()
        {

        }
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }
        #endregion

        #region [ Fields ]

        public DbSet<Menu> Menus { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Product> Products { get; set; }

        public string DbPath { get; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Child>()
                .HasOne(p => p.Parents)
                .WithMany(c => c.Children)
                .HasForeignKey(c => c.ParentId);

            modelBuilder.Entity<Child>()
                .Navigation(b => b.Parents)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            //modelBuilder.Entity<Products>()
            //    .HasOne(p => p.Children)
            //    .WithMany(c=>c.Parents)
                
                
        }

    }
}