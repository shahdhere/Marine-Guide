namespace Sea.Models
{
    public class ForecastResponse
       {
            public ForecastHourly hourly { get; set; }
    }


        public class ForecastHourly
        {
            public List<double> temperature_2m { get; set; }
        public List<double> wind_speed_10m { get; set; }
        public List<double> wind_direction_10m { get; set; }


    }
}

