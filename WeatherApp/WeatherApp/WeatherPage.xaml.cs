﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeatherApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage(City city)
        {
            InitializeComponent();

            //SetBinding(WeatherPage.TitleProperty, new Binding(city.Name);
            //cityName.Text = city.Name;
        }
    }
}