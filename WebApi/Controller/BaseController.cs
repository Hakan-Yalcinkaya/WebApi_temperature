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

        [HttpGet]
        public IActionResult Index()
        {
            UserModel user = new UserModel();
            user.Firstname = "Hakan";
            user.Lastname = "Yalçınkaya";


            var jsonData = JsonConvert.SerializeObject(user);
            return Ok(jsonData);
        }

        [HttpGet]
        [Route("/temperature")]
        public async Task<IActionResult> Temperature(string city)
        {
            Manager mng = new Manager();
            int number;
            if (int.TryParse(city, out number)) return BadRequest();

            await mng.GetWeather(city);

            return Ok();
        }


    }
}
