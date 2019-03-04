using System;
using ImportProcess;
using ImportProcess.StructData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RecreoUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetCountryCSVRecord()
        {
            var result= Parser<CountryCSVData>.ParseToList(@"E:\Amit\test\Recreo\Recreo\ImportProcess\SeedData\countrycsv.csv"); // Dependency Injection
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void GetStateCSVRecord()
        {
            var result = Parser<StateCSVData>.ParseToList(@"E:\Amit\test\Recreo\Recreo\ImportProcess\SeedData\statescsv.csv"); // Dependency Injection
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void SaveCountryCSVRecord()
        {
            var respose = new CountryImport().SaveData(); //IOC
            Assert.AreEqual("Data Saved Successfully", respose);

        }
        [TestMethod]
        public void SaveStateCSVRecord()
        {
            var respose = new StateImport().SaveData(); //IOC
            Assert.AreEqual("Data Saved Successfully", respose);

        }


        [TestMethod]
        public void GetCountryListFromDatabase()
        {
            var respose = new RecreoSQL().GetListOfCountries();
            Assert.AreNotEqual(0, respose.Count);

        }
    }
}
