using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InOut
    {
        public static List<InOutEntity> InOutsList()
        {
            using (InventoryContext db = new InventoryContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void CreateInOut(InOutEntity oInOut)
        {
            using (InventoryContext db = new InventoryContext())
            {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        public static void UpdateInOut(InOutEntity oInOut)
        {
            using (InventoryContext db = new InventoryContext())
            {
                db.InOuts.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
