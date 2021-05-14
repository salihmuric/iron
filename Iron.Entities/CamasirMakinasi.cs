using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class CamasirMakinasi : IEntity
    {
		public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string KullanimTipi { get; set; }
        public string YikamaKapasitesi { get; set; }
        public string MaxSikmaDeviri { get; set; }
        public string Kurutma { get; set; }
        public string EnerjiSinifi { get; set; }
        public string YillikEnerjiTuketimi { get; set; }
        public string YillikSuTuketimi { get; set; }
        public string ResimLink { get; set; }
	}
}
