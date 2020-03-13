using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class InventoryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
        public DbSet<InOutEntity> InOuts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-VSK1MRU\\SQLEXPRESS; Database=GameInventory; Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity() {
                    CategoryId = "ADV", 
                    CategoryName = "Adventure" 
                },
                new CategoryEntity() { 
                    CategoryId = "ACT", 
                    CategoryName = "Action" 
                },
                new CategoryEntity() { 
                    CategoryId = "ROL",
                    CategoryName = "Role" 
                },
                new CategoryEntity() { 
                    CategoryId = "STR", 
                    CategoryName = "Strategy"
                },
                new CategoryEntity() { 
                    CategoryId = "SPR", 
                    CategoryName = "Sports" 
                },
                new CategoryEntity() {
                    CategoryId = "PZZ",
                    CategoryName = "Puzzle" 
                }
            );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity() { 
                    WarehouseId = Guid.NewGuid().ToString(), 
                    WarehouseName = "Main Warehouse", 
                    WarehouseAddress = "932 Pallet Street, La Grange (Dutchess), NY 12540" 
                },
                new WarehouseEntity() { 
                    WarehouseId = Guid.NewGuid().ToString(), 
                    WarehouseName = "Second Warehouse",
                    WarehouseAddress = "4447 Dane Street, Yakima, WA 98908"
                },
                new WarehouseEntity() { 
                    WarehouseId = Guid.NewGuid().ToString(), 
                    WarehouseName = "Third Warehouse", 
                    WarehouseAddress = "3003 Arrowood Drive, Jacksonville, FL 32257" 
                }
            );
        }
    }
}
