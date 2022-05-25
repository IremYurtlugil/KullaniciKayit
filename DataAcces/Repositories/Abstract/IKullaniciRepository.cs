using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Repositories.Abstract
{
    public interface IKullaniciRepository
    {
        Kullanici CheckLogin(string email, string password);
    }
}
