using IRON.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
    public class ÇAMAŞIR_MAKİNASIDal
    {
        public List<ÇAMAŞIR_MAKİNASI> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.ÇAMAŞIR_MAKİNASI.ToList();
            }
        }
        public void Add(ÇAMAŞIR_MAKİNASI ÇAMAŞIR_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                context.ÇAMAŞIR_MAKİNASI.Add(ÇAMAŞIR_MAKİNASI);

                context.SaveChanges();
            }
        }
        public void Update(ÇAMAŞIR_MAKİNASI ÇAMAŞIR_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(ÇAMAŞIR_MAKİNASI);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(ÇAMAŞIR_MAKİNASI ÇAMAŞIR_MAKİNASI)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(ÇAMAŞIR_MAKİNASI);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}


