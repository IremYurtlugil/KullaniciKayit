using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Repositories.Concrete
{
   public class AdresRepository : IAdresRepository
    {
        private readonly KKContext _context;

        public AdresRepository(KKContext context)
        {
            _context = context;
        }

        public void Add(Adres adres)
        {
            _context.Adres.Add(adres);
            _context.SaveChanges();
        }

        public void Delete(Adres adres)
        {
            _context.Adres.Remove(adres);
            _context.SaveChanges();
        }

        public IEnumerable<Adres> GetList(Expression<Func<Adres, bool>> filter)
        {
            return _context.Adres.Where(filter).ToList();
        }

    }
}
