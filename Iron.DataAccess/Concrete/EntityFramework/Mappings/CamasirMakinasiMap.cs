using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class CamasirMakinasiMap : EntityTypeConfiguration<CamasirMakinasi>
    {
        public CamasirMakinasiMap()
        {
            ToTable(@"CAMASİR_MAKİNASİ"); //TABLO ADI
            HasKey(x => x.Id);
            //TABLODAKİ SÜTUNLARLA C# Sütünları 
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.KullanimTipi).HasColumnName("Kullanım tipi");
            Property(x => x.YikamaKapasitesi).HasColumnName("Yıkama kapasitesi");
            Property(x => x.MaxSikmaDeviri).HasColumnName("Max sıkma deviri");
            Property(x => x.Kurutma).HasColumnName("Kurutma");
            Property(x => x.EnerjiSinifi).HasColumnName("Enerji sınıfı");
            Property(x => x.YillikEnerjiTuketimi).HasColumnName("Yıllık enerji tüketimi");
            Property(x => x.YillikSuTuketimi).HasColumnName("Yıllık su tüketimi");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
