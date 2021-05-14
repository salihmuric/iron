using Iron.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iron.Entities
{
    public class Laptop : IEntity
    {
		public int Id { get; set; }
        public string Marka { get; set; }
        public int Fiyat { get; set; }
        public string Model { get; set; }
        public string EkranBoyutu { get; set; }
        public string EkranCozunurlugu { get; set; }
        public string İslemciModeli { get; set; }
        public string Bellek { get; set; }
        public string İslemciSistemi { get; set; }
        public string GPUSerisi { get; set; }
        public string SabitDisk { get; set; }
        public string ResimLink { get; set; }
	}
}
