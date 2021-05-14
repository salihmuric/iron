using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class AkilliSaat : IEntity
    {
		public int Id { get; set; }
		public string Marka { get; set; }
        public decimal Fiyat { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string EkranBoyut { get; set; }
        public string EkranCozunurluk { get; set; }
        public string BataryaKapasitesi { get; set; }
        public string WiFi { get; set; }
        public string KalpAtisSensoru { get; set; }
        public string SuyaDayaniklilik { get; set; }
        public string ResimLink { get; set; }
    }
}
