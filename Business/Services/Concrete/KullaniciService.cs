using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.KullaniciVM;

namespace Business.Services.Concrete
{
    public class KullaniciService : IKullaniciService
    {
        private IKullaniciRepository _kullaniciRepository;

        public KullaniciService(IKullaniciRepository kullaniciRepository) 
        {
            _kullaniciRepository = kullaniciRepository;
        }

        public Kullanici CheckLogin(LoginVM loginVM)
        {            
            
         Kullanici kullanici =  _kullaniciRepository.CheckLogin(loginVM.Email, loginVM.Password);
            if (kullanici!= null)
            {
                return kullanici;
            }
            return null;
            
        }
    }
}
