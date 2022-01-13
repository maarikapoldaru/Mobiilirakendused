//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using Nest;
using Newtonsoft.Json;
using System.Collections.Generic;
//using System;
//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
//using WeatherApp.Models;
using WeatherApp.Models.WeatherInfo;
using WeatherApp.Models.WeatherInfo5;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        public const string ApiKey = "a519d2565f58343b5f157d056e658aca";
        // private static string BASE_URL;

        public async Task<WeatherInfo> GetCityWeather(string city)
        {
            //try
            //{
            HttpClient client = new HttpClient();
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=a519d2565f58343b5f157d056e658aca";
            string response = await client.GetStringAsync(url);
            WeatherInfo data = JsonConvert.DeserializeObject<WeatherInfo>(response);
            return data;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

        }
        public async Task<List<List>> GetCityWeather5(string city)
        {
            //try
            //{
            HttpClient client = new HttpClient();
            string url = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&appid=a519d2565f58343b5f157d056e658aca";
            string response = await client.GetStringAsync(url);
            WeatherInfo5 data = JsonConvert.DeserializeObject<WeatherInfo5>(response);

            return data.list;
        }
        public async Task<byte[]> GetImageFromUrl(string url)
        {
#pragma warning disable IDE0063 // Use simple 'using' statement
            using (HttpClient Client = new HttpClient())
#pragma warning restore IDE0063 // Use simple 'using' statement
            {
                HttpResponseMessage msg = await Client.GetAsync(url);


                if (msg.IsSuccessStatusCode)
                {
                    byte[] byteArray = await msg.Content.ReadAsByteArrayAsync();
                    return byteArray;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}



