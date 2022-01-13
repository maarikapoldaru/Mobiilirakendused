//using Android.App;
////using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
using System;
//using System.Collections.Generic;
//using System.Text;


namespace WeatherApp
{
    public class Weather
    {
        //[PrimaryKey, AutoIncrement, Column("_id")]
        public string Manufactorer { get; set; }
        public int Id { get; set; }
        public string City/*EditText*/{ get; set; }
        //public string Content { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public int Temperature { get; set; }
        public int Windspeed { get; set; }
        public string Description { get; set; }

    }
}
