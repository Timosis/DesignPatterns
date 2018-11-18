using System;

namespace Observer
{
    class Workstation
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            MobileDevice mobileDevice = new MobileDevice(weatherData);
            ComputerDevice computerDevice = new ComputerDevice(weatherData);
            TelevisionDevice televisionDevice = new TelevisionDevice(weatherData);
            SomeAnotherDevice someAnotherDevice = new SomeAnotherDevice(weatherData);

            weatherData.SetMeasurementChanged(11, 23, 41);



        }
    }
}
