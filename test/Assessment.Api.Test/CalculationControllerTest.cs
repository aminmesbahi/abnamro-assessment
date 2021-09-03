using Assessment.Api.Controllers;
using Assessment.Api.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
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

        [Fact]
        public void Calculate_GetCalculationStatus_SpecificCalculation_ReturnsFalse()
        {
            var calculation = new CalculationServiceFake();
            var result = calculation.Calculate(new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c100"), "", new CancellationToken());

            Assert.Equal("False", result.IsCompleted.ToString());
        }

    }
}
