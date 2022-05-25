using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Repositories.Concrete
{
    public class ManagerRepository : IManagerRepository
    {
       private KKContext _dbContext;

        public ManagerRepository(KKContext dbContext)
        {
          _dbContext = dbContext;
        }

        public List<User> GetList()
        {
            return _dbContext.users.ToList();
        }
    }
}
