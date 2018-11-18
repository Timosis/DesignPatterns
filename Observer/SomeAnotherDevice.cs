using System;
namespace Observer
{
    public class SomeAnotherDevice : IObserver,IDisplay
    {
        private float temperature { get; set; }
        private float humuditiy { get; set; }
        private float pressure { get; set; }
        private WeatherData weatherdata;

        public SomeAnotherDevice(WeatherData weatherdata)
        {
            this.weatherdata = weatherdata;
            this.weatherdata.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("SomeAnotherDevice");
            Console.WriteLine("Temperature:{0},Humudity:{1},Pressure:{2}\n", temperature, humuditiy, pressure);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humuditiy = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}
