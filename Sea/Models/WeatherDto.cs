namespace Sea.Models
{
    public class WeatherDto
    {
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }

        public double Visibility { get; set; }
        public double Waves { get; set; }

        public string Status { get; set; }
        public string Message { get; set; }
        public List<string> Reasons { get; set; }
    }
}
