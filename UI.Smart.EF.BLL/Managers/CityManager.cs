using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.Repository;

namespace UI.Smart.EF.BLL.Managers
{
    public class CityManager : Repository<City1, Entities1>
    {
        public CityManager(Entities1 context) : base(context)
        {
        }
    }
}
