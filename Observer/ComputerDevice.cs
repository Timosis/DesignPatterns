using System;
namespace Observer
{
    public class ComputerDevice : IObserver ,IDisplay
    {
        private float temperature { get; set; }
        private float humidity { get; set; }
        private float pressure { get; set; }
        private WeatherData weatherdata;

        public ComputerDevice(WeatherData weatherdata)
        {
            this.weatherdata = weatherdata;
            this.weatherdata.AddObserver(this);
        }

        public void Display()
        {

            Console.WriteLine("Computer Device");
            Console.WriteLine("Temperature:{0},Humidity:{1},Pressure:{2}\n", temperature, humidity, pressure);
        
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
