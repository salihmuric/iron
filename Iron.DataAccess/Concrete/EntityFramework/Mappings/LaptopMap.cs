using Iron.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.DataAccess.Concrete.EntityFramework.Mappings
{
    public class LaptopMap : EntityTypeConfiguration<Laptop>
    {
        public LaptopMap()
        {
            ToTable(@"LAPTOP");
            HasKey(x => x.Id);
             
            Property(x => x.Id).HasColumnName("ID");
            Property(x => x.Marka).HasColumnName("Marka");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Model).HasColumnName("Model");
            Property(x => x.EkranBoyutu).HasColumnName("Ekran boyutu");
            Property(x => x.EkranCozunurlugu).HasColumnName("Ekran çözünürlüğü");
            Property(x => x.İslemciModeli).HasColumnName("İşlemci modeli");
            Property(x => x.Bellek).HasColumnName("Bellek(RAM)");
            Property(x => x.İslemciSistemi).HasColumnName("İşletim sistemi");
            Property(x => x.GPUSerisi).HasColumnName("GPU serisi");
            Property(x => x.SabitDisk).HasColumnName("Sabit disk (SSD)");
            Property(x => x.ResimLink).HasColumnName("datagridview");
        }
    }
}
