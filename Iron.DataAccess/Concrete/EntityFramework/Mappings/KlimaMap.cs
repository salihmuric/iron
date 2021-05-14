using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class KlimaMap : EntityTypeConfiguration<Klima>
    {
        public KlimaMap()
        {
            ToTable(@"KLİMA"); 
            HasKey(x => x.Id);
            
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.Renk).HasColumnName("Renk");
            Property(x => x.SogutmaKapasitesi).HasColumnName("Soğutma kapasitesi");
            Property(x => x.İsitmaKapasitesi).HasColumnName("Isıtma kapasitesi");
            Property(x => x.SogutmaVerimliligi).HasColumnName("Soğutma verimliliği");
            Property(x => x.İsitmaVerimliligi).HasColumnName("Isıtma verimliliği");
            Property(x => x.İcUniteSesBasinci).HasColumnName("İç ünite ses basıncı");
            Property(x => x.YillikKullanimGuc).HasColumnName("Yıllık kullanım güç");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
