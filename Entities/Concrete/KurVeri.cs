using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class KurVeri
    {
        public int KurId { get; set; }
        public int Birim { get; set; }
        public string DovizKodu { get; set; }
        public string  DovizCinsi{ get; set; }
        public string DovizAlis { get; set; }
        public string DovizSatis { get; set; }
        public string EfektifAlıs { get; set; }
        public string EfektifSatis { get; set; }
    }
}
