using Assessment.Api.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Assessment.Api.Services
{
    public class CalculationWorker : BackgroundService
    {
        private readonly ChannelService<Calculation> _channelService;
        private readonly ILogger<CalculationWorker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public CalculationWorker(IServiceProvider serviceProvider, ILogger<CalculationWorker> logger,
            ChannelService<Calculation> channelService)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
            _channelService = channelService;
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
                try
                {
                    using var service = _serviceProvider.CreateScope();
                    var calculationService = service.ServiceProvider.GetRequiredService<ICalculationService>();

                    await foreach (var item in _channelService.Get(cancellationToken))
                    {
                        calculationService.Calculate(item.Id, cancellationToken);
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e, e.Message);
                }
        }
    }
}