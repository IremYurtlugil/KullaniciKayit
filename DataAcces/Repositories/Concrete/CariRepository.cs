using DataAcces.Repositories.Abstract;
using Entities.Concrete;
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

        public List<Cari> ToList()
        {
            return _context.Cari.ToList();
        }
    }
}
