using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcces.Repositories.Concrete
{
   public class KurVeriRepository: IKurVeriRepository
    {
        private readonly KKContext _context;

        public KurVeriRepository(KKContext context)
        {
            _context = context;
        }

        public List<KurVeri> GetList(Expression<Func<KurVeri, bool>> filter)
        {
            return _context.KurVeris.Where(filter).ToList();
        }
    }
}
