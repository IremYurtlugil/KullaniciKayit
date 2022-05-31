using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Services.Abstract
{
    public interface IAdresService
    {
        IEnumerable<Adres> GetList(Expression<Func<Adres, bool>> filter = null);
        void Delete(Adres adres);
        void Add(Adres adres);
    }
}
