using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class Televizyon : IEntity
    {
		public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Model { get; set; }
        public string EkranBoyut { get; set; }
        public string CozunurlukStandarti { get; set; }
        public string Ekran { get; set; }
        public string SesCikisGucu { get; set; }
        public string CıkısYili { get; set; }
        public string SmartTV { get; set; }
        public string EnerjiTuketimSinifi { get; set; }
        public string ResimLink { get; set; }
	}
}
