using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Repositories.Concrete
{
    
   public class TelefonRepository : ITelefonRepository
    {
        private readonly KKContext _context;

        public TelefonRepository(KKContext context)
        {
            _context = context;
        }

        public void Add(Telefon telefon)
        {
            _context.Telefon.Add(telefon);
            _context.SaveChanges();
        }

        public void Delete(Telefon telefon)
        {
            var updateDelete = _context.Entry(telefon);
            updateDelete.State = EntityState.Modified;
            _context.SaveChanges();
            //_context.Telefon.Remove(telefon);
            //_context.SaveChanges();

        }

        public List<Telefon> GetList(Expression<Func<Telefon, bool>> filter = null)
        {
            return _context.Telefon.Where(filter).ToList();
        }
    }
}
