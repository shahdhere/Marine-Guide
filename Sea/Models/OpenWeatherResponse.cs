using System.Text.Json.Serialization;

namespace Sea.Models
{
    public class OpenWeatherResponse
    {
        public Main main { get; set; }
        public Wind wind { get; set; }
        public int visibility { get; set; }
        public RainData rain { get; set; }
    }
    public class Main
    {
        public double temp { get; set; }
    }
    public class Wind
    {
        public double speed { get; set; }
    }
    public class RainData
    {
        [JsonPropertyName("1h")]
        public double OneHour { get; set; }
    }
}
