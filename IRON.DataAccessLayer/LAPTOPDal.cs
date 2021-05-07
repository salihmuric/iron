using IRON.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
   public class LAPTOPDal
    {
        public List<LAPTOP> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.LAPTOP.ToList();
            }
        }
        public void Add(LAPTOP LAPTOP)
        {
            using (IRONContext context = new IRONContext())
            {
                context.LAPTOP.Add(LAPTOP);

                context.SaveChanges();
            }
        }
        public void Update(LAPTOP LAPTOP)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(LAPTOP);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(LAPTOP LAPTOP)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(LAPTOP);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}


