using DataAccess.Recreo;
using ImportProcess.StructData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportProcess
{
    public class CountryImport : Import<CountryCSVData>
    {
        public override List<CountryCSVData> GetExcelRecords()
        {
            var csvdata = Parser<CountryCSVData>.ParseToList(@"E:\Amit\test\Recreo\Recreo\ImportProcess\SeedData\countrycsv.csv").ToList();
            return (List<CountryCSVData>)csvdata;
        }


        public override string SaveData()
        {
            string response = "Data Saved Successfully";
            try
            {
               var  resultToProcess = Parser<CountryCSVData>.ParseToList(@"E:\Amit\test\Recreo\Recreo\ImportProcess\SeedData\countrycsv.csv").ToList();
                foreach (CountryCSVData unitResult in resultToProcess)
                {
                    using (RecreoEntities _entities = new RecreoEntities())
                    {
                        var countrydata = new country()
                        {
                            countrycode = unitResult.CountryCode,
                            countryname = unitResult.CountryName

                        };
                        _entities.AddTocountries(countrydata);
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
