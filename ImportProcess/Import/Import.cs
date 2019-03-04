using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportProcess
{
    public abstract class Import<T> : IImport
    {

        public abstract List<T> GetExcelRecords();

        public virtual string SaveData()
        {
            // Default Save Data Method for IOC purpose
            throw new NotImplementedException();
        }
    }
}
