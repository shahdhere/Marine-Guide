using Sea.Models;

namespace Sea.ViewModels
{
    public class ActivityViewModel
    {
        public string ActivityName { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public double Temperature { get; set; }

        public double WindSpeed { get; set; }

        public string RiskLevel { get; set; }

        public string RiskMessage { get; set; }
        public OpenWeatherResponse Weather { get; set; }

        public RiskAnalysis Risk { get; set; }
    }
}


