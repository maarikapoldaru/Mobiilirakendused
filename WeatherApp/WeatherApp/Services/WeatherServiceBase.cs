////using Android.App;
////using Android.Content;
////using Android.OS;
////using Android.Runtime;
////using Android.Views;
////using Android.Widget;
//namespace WeatherApp.Services
//{
//    public class WeatherServiceBase
//    {
//        //"04d22bda94c31287ebd9f280981489e4";
//        public static async Task<WeatherInfo> GetWeatherInfosync(double lat, double lon, string units)
//        {
//            //Client = new HttpClient();
//            _ = new WeatherInfo();
//            string url = string.Format(BASE_URL, lat, lon, units, OPENWEATHERMAP_API_KEY);
//            HttpClient httpClient = new HttpClient();
//            HttpResponseMessage response = await httpClient.GetAsync(url);
//            if (response.IsSuccessStatusCode)
//            {
//                string content = await response.Content.ReadAsStringAsync();
//                WeatherInfo data = JsonConvert.DeserializeObject<WeatherInfo>(content);
//                return data;
//            }
//        }
//    }
//}