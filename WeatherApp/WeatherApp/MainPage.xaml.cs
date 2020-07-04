using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public static List<City> cities = new List<City>
        {
            new City("Moscow", 15.5, 63, 5),
            new City("Novosibirsk", 23.0, 65, 3),
            new City("Tomsk", 25.1, 70, 6)
        };

        public MainPage()
        {
            InitializeComponent();
            cityChoice.ItemsSource = cities;
        }

        private async void cityChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeatherPage((City)cityChoice.SelectedItem));
        }
    }
}
