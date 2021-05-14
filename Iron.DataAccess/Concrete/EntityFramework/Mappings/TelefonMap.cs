using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TelefonMap : EntityTypeConfiguration<Telefon>
    {
        public TelefonMap()
        {
            ToTable(@"TELEFON"); 
            HasKey(x => x.Id);
            
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.Renk).HasColumnName("Renk");
            Property(x => x.Kapasite).HasColumnName("Kapasite");
            Property(x => x.Kamera).HasColumnName("Kamera");
            Property(x => x.EkranBoyutu).HasColumnName("Ekran boyutu");
            Property(x => x.Destek).HasColumnName("4.5G desteği");
            Property(x => x.SuyaDayaniklilik).HasColumnName("Suya dayannıklılık");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
