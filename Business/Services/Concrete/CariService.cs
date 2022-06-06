using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public void Add(Telefon telefon)
        {
            _cariRepository.Add(telefon);
        }

        public void Add(Cari cari)
        {
            _cariRepository.Add(cari);
        }

        public object AddCari(CariVM cariVM)  //ekleme sırasında string telefon nesnesinin dönüştürülmesi
        {
            List<Telefon> telefons = new List<Telefon>(); //telefon nesnesi alan liste
            List<Adres> adres = new List<Adres>();
            foreach (var item in cariVM.Adres) 
            {
                adres.Add(new Adres { AdresAcıklama = item, CariId = cariVM.CariId }); 
            }
            foreach (var item in cariVM.telefons)
            {
                telefons.Add(new Telefon { TelefonNo = item, CariId = cariVM.CariId });
            }
            Cari cari = new Cari()
            {
                
                Unvan = cariVM.Unvan,
                Telefonlar = telefons,
                Adresler = adres


            };
            return _cariRepository.AddCari(cari);
        }

        public int Delete(int id)
        {
            Cari cari = _cariRepository.Get(id);
            return _cariRepository.DeleteCari(cari);
        }

        public Cari Get(Expression<Func<Cari, bool>> filter = null)
        {
            return _cariRepository.Get(filter);
        }

        public List<Cari> GetListCari()
        {
            return _cariRepository.ToList();
        }

        public void Update(Cari name)
        {
            _cariRepository.Update(name);
        }
    }
}
