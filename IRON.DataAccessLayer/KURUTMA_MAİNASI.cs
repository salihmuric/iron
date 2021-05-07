using IRON.EntitiesLayer;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace IRON.DataAccessLayer
{
    public class KURUTMA_MAİNASI
    {
        public List<KURUTMA_MAKİNASI> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.KURUTMA_MAKİNASI.ToList();
            }
        }
        public void Add(KURUTMA_MAKİNASI KURUTMA_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                context.KURUTMA_MAKİNASI.Add(KURUTMA_MAKİNASI);

                context.SaveChanges();
            }
        }
        public void Update(KURUTMA_MAKİNASI KURUTMA_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(KURUTMA_MAKİNASI);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(KURUTMA_MAKİNASI KURUTMA_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(KURUTMA_MAKİNASI);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}

