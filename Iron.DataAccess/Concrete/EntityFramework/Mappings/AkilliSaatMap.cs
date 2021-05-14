using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AkilliSaatMap : EntityTypeConfiguration<AkilliSaat>
    {
        public AkilliSaatMap()
        {
            //YAZARKEN DİKKAT ET SIÇARIZ!!

            ToTable(@"AKILLI_SAAT"); //TABLO ADI
            HasKey(x => x.Id);
            //TABLODAKİ SÜTUNLARLA C# Sütünları 
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.Renk).HasColumnName("Renk");
            Property(x => x.EkranBoyut).HasColumnName("Ekran Boyut");
            Property(x => x.EkranCozunurluk).HasColumnName("Ekran çözünürlüğü");
            Property(x => x.BataryaKapasitesi).HasColumnName("Batarya kapasitesi");
            Property(x => x.WiFi).HasColumnName("Wİ-Fİ");
            Property(x => x.KalpAtisSensoru).HasColumnName("Kalp atış sensörü");
            Property(x => x.SuyaDayaniklilik).HasColumnName("Suya dayanıklılık");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
