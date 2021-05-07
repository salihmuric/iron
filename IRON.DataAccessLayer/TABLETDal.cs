using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
    public class TABLETDal
    {
        public List<TABLET> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.TABLET.ToList();
            }
        }
        public void Add(TABLET TABLET)
        {
            using (IRONContext context = new IRONContext())
            {
                EntitiesLayer.TV tV = context.TABLET.Add(TABLET);

                context.SaveChanges();
            }
        }
        public void Update(TABLET TABLET)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(TABLET);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(TABLET TABLET)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(TABLET);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}

