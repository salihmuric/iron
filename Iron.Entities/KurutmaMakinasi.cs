using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class KurutmaMakinasi : IEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string EnerjiSinifi { get; set; }
        public string KurutmaKapasitesi { get; set; }
        public string KurutmaSesi { get; set; }
        public string KurutmaTeknolojisi { get; set; }
        public string CocukKilidi { get; set; }
        public string KalanSureGostergesi { get; set; }
        public string ResimLink { get; set; }
	}
}
