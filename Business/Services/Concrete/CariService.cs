using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.KullaniciVM;

namespace Business.Services.Concrete
{
    public class CariService : ICariService
    {
        public readonly ICariRepository _cariRepository;

        public CariService (ICariRepository cariRepository) 
        {
            _cariRepository = cariRepository;
        }

        public List<Cari> GetListCari()
        {
            return _cariRepository.ToList();
        }
    }
}
