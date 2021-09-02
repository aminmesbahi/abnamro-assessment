using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Web.Models
{
    public class CalculationRequestModel
    {
        [BindProperty]
        [Required]
        [Range(10,99)]
        public int RequestValue { get; set; }

        public string ConId { get; set; }
    }
}
