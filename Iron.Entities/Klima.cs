using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class Klima : IEntity
    {
		public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Model { get; set; }
	    public string Renk { get; set; }
        public string SogutmaKapasitesi { get; set; }
        public string İsitmaKapasitesi { get; set; }
        public string SogutmaVerimliligi { get; set; }
        public string İsitmaVerimliligi { get; set; }
        public string İcUniteSesBasinci { get; set; }
        public string YillikKullanimGuc { get; set; }
        public string ResimLink { get; set; }
    }
}
