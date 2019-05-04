using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.BLL.Managers;

namespace UI.Smart.EF.BLL
{
  public  class UnitOfWork
    {
        private static Entities1 context = new Entities1();
        private static UnitOfWork unitofwork;
        private UnitOfWork()
        {

        }
        public static UnitOfWork Create()
        {
            if (unitofwork == null)
            {
                unitofwork = new UnitOfWork();
            }
            return unitofwork;
        }
        public CityManager cityManager {

            get
            {
                return new CityManager(context);
            }
        }

        public CountryManager countryManager
        {

            get
            {
                return new CountryManager(context);
            }
        }
    }
}
