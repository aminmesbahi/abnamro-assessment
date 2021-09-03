using Assessment.Api.Controllers;
using Assessment.Api.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Assessment.Api.Test
{
    public class CalculationControllerTest 
    {
        [Fact]
        public void StartCalculation_GetAll_Returns3()
        {
            var calculation=new CalculationServiceFake();
            var result = calculation.GetCalculationList();

            Assert.Equal(3, result.Count);
        }

    }
}
