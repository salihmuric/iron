using IRON.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
    public class BUZ_DOLABIDal
    {
        public List<BUZ_DOLABI> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.BUZ_DOLABI.ToList();
            }
        }
        public void Add(BUZ_DOLABI BUZ_DOLABI)
        {
            using (IRONContext context = new IRONContext())
            {
                context.BUZ_DOLABI.Add(BUZ_DOLABI);

                context.SaveChanges();
            }
        }
        public void Update(BUZ_DOLABI BUZ_DOLABI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(BUZ_DOLABI);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(BUZ_DOLABI BUZ_DOLABI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(BUZ_DOLABI);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}


