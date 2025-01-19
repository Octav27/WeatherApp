using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using WeatherApp.Services;

namespace WeatherApp.Models.ViewsModels
{
    internal partial class WeatherDataPageViewModel : ObservableObject
    {

        private readonly WeatherApiService _weatherSerivce;

        public WeatherDataPageViewModel()
        {
            _weatherSerivce = new WeatherApiService();
        }


   

        [ObservableProperty]
        private string location;

        [ObservableProperty]
        private string weatherIcon;
        [ObservableProperty]
        private string temperature;
        [ObservableProperty]
        private string weatherDescription;


        [RelayCommand]
        private async Task FetchWeatherInfo()
        {
            var weatherApiResponse = await _weatherSerivce.GetWeatherInfo("47.004903", "28.842076");
             Console.WriteLine("A fost activata functia");

            
            if (weatherApiResponse != null)
            {

                Console.WriteLine("Nu e null");

                WeatherIcon =  $"https://openweathermap.org/img/wn/{weatherApiResponse.List[0].Weather[0].Icon}.png";
                Temperature = $"{Convert.ToInt32(weatherApiResponse.List[0].Main.Temp)}°C";

                Location = $"{weatherApiResponse.City.Country}, {weatherApiResponse.City.Name}";
                WeatherDescription = weatherApiResponse.List[0].Weather[0].Main;
            }
        }
    }
}
