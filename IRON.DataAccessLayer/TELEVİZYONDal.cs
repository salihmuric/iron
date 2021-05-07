    using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON.DataAccessLayer
{
    public class TELEVİZYONDal
    {
        public List<TELEVİZYON> GetAll()
        {
            using (IRONContext context = new IRONContext())
            {
                return context.TELEVİZYON.ToList();
            }
        }
        public void Add(TELEVİZYON TELEVİZYON)
        {
            using (IRONContext context = new IRONContext())
            {
                context.TELEVİZYON.Add(TELEVİZYON);

                context.SaveChanges();
            }
        }
        public void Update(TELEVİZYON TELEVİZYON)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(TELEVİZYON);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(TELEVİZYON TELEVİZYON)
        {
            using (IRONContext context = new IRONContext())
            {
                var entity = context.Entry(TELEVİZYON);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}


