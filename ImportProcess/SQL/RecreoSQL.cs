using DataAccess.Recreo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportProcess
{
    public class RecreoSQL
    {
        RecreoEntities _entities = new RecreoEntities();
        public List<string> GetListOfCountries()
        {
            //LINQ query for SQL
            var countrylist = (from c in _entities.countries
                               select c.countryname
                             ).ToList();
            return countrylist;

        }

    }
}
