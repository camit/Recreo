using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportProcess.StructData
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    public class CountryCSVData
    {
        
        public int CountryID;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string CountryCode;
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string CountryName;
    }
}
