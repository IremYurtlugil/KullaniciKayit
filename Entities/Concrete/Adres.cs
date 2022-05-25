using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Adres
    {
        public long AdresId { get; set; }
        public string AdresAcıklama { get; set; }

        public long CariId { get; set; }
        public Cari cari { get; set; }
    }
}
