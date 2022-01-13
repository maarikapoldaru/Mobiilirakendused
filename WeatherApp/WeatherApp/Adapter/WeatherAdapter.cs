using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
using Android.Views;
using Android.Widget;
//using System;
using System.Collections.Generic;
//using System.Runtime.Serialization;
//using System.Linq;
//using System.Text;
//using WeatherApp.Models;
//using System.Runtime.Serialization;

namespace WeatherApp
{

    public class WeatherAdapter : BaseAdapter<Models.WeatherInfo5.List>
    {
        //WeatherAdapter WeatherAdapter.adapter = new Adapter();
        public List<Models.WeatherInfo5.List> _items;
        public Activity _context;
        public WeatherAdapter(Activity context, List<Models.WeatherInfo5.List> items)
        {
            _items = items;
            _context = context;
        }


        public override Models.WeatherInfo5.List this[int position] => _items[position];
        /*{
             get { return _items[position]; }
        }*/

        public override int Count => _items.Count;
        /* {
            get { return _items.Count; }
         }*/

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
            {
#pragma warning disable IDE0059 // Unnecessary assignment of a value
                view = _context.LayoutInflater.Inflate(Resource.Layout.row, null);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
            }
            view.FindViewById<TextView>(Resource.Id.weatherTime).Text = _items[position].dt_txt.ToString();
            view.FindViewById<TextView>(Resource.Id.temperatureTextView1).Text = _items[position].main.temp.ToString() + " Celsius";
            view.FindViewById<TextView>(Resource.Id.windTextView1).Text = _items[position].wind.speed.ToString() + " m/s";
            view.FindViewById<TextView>(Resource.Id.descriptionTextView1).Text = _items[position].weather[0].description;

            return view;
        }
    }
}

