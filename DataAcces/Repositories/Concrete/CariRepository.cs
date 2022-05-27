using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Repositories.Concrete
{
    public class CariRepository : ICariRepository
    {
        public readonly KKContext _context;

        public CariRepository(KKContext context)
        {
           _context = context;
        }

        public int DeleteCari(Cari cari)
        {
            _context.Cari.Remove(cari);
            //db tarafında save change yapılacak
            return _context.SaveChanges();
        }

        public Cari Get(int id)
        {
            return _context.Cari.Where(a => a.CariId == id).SingleOrDefault();
        }

        public List<Cari> ToList()
        {
            return _context.Cari.Include(c=>c.Telefonlar).Include(c=>c.Adresler).ToList();
        }
    }
}
