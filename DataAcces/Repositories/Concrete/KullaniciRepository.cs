using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Repositories.Concrete
{
    public class KullaniciRepository : IKullaniciRepository
    {
       private KKContext _dbContext;

        public KullaniciRepository(KKContext dbContext)
        {
          _dbContext = dbContext;
        }

    }
}
