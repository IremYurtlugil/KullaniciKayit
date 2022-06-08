using Business.Services.Abstract;
using DataAcces.Repositories.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ViewModels.CariVM;

namespace Business.Services.Concrete
{
    public class TelefonService : ITelefonService

    {
        public readonly ITelefonRepository _telRepository;

        public TelefonService(ITelefonRepository telRepository)
        {
            _telRepository = telRepository;
        }

        public void Add(Telefon telefon)
        {
            _telRepository.Add(telefon);
        }

        public void Delete(Telefon telefon)
        {
           _telRepository.Delete(telefon);
        }

        public List<Telefon> GetList(Expression<Func<Telefon, bool>> filter = null)
        {
            return _telRepository.GetList(filter);
        }
    }
}
