using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class BulasikMakinasi : IEntity
    {
        public string Id { get; set; }
        public string Marka { get; set; }
        public string Fiyat { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string SuTuketimi { get; set; }
        public string KullanimTipi { get; set; }
        public string EnerjiSinifi { get; set; }
        public string Kapasite { get; set; }
        public string ProgramSayisi { get; set; }
        public string ResimLink { get; set; }
        //Property(x => x.Id).HasColumnName("ID");
        //Property(x => x.Marka).HasColumnName("Marka");
        //Property(x => x.Fiyat).HasColumnName("Fiyat");
        //Property(x => x.Model).HasColumnName("Model");
        //Property(x => x.Renk).HasColumnName("Renk");
        //Property(x => x.SuTuketimi).HasColumnName("Su tüketimi");
        //Property(x => x.KullanimTipi).HasColumnName("Kullanım tipi");
        //Property(x => x.EnerjiSinifi).HasColumnName("Enerji sınıfı");
        //Property(x => x.Kapasite).HasColumnName("Kapasite");
        //Property(x => x.ProgramSayisi).HasColumnName("Program sayısı");
        //Property(x => x.ResimLink).HasColumnName("datagridview");
    }
}
