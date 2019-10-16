using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using homeapp2.Shared;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using static System.Net.WebRequestMethods;

namespace homeapp2.Server.Controllers
{
    public class SmhiController : ControllerBase
    {
        private readonly ILogger<SmhiController> logger;

        public SmhiController(ILogger<SmhiController> logger)
        {
            this.logger = logger;
        }

        //[HttpGet]
        //public async Task<IEnumerable<SmhiResponse>> GetAsync()
        //{
            //forecasts = await Http.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
            //var endpoint = "https://opendata-download-metfcst.smhi.se/api/category/pmp3g/version/2/geotype/point/lon/16.158/lat/58.5812/data.json";
            //_weather = await Http.GetJsonAsync<Weather>(endpoint);
        //}
    }
}
