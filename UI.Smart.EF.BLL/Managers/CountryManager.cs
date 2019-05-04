using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Smart.EF.Repository;

namespace UI.Smart.EF.BLL.Managers
{
    public class CountryManager : Repository<Country, Entities1>
    {
        public CountryManager(Entities1 context) : base(context)
        {
        }
    }
}
