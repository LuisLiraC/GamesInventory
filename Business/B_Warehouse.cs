using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {
        public static List<WarehouseEntity> WarehousesList()
        {
            using (InventoryContext db = new InventoryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static WarehouseEntity WarehouseById(string id)
        {
            using (InventoryContext db = new InventoryContext())
            {
                return db.Warehouses.ToList().LastOrDefault(w => w.WarehouseId == id);
            }
        }

        public static void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (InventoryContext db = new InventoryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        public static void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using (InventoryContext db = new InventoryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
