
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Repositories.Concrete
{
    public class KullaniciRepository : IKullaniciRepository
    {
        private readonly KKContext _context;

        public KullaniciRepository(KKContext context)
        {
          _context = context;
        }

        public Kullanici CheckLogin(string email, string password)
        {
            return _context.Kullanici.SingleOrDefault(a => a.Password == password && a.Email == email);
           
        }
    }
}
