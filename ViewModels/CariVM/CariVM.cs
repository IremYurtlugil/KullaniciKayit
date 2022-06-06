using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.CariVM
{
   public class CariVM
    {
        public long CariId { get; set; }
        public string Unvan { get; set; }
       public List<string> telefons { get; set; }
      public  List<string> Adres { get; set; }
    }
}
