using IRON.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
    public class TELEFONDal
    {
        public List<TELEFON> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.TELEFON.ToList();
            }
        }
        public void Add(TELEFON TELEFON)
        {
            using (IRONContext context = new IRONContext())
            {
                context.TELEFON.Add(TELEFON);

                context.SaveChanges();
            }
        }
        public void Update(TELEFON TELEFON)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(TELEFON);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(TELEFON TELEFON)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(TELEFON);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
