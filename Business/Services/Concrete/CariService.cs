using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.CariVM;
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

        public object AddCari(CariVM cariVM, int id)
        {
            Cari cari = new Cari()
            {
                CariId = cariVM.CariId,
                Unvan = cariVM.Unvan,
                Telefonlar = cariVM.telefons,
                Adresler = cariVM.Adres

            };
            return _cariRepository.AddCari(cari);
        }

        public int Delete(int id)
        {
            Cari cari = _cariRepository.Get(id);
            return _cariRepository.DeleteCari(cari);
        }

        public List<Cari> GetListCari()
        {
            return _cariRepository.ToList();
        }
    }
}
