using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Telefon
    {
        public long TelefonId { get; set; }
        public string TelefonNo { get; set; }

        public long CariId { get; set; }
        public Cari  cari { get; set; }
    }
}
