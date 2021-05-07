using IRON.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IRON.DataAccessLayer
{
    public class IRONContext:DbContext
    {
        public DbSet<TELEFON> TELEFON { get; set; }
        public DbSet<TV> TABLET { get; set; }
        public DbSet<Tablet> TV { get; set;
        public DbSet<LAPTOP> LAPTOP { get; set; }
        public DbSet<KLİMA> KLİMA { get; set; }
        public DbSet<BULAŞIK_MAKİNASI> BULAŞIK_MAKİMASI { get; set; }
        public DbSet<ÇAMAŞIR_MAKİNASI> ÇAMAŞIR_MAKİMASI { get; set; }
        public DbSet<KURUTMA_MAİNASI> KURUTMA_MAKİMASI { get; set; }
        public DbSet<BUZ_DOLABI> BUZ_DOLABI { get; set; }
        public DbSet<AKILLI_SAAT> AKILLI_SAAT { get; set; }
        public object KURUTMA_MAKİNASI { get; internal set; }
        public object BULAŞIK_MAKİNASI { get; internal set; }
        public object ÇAMAŞIR_MAKİNASI { get; internal set; }
        public object TELEVİZYON { get; internal set; }
    }
    }
}
