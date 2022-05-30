using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Repositories.Abstract
{
   public interface ICariRepository
    {
        List<Cari> ToList();
        Cari Get(int id);
        int DeleteCari(Cari cari);
        object AddCari(Cari cari);
    }
}
