using System;
namespace Observer
{
    public class TelevisionDevice : IObserver ,IDisplay
    {
        private float temperature { get; set; }
        private float humidity { get; set; }
        private float pressure { get; set; }
        private WeatherData weatherdata;

        public TelevisionDevice(WeatherData weatherdata)
        {
            this.weatherdata = weatherdata;
            this.weatherdata.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Television Device\n");
            Console.WriteLine("Temperature:{0},Humditiy:{1},Pressure:{2}", temperature, humidity, pressure);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
