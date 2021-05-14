using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TelevizyonMap : EntityTypeConfiguration<Televizyon>
    {
        public TelevizyonMap()
        {
            ToTable(@"TELEVİZYON");
            HasKey(x => x.Id);
           
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.EkranBoyut).HasColumnName("Ekran Boyut");
            Property(x => x.CozunurlukStandarti).HasColumnName("Çözünürlük standartı");
            Property(x => x.Ekran).HasColumnName("Ekran");
            Property(x => x.SesCikisGucu).HasColumnName("Ses çıkış gücü");
            Property(x => x.CıkısYili).HasColumnName("Çıkış yılı");
            Property(x => x.SmartTV).HasColumnName("Smart TV");
            Property(x => x.EnerjiTuketimSinifi).HasColumnName("Enerji tüketim sınıfı");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }

    }
}
