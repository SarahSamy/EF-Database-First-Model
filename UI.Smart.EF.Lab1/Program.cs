using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.BLL;
using UI.Smart.EF.BLL.Managers;

namespace UI.Smart.EF.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {App_Start.EntityFrameworkProfilerBootstrapper.PreStart();
            // CityManager cityManager = new CityManager(new Entities1());

            UnitOfWork unitofwork = UnitOfWork.Create();
            unitofwork.countryManager.Add(new Country { Name = "KSA" });
           
        }
    }
}

