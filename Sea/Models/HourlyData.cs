namespace Sea.Models
{
    public class HourlyData
    {
        public List<string> time { get; set; }

        public List<double> wave_height { get; set; }

        public List<double> wave_direction { get; set; }

        public List<double> wave_period { get; set; }
    }
}
