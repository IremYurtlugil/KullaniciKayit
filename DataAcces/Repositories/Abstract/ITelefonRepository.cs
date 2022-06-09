using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Repositories.Abstract
{
    public interface ITelefonRepository
    {
        List<Telefon> GetList(Expression<Func<Telefon, bool>> filter = null);
        void Delete(Telefon telefon);
        void Add(Telefon telefon);
        Telefon GetById(Expression<Func<Telefon, bool>> filter);
    }
}
