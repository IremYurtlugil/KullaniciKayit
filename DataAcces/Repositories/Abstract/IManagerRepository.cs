using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Repositories.Abstract
{
    public interface IManagerRepository
    {
        List<User> GetList();
    }
}
