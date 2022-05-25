using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class Cari
    {
        public Cari() 
        {
            Telefonlar = new HashSet<Telefon>();
            Adresler = new HashSet<Adres>();
        }

        public long CariId { get; set; }
        public string Unvan { get; set; }

        public ICollection<Telefon> Telefonlar { get; set; }
        public ICollection<Adres> Adresler { get; set; }
    }
}
