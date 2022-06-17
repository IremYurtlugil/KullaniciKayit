using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Repositories.Abstract
{
    public interface IKurVeriRepository
    {
        List<KurVeri> GetList(Expression<Func<KurVeri, bool>> filter);
    }
}
