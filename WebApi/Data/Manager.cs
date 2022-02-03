using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebApi.Data
{
    public class Manager
    {

        public async void GetWeather(string city)
        {
            string url = $@"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=7de70b6f2623ea4a8bd0177dcefeb5ad";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            var contents = await response.Content.ReadAsStringAsync();



        }

    }
}
