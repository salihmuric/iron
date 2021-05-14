using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class TabletMap : EntityTypeConfiguration<Tablet>
    {
        public TabletMap()
        {
            ToTable(@"TABLET"); 
            HasKey(x => x.Id);
             
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.EkranBoyutu).HasColumnName("Ekran Boyut");
            Property(x => x.DahiliDepolama).HasColumnName("Dahili depolama");
            Property(x => x.HafizaKartDestegi).HasColumnName("Hafıza kart desteği");
            Property(x => x.İsletimSistemi).HasColumnName("İşletim sistemi");
            Property(x => x.ArkaKamera).HasColumnName("Arka kamera");
            Property(x => x.AzamiFrekans).HasColumnName("Azami frekans");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
