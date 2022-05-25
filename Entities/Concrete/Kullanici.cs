using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Kullanici
    {
        public long KullanciId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

       
    }
}
