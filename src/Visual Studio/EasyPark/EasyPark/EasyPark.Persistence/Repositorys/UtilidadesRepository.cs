using EasyPark.EasyPark.Domain.Entitys;
using EasyPark.EasyPark.Domain.Interface.Repositorys;
using EasyPark.EasyPark.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyPark.EasyPark.Persistence.Repositorys
{
    public class UtilidadesRepository: IUtilidadesRepository
    {
        private EasyParkContext _easyParkContext;

        public UtilidadesRepository(EasyParkContext easyParkContext)
        {
            _easyParkContext = easyParkContext;
        }

        public List<Estado> GetEstados()
        {
            return _easyParkContext.Estados.ToList();
        }
    }
}
