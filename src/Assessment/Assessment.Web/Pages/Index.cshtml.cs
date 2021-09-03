using Assessment.Web.Data;
using Assessment.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;
        private readonly AssessmentContext _context;
        private readonly MvcOptions _mvcOptions;


       // public IList<CalculationHistory> calculationHistories { get; set; }

  
        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)//AssessmentContext context, IOptions<MvcOptions> mvcOptions)
        {
            _logger = logger;
            _configuration = configuration;
            /*
             _context = context;
            _mvcOptions = mvcOptions.Value;
            */
        }

        public void OnGet()
        {
          //  hostories = await _context.CalculationHistories.Take(
            //    _mvcOptions.MaxModelBindingCollectionSize).ToListAsync();
        }
        public async Task<IActionResult> OnPostStartCalculationAsync(CalculationRequestModel model)
        {
            if (ModelState.IsValid)
            {
                // do something
                System.Diagnostics.Debug.WriteLine($"number {model.RequestValue}");
                var settings = _configuration.GetSection("AppSettings").Get<AppSettings>();
                
                var baseUri = settings.AssessmentApiBaseUri;
                var startCalculationUri = settings.StartCalculationUri;
                var uri = new Uri(baseUri+ startCalculationUri);

                var client = new HttpClient();
                var response = await client.PostAsync(uri.ToString(), new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json"));
                var responseContent = "";
                if (response.IsSuccessStatusCode)
                {
                    responseContent = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(responseContent);
                }
                
                
                return Content(responseContent);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("not number");
                return Page();
            }
        }
        public async Task<IActionResult> OnPostGetStatusAsync(GetStatusRequestModel model)
        {
            var settings = _configuration.GetSection("AppSettings").Get<AppSettings>();

            var baseUri = settings.AssessmentApiBaseUri;
            var getStatusUriUri = settings.GetStatusUri;
            var uri = new Uri(baseUri + getStatusUriUri);

            var client = new HttpClient();
            var payload = "{\"returnedHandler\":\"" + model.ReturnedHandler+"\"}";
            var response = await client.PostAsync(uri.ToString(), new StringContent(payload, Encoding.UTF8, "application/json"));
            var responseContent = "";
                if (response.IsSuccessStatusCode)
                {
                    responseContent = await response.Content.ReadAsStringAsync();
                    System.Diagnostics.Debug.WriteLine(responseContent);
                }


                return Content(responseContent);
            }
        }
    }

