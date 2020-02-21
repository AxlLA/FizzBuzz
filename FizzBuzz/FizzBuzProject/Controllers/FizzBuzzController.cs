using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Web.Http;
using FizzBuzProject.Models;
using System;

namespace FizzBuzProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {

        private IConfiguration configuration;

        public FizzBuzzController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }
        // GET
        [HttpGet("{numIntroducido}")]
        public async Task<string> Get(int numIntroducido)
        {

            FizzBuzz fizzBuzz = new FizzBuzz(configuration);
            return await Task.Run(() =>
            {
                return fizzBuzz.fizzBuzz(numIntroducido);
            });
        }

        public string Get2(int numIntroducido, int maxValue)
        {
            FizzBuzz fizzBuzz = new FizzBuzz(configuration);
            return fizzBuzz.fizzBuzz(numIntroducido);
        }

        // GET
        [HttpGet]
        public string Get()
        {
            return "Falta '/numero a la ruta'";
        }

    }
}