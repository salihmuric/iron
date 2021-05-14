using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class Telefon : IEntity
    {
		public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string Kapasite { get; set; }
        public string Kamera { get; set; }
        public string EkranBoyutu { get; set; }
        public string SuyaDayaniklilik { get; set; }
        public string Destek { get; set; }
        public string ResimLink { get; set; }
	}
}
