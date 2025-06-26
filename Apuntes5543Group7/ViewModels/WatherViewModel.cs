using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Apuntes5543Group7.Repositories;
using static Apuntes5543Group7.Models.WeatherModels;

namespace Apuntes5543Group7.ViewModels
{
    internal class WeatherViewModel : INotifyPropertyChanged
    {
        private WeatherData _weatherData = new WeatherData();

        public WeatherData WeatherDataInfo
        {
            get => _weatherData;
            set
            {
                if (_weatherData != value)
                {
                    _weatherData = value;
                    OnPropertyChanged();
                }
            }
        }

        public WeatherViewModel()
        {
            GetCurrentWeatherData();
        }

        public async void GetCurrentWeatherData()
        {
            WeatherRepository weatherRepository = new WeatherRepository();
            WeatherDataInfo = await weatherRepository.GetCurrentLocationWeatherData();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}