using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Services.Abstract
{
    public interface IKurVeriService
    {
        List<KurVeri> GetList(Expression<Func<KurVeri, bool>> filter = null);
    }
}
