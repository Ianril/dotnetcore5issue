using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var contentTypeWithoutName = new ContentType("application/json");
            var contentTypeWithName = new ContentType("application/json") { Name = "test" };

            var withoutName = TryValidateModel(contentTypeWithoutName);
            ModelState.Clear();
            var withName = TryValidateModel(contentTypeWithName);

            return @"";
        }
    }
}
