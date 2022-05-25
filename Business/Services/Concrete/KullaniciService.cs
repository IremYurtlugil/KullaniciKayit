using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Concrete
{
    public class KullaniciService : IKullaniciService
    {
        private IKullaniciRepository _managerRepository;

        public KullaniciService(IKullaniciRepository managerRepository) 
        {
            _managerRepository = managerRepository;
        }

      
    }
}
