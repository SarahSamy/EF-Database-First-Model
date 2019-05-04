using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Smart.EF.BLL
{
    public class CityBLL
    {
        Entities1 context = new Entities1();
        public List<City1> GetAll()
        {
            return context.Cities.ToList();
        }
    }
}
