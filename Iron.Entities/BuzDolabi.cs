using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class BuzDolabi : IEntity
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Model { get; set; }
        public string EnerjiSinifi { get; set; }
        public string SoğutmaSistemi { get; set; }
        public string YillikEnerjiTuketimi { get; set; }
        public string SesSeviyesi { get; set; }
        public string SogutucuNetHacim { get; set; }
        public string DondurucuNetHacim { get; set; }
        public string ToplamNetHacim { get; set; }
        public string ResimLink { get; set; }
        public string SogutmaSistemi { get; set; }
    }
}
