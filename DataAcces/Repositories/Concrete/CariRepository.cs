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
    public class CariRepository : ICariRepository
    {
        public readonly KKContext _context;

        public CariRepository(KKContext context)
        {
           _context = context;
        }

        public void Add(Telefon telefon)
        {
            _context.Telefon.Add(telefon);
            _context.SaveChanges();
        }

        public void Add(Cari cari)
        {
            _context.Cari.Add(cari);
            _context.SaveChanges();
        }

        public object AddCari(Cari cari)
        {
            _context.Cari.Add(cari);
            return _context.SaveChanges();
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

        public Cari Get(Expression<Func<Cari, bool>> filter)
        {
            return _context.Cari.SingleOrDefault(filter);
        }

        public List<Cari> ToList()
        {
            return _context.Cari.Include(c=>c.Telefonlar).Include(c=>c.Adresler).ToList();
        }

        public void Update(Cari name)
        {
            var updateEntity= _context.Cari.Update(name);
            updateEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
