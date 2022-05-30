using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.CariVM;
using ViewModels.KullaniciVM;

namespace Business.Services.Abstract
{
    public interface ICariService
    {
        List<Cari> GetListCari();
        int Delete(int id);
        object AddCari(CariVM cariVM, int id);
    }
}
