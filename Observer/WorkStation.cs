using System;

namespace Observer
{
    class Workstation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            MobileDevice mobileDevice = new MobileDevice(weatherData);

            weatherData.SetMeasurementChanged(11, 23, 41);



        }
    }
}
