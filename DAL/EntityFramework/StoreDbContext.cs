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

        public DbSet<Menus> Menus { get; set; }
        public DbSet<Parents> Parents { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Products> Products { get; set; }

        public string DbPath { get; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Children>()
                .HasOne(p => p.Parents)
                .WithMany(c => c.Children)
                .HasForeignKey(c => c.ParentId);

            modelBuilder.Entity<Children>()
                .Navigation(b => b.Parents)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            //modelBuilder.Entity<Products>()
            //    .HasOne(p => p.Children)
            //    .WithMany(c=>c.Parents)
                
                
        }

    }
}