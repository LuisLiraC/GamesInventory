using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductsList()
        {
            using (InventoryContext db = new InventoryContext())
            {
                return db.Products.ToList();
            }
        }

        public static ProductEntity ProductById(string id)
        {
            using (InventoryContext db = new InventoryContext())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }

        public static void CreateProduct(ProductEntity oProduct)
        {
            using (InventoryContext db = new InventoryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (InventoryContext db = new InventoryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
