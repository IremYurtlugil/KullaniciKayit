using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
  public  class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone{ get; set; }
        public string Adress { get; set; }
    }
}
