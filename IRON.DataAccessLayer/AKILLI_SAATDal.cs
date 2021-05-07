using IRON.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
    public class AKILLI_SAATDal
    {
        public List<AKILLI_SAAT> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.AKILLI_SAAT.ToList();
            }
        }
        public void Add(AKILLI_SAAT AKILLI_SAAT)
        {
            using (IRONContext context = new IRONContext())
            {
                context.AKILLI_SAAT.Add(AKILLI_SAAT);

                context.SaveChanges();
            }
        }
        public void Update(AKILLI_SAAT AKILLI_SAAT)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(AKILLI_SAAT);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(AKILLI_SAAT AKILLI_SAAT)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(AKILLI_SAAT);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}

