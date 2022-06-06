using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ViewModels.CariVM;
using ViewModels.KullaniciVM;

namespace Business.Services.Abstract
{
    public interface ICariService
    {
        List<Cari> GetListCari();
        int Delete(int id);
        object AddCari(CariVM cariVM);
        Cari Get(Expression<Func<Cari, bool>>filter = null);
        void Update(Cari name);
        void Add(Telefon telefon);
        void Add(Cari cari);
    }
}
