
namespace Sea.Models
{
    public class MarineWeatherDto
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }
        public double Visibility { get; set; }
        public double WaveHeight { get; set; }

        public string Status { get; set; }
        public List<string> Reasons { get; set; }
        public List<double> WindHistory { get; set; }

        public List<double> WaveHistory { get; set; }

        public List<double> TemperatureHistory { get; set; }
        public List<double> RainHistory { get; set; }
        public double WavePeriod { get; set; }

        public double Rain { get; set; }
        public double WindDirection { get; set; }


    }
}
