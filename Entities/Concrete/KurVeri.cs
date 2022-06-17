using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class KurVeri
    {
        public int KurId { get; set; }
        public int Birim { get; set; }
        public decimal DovizKodu { get; set; }
        public decimal DovizCinsi { get; set; }
        public decimal DovizAlis { get; set; }
        public decimal DovizSatis { get; set; }
        public decimal EfektifAlıs { get; set; }
        public decimal EfektifSatis { get; set; }
    }
}
