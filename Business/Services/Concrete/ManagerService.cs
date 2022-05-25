using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.Concrete
{
    public class ManagerService : IManagerService
    {
        private IManagerRepository _managerRepository;

        public ManagerService(IManagerRepository managerRepository) 
        {
            _managerRepository = managerRepository;
        }

        public List<User> GetAll()
        {
            return _managerRepository.GetList();
        }
    }
}
