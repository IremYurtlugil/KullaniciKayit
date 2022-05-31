using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Repositories.Abstract
{
    public interface IAdresRepository
    {
        IEnumerable<Adres> GetList(Expression<Func<Adres, bool>> filter);
        void Delete(Adres adres);
        void Add(Adres adres);
    }
}
