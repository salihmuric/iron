using Iron.Core.DataAccess.EntityFramework;
using Iron.DataAccess.Abstarct;
using Iron.DataAccess.Concrete.EntityFramework;
using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework
{
    public class EFAkilliSaatDal : EfEntityRepositoryBase<AkilliSaat, IronContext>, IAkilliSaatDal
    {
    }
}
