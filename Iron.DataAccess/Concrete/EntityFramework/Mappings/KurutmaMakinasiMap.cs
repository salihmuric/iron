using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class KurutmaMakinasiMap : EntityTypeConfiguration<KurutmaMakinasi>
    {
        public KurutmaMakinasiMap()
        {
            ToTable(@"KURUTMA_MAKİNASİ"); 
            HasKey(x => x.Id);
            
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.Renk).HasColumnName("Renk");
            Property(x => x.EnerjiSinifi).HasColumnName("Enerji sınıfı");
            Property(x => x.KurutmaKapasitesi).HasColumnName("Kurutma kapasitesi");
            Property(x => x.KurutmaSesi).HasColumnName("Kurutma sesi");
            Property(x => x.KurutmaTeknolojisi).HasColumnName("Kurutma teknolojisi");
            Property(x => x.CocukKilidi).HasColumnName("Çocuk kilidi");
            Property(x => x.KalanSureGostergesi).HasColumnName("Kalan süre göstergesi");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
