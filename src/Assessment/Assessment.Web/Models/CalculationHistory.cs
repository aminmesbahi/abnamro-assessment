using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Web.Models
{
    public class CalculationHistory
    {
            public int ID { get; set; }
            public string GuidHandler { get; set; }
            public string InputValue { get; set; }
            public int Result { get; set; }
             public DateTime CreatedDate {  get; set; }

    }
}

