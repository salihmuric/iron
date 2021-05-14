using Iron.DataAccess.Concrete.EntityFramework.Mappings;
using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework
{
    public class IronContext : DbContext
    {
        public IronContext()
        {
            Database.SetInitializer<IronContext>(null);
        }


        public DbSet<Telefon> Telefons { get; set; }
        public DbSet<AkilliSaat> AkilliSaats { get; set; }
        public DbSet<BulasikMakinasi> BulasikMakinasis { get; set; }
        public DbSet<BuzDolabi> BuzDolabis { get; set; }
        public DbSet<CamasirMakinasi> CamasirMakinasis { get; set; }
        public DbSet<Klima> Klimas { get; set; }
        public DbSet<KurutmaMakinasi> KurutmaMakinasis { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Tablet> Tablets { get; set; }
        public DbSet<Televizyon> Televizyons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AkilliSaatMap());
            modelBuilder.Configurations.Add(new BulasikMakinasiMap());
            modelBuilder.Configurations.Add(new BuzDolabiMap());
            modelBuilder.Configurations.Add(new CamasirMakinasiMap());
            modelBuilder.Configurations.Add(new KlimaMap());
            modelBuilder.Configurations.Add(new KurutmaMakinasiMap());
            modelBuilder.Configurations.Add(new LaptopMap());
            modelBuilder.Configurations.Add(new TabletMap());
            modelBuilder.Configurations.Add(new TelefonMap());
            modelBuilder.Configurations.Add(new TelevizyonMap());
        }
    }
}
