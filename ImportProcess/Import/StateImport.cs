using DataAccess.Recreo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportProcess
{
    public class StateImport : Import<StateCSVData>
    {
        public override List<StateCSVData> GetExcelRecords()
        {
            var csvdata = Parser<StateCSVData>.ParseToList(@"E:\Amit\test\Recreo\Recreo\ImportProcess\SeedData\statescsv.csv").ToList();
            return (List<StateCSVData>)csvdata;
        }


        public override string SaveData()
        {
            string response = "Data Saved Successfully";
            try
            {
                var resultToProcess = Parser<StateCSVData>.ParseToList(@"E:\Amit\test\Recreo\Recreo\ImportProcess\SeedData\statescsv.csv").ToList();
                foreach (StateCSVData unitResult in resultToProcess)
                {
                    using (RecreoEntities _entities = new RecreoEntities())
                    {
                        var statedata = new state()
                        {
                            countrycode = unitResult.CountryCode,
                            statename = unitResult.StateName,
                            statecode=unitResult.StateCode

                        };
                        _entities.AddTostates(statedata);
                        _entities.SaveChanges();

                    }

                }


            }
            catch (Exception ex)
            {
                response = ex.Message.ToString();

            }

            return response;

        }
    }
}
