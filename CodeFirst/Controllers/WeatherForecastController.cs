using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CodeFirst.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly BloggingContext _bloggingContext;

        public WeatherForecastController(BloggingContext bloggingContext)
        {
            _bloggingContext = bloggingContext;
            var sql = _bloggingContext.GetService<IMigrator>().GenerateScript();
            Console.WriteLine(sql);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
