using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Data
{
    public class Manager
    {

        public async Task<TemperatureModel> GetWeather(string city)
        {
            try
            {
                string url = $@"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=7de70b6f2623ea4a8bd0177dcefeb5ad";
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                var contents = await response.Content.ReadAsStringAsync();

                JObject json = JObject.Parse(contents);
                TemperatureModel temperature = JsonConvert.DeserializeObject<TemperatureModel>(json["main"].ToString());

                return temperature;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;

                //log
            }

        }


        public UserModel GetUser()
        {
            UserModel user = new UserModel();
            user.Firstname = "Hakan";
            user.Lastname = "Yalçınkaya";

            return user;
        }

    }
}
