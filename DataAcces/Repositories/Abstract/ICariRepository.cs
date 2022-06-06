using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Repositories.Abstract
{
   public interface ICariRepository
    {
        List<Cari> ToList();
        Cari Get(int id);
        int DeleteCari(Cari cari);
        object AddCari(Cari cari);
        Cari Get(Expression<Func<Cari, bool>> filter);
        void Update(Cari name);
        void Add(Telefon telefon);
        void Add(Cari cari);
    }
}
