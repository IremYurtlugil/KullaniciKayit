using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Xml;

namespace Business.Services.Concrete
{
    public class KurVeriService : IKurVeriService
    {
        private  IKurVeriRepository _kurVeriRepository;

        public KurVeriService(IKurVeriRepository kurVeriRepository)
        {
            _kurVeriRepository = kurVeriRepository;
        }

        public List<KurVeri> GetList(Expression<Func<KurVeri, bool>> filter = null)
        {
            return _kurVeriRepository.GetList(filter);
        }
    }
}
