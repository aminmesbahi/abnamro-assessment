using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Web.Models
{
    public class AppSettings
    {
        public string AssessmentApiBaseUri { get; set; }
        public string StartCalculationUri { get; set; }
        public string GetStatusUri { get; set; }
    }
}
