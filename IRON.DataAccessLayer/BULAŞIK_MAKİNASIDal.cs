using IRON.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
    public class BULAŞIK_MAKİNASIDal
    {
        public List<BULAŞIK_MAKİNASI> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.BULAŞIK_MAKİNASI.ToList();
            }
        }
        public void Add(BULAŞIK_MAKİNASI BULAŞIK_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                context.BULAŞIK_MAKİNASI.Add(BULAŞIK_MAKİNASI);

                context.SaveChanges();
            }
        }
        public void Update(BULAŞIK_MAKİNASI BULAŞIK_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(BULAŞIK_MAKİNASI);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(BULAŞIK_MAKİNASI BULAŞIK_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(BULAŞIK_MAKİNASI);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}


