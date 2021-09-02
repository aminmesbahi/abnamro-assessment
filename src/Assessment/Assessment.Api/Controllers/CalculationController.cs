using Assessment.Api.Models;
using Assessment.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Assessment.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class CalculationController : ControllerBase
    {
        private readonly ILogger<CalculationController> _logger;
        private readonly ICalculationService _calculation;
        private readonly ChannelService<Calculation> _channelService;
        public CalculationController(ILogger<CalculationController> logger, ICalculationService calculation, ChannelService<Calculation> channelService)
        {
            _logger = logger;
            _calculation = calculation;
            _channelService = channelService;
        }

        [HttpGet]
        public IEnumerable<Calculation> GetAll()
        {
            return _calculation.GetCalculationList();
        }

        [HttpPost]
        public async Task<string> StartCalculation(int value,CancellationToken cancellationToken)
        {
            var id = _calculation.CreateNew();
            var calc = _calculation.Calculations.Where(c => c.Id == id).FirstOrDefault();
            await _channelService.Add(calc, cancellationToken);

            return id.ToString();
        }
        [HttpPost]
        public Status GetStatus([FromBody] GetStatusRequestModel model)
        {
            return _calculation.GetCalculationStatus(Guid.Parse(model.ReturnedHandler));
        }
    }
}