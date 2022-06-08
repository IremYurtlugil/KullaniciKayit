using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ViewModels.CariVM;

namespace Business.Services.Abstract
{
    public interface ITelefonService
    {
        List<Telefon> GetList(Expression<Func<Telefon, bool>> filter = null);
        void Delete(Telefon telefon);
        void Add(Telefon telefon);
    }
}
