using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Services.Concrete
{
   public class AdresService : IAdresService
    {
        public IAdresRepository _adresRepository;

        public AdresService(IAdresRepository adresRepository)
        {
            _adresRepository = adresRepository;
        }

        public void Add(Adres adres)
        {
            _adresRepository.Add(adres);
        }

        public void Delete(Adres adres)
        {
            _adresRepository.Delete(adres);
        }

        public IEnumerable<Adres> GetList(Expression<Func<Adres, bool>> filter = null)
        {
            return _adresRepository.GetList(filter);
        }
    }
}
