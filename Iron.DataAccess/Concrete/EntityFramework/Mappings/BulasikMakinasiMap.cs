using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class BulasikMakinasiMap : EntityTypeConfiguration<BulasikMakinasi>
    {
        public BulasikMakinasiMap()
        {
            ToTable(@"BULASİK_MAKİNASİ"); //TABLO ADI
            HasKey(x => x.Id);
            //TABLODAKİ SÜTUNLARLA C# Sütünları 
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.Renk).HasColumnName("Renk");
            Property(x => x.SuTuketimi).HasColumnName("Su tüketimi");
            Property(x => x.KullanimTipi).HasColumnName("Kullanım tipi");
            Property(x => x.EnerjiSinifi).HasColumnName("Enerji sınıfı");
            Property(x => x.Kapasite).HasColumnName("Kapasite");
            Property(x => x.ProgramSayisi).HasColumnName("Program sayısı");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
