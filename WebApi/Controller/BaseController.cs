using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Model;

namespace WebApi.Controller
{
    [Route("")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly Manager manager = new Manager();

        [HttpGet]
        public IActionResult Index()
        {
            Result<UserModel> resultData = new Result<UserModel>(manager.GetUser());
            var result = resultData.result();
          
            return Ok(result);
        }

        [HttpGet]
        [Route("/temperature")]
        public async Task<IActionResult> Temperature(string city)
        {
            Result<TemperatureModel> resultData = new Result<TemperatureModel>(await manager.GetWeather(city));
            var result = resultData.result(); 

            return Ok(result);
        }


    }
}
