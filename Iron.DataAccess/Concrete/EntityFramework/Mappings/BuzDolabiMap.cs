using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class BuzDolabiMap : EntityTypeConfiguration<BuzDolabi>
    {
        public BuzDolabiMap()
        {
            ToTable(@"BUZ_DOLABİ"); 
            HasKey(x => x.Id);
             
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.EnerjiSinifi).HasColumnName("Enerji sınıfı");
            Property(x => x.SogutmaSistemi).HasColumnName("Soğutma sistemi");
            Property(x => x.YillikEnerjiTuketimi).HasColumnName("Yıllık enerji tüketimi");
            Property(x => x.SesSeviyesi).HasColumnName("Ses seviyesi");
            Property(x => x.SogutucuNetHacim).HasColumnName("Soğutucu net hacmi");
            Property(x => x.DondurucuNetHacim).HasColumnName("Dondurucu net hacmi");
            Property(x => x.ToplamNetHacim).HasColumnName("Toplam net hacim");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
