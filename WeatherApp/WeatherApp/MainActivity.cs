using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using WeatherApp.Services;
//using Android.Graphics;
using Android.Widget;
using WeatherApp.Models.WeatherInfo;
using Android.Graphics;
//using WeatherApp.Services;
//using System;
//using Android.Widget.ImageView;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            EditText _cityEditText;
            Button _searchButton;
            TextView _temperatureTextView;
            TextView _windTextView;
            TextView _temperatureTextView1;
            TextView _windTextView1;
            Button _searchButton1;
            ImageView _weatherImageView;
            ListView _listView;
            TextView _descriptionTextView1;
            TextView _temperatureTextView21;
            TextView _windTextView2;
            TextView _temperatureTextView3;
            TextView _windTextView3;
            TextView _temperatureTextView4;
            TextView _windTextView4;
            TextView _temperatureTextView5;
            TextView _windTextView5;
            TextView _descriptionTextView2;
            TextView _descriptionTextView3;
            TextView _descriptionTextView4;
            TextView _descriptionTextView5;
            Button searchButton1;


            SetContentView(Resource.Layout.activity_main);
            _cityEditText = FindViewById<EditText>(Resource.Id.cityEditText);
            _searchButton = FindViewById<Button>(Resource.Id.searchButton);
            _weatherImageView = FindViewById<ImageView>(Resource.Id.imageView);
            _temperatureTextView = FindViewById<TextView>(Resource.Id.temperatureTextView);
            _windTextView = FindViewById<TextView>(Resource.Id.windTextView);
            _listView = FindViewById<ListView>(Resource.Id.listView);
            _searchButton1 = FindViewById<Button>(Resource.Id.searchButton1);


            WeatherService weatherService = new WeatherService();

            _searchButton.Click += async delegate
            {
                WeatherInfo data = await weatherService.GetCityWeather(_cityEditText.Text);
                _temperatureTextView.Text = data.main.temp.ToString() + " Celsius";
                _windTextView.Text = data.wind.speed.ToString() + " m/s";

                byte[] imageBytes = await weatherService.GetImageFromUrl($"https://openweathermap.org/img/wn/{data.weather[0].icon}@2x.png");
                Bitmap bitmap = await BitmapFactory.DecodeByteArrayAsync(imageBytes, 0, imageBytes.Length);
                _weatherImageView.SetImageBitmap(bitmap);
            };

            _searchButton1.Click += async delegate
             {
                 System.Collections.Generic.List<Models.WeatherInfo5.List> weathers = await weatherService.GetCityWeather5(_cityEditText.Text);
                 WeatherAdapter weatherAdapter = new WeatherAdapter(this, weathers);
                 _listView.Adapter = weatherAdapter;
             };
        }
        //    protected override void OnPostCreate(Bundle savedInstanceState)
        //    {
        //        var weathers = GenerateWeathers();
        //        var weatherAdapter = new WeatherAdapter(this, weather);
        //        ListView Adapter = WeatherAdapter;
        //        WeatherService WeatherService = new WeatherService();
        //        Models.WeatherInfo data = await weatherService.GetCityWeather(cityEditText.Text);
        //        var data = WeatherService.GetCityWeather();
        //    }

        //    private List<Weather> GenerateWeathers();
        //    {
        //        var Weathers = new List<Weather>() {
        //        new Weather() {Manufactorer = "First_Day", ChangeDateTime , City, Description, Id, Temperature, Windspeed = int Weather.Windspeed{} };
        //        new Weather() { Manufactorer = "Second Day"};
        //        new Weather() { Manufactorer = "Third Day"};
        //        new Weather() { Manufactorer = "Fourth Day"};
        //        new Weather() { Manufactorer = "Fifth Day"};

        //};
        //        return Weather


        //    //private void searchButton1_Click()

        //    _searchButton1.Click += async delegate
        //     {
        //         WeatherInfo data = await weatherService.GetCityWeather(_cityEditText.Text);


        //         temperatureTextView.Text = data.Main.Temp.ToString();
        //         windTextView.Text = data.Wind.Speed.ToString();
        //         descriptionTextView.Text = data.Weather.Descripton.ToString();
        //     }
        /*var imageBytes = await weatherService.GetCityWeather().ImageFromUrl("")

        var bitmap = await BitmapFactory.DecodeByteArrayAsyncimageBytes(0, imageBytes.Length);
        byte[] imageBytes = await weatherService.GetImageFromUrl($"https://openweathermap.org/img/wn/{data.weather[0].icon}@2x.png");
        byte[] bitmap = (byte[])await BitmapFactory.DecodeByteArrayAsync(imageBytes, 0, imageBytes.Length);
        weatherImageView.SetImageBitmap((Bitmap)bitmap);
        };*/







        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}