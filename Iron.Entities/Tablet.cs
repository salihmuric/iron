using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
   public class Tablet : IEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Model { get; set; }
        public string EkranBoyutu { get; set; }
        public string DahiliDepolama { get; set; }
        public string HafizaKartDestegi { get; set; }
        public string İsletimSistemi { get; set; }
        public string ArkaKamera { get; set; }
        public string AzamiFrekans { get; set; }
        public string ResimLink { get; set; }
    }
}
