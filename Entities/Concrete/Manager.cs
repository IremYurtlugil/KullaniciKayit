using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Manager
    {
        public Manager()
        {
            Users = new HashSet<User>();
        }
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
