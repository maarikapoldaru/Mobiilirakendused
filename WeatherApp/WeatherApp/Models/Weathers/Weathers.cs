//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using System;
using System.Collections.Generic;
//using System.Threading.Tasks;
using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;

namespace WeatherApp.Models.Weathers
{
    public class Weathers
    {

        private IList<Weather> _weatherList;
        public IList<Weather> WeatherList
        {
            get
            {
                return _weatherList = WeatherList;
                if (_weatherList == null)
                {
                    _weatherList = new ObservableCollection<Weather>();
                    return _weatherList = WeatherList; ;
                }
            }
            set => _weatherList = value;

        }
    }
}

