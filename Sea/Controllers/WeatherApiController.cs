using Microsoft.AspNetCore.Mvc;
using Sea.Models;
using System.Net.Http.Json;

namespace Sea.Controllers
{
    [Route("api/weather")]
    [ApiController]
    public class WeatherApiController : ControllerBase
    {

        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;


        public WeatherApiController(
            IHttpClientFactory httpClientFactory,
            IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            _configuration = configuration;
        }



        [HttpGet("marine-status")]
        public async Task<IActionResult> GetMarineStatus(
            string type,
            double lat,
            double lon)
        {


            // ================= OPEN WEATHER =================


            string apiKey = _configuration["ApiKeys:OpenWeather"];


            if (string.IsNullOrEmpty(apiKey))
            {
                return BadRequest("OpenWeather API key is missing");
            }



            string weatherUrl =
                $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={apiKey}&units=metric";



            var weather =
                await _httpClient.GetFromJsonAsync<OpenWeatherResponse>(weatherUrl);



            if (weather == null)
            {
                return BadRequest("OpenWeather failed");
            }




            // ================= OPEN METEO MARINE =================


            string marineUrl =
                $"https://marine-api.open-meteo.com/v1/marine?latitude={lat}&longitude={lon}&hourly=wave_height,wave_direction,wave_period";



            var marine =
                await _httpClient.GetFromJsonAsync<MarineApiResponse>(marineUrl);



            if (marine == null || marine.hourly == null)
            {
                return BadRequest("Marine API failed");
            }





            // ================= OPEN METEO FORECAST =================
            string forecastUrl =
                $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&hourly=temperature_2m,wind_speed_10m,wind_direction_10m";  


            var forecast =
                await _httpClient.GetFromJsonAsync<ForecastResponse>(forecastUrl);



            if (forecast == null || forecast.hourly == null)
            {
                return BadRequest("Forecast API failed");
            }





            // ================= DATA =================


            double temperature =
                weather.main.temp;



            double visibility =
                weather.visibility;



            // Rain

            double rain = 0;


            if (weather.rain != null)
            {
                rain = weather.rain.OneHour;
            }





            // ================= WAVE =================


            var waveHistory =
                marine.hourly.wave_height
                .Take(24)
                .ToList();



            if (waveHistory.Count == 0)
            {
                return BadRequest("No wave data available");
            }



            double waves =
                waveHistory.First();




            double wavePeriod = 0;


            if (marine.hourly.wave_period != null &&
                marine.hourly.wave_period.Count > 0)
            {
                wavePeriod =
                    marine.hourly.wave_period.First();
            }






            // ================= WIND =================


            var windHistory =
                forecast.hourly.wind_speed_10m
                .Take(24)
                .ToList();



            if (windHistory.Count == 0)
            {
                return BadRequest("No wind data available");
            }



            // current wind

            double wind =
                windHistory.First();


            // current wind direction

            double windDirection =
                forecast.hourly.wind_direction_10m.First();






            // ================= TEMPERATURE HISTORY =================


            var temperatureHistory =
                forecast.hourly.temperature_2m
                .Take(24)
                .ToList();








            // ================= STATUS =================


            string status;

            List<string> reasons = new();

            if (type == "boats")
            {


                if (wind < 8 && waves < 0.8)
                {

                    status = "Safe 🟢";

                    reasons.Add($"Wind speed is low ({wind} m/s)");
                    reasons.Add($"Wave height is acceptable ({waves} m)");
                    reasons.Add("Suitable for boating");


                }


                else if (wind < 12 && waves < 1.5)
                {

                    status = "Caution 🟡";

                    reasons.Add($"Wind speed is moderate ({wind} m/s)");
                    reasons.Add($"Wave height is ({waves} m)");
                    reasons.Add("Check weather before departure");


                }


                else
                {

                    status = "Danger 🔴";

                    reasons.Add("Strong wind");
                    reasons.Add("High waves");
                    reasons.Add("Avoid boating");


                }


            }





            else if (type == "swimming")
            {

                bool heavyRain = rain > 10;


                if (
                    waves < 0.3 &&
                    wind < 5 &&
                    visibility > 5000 &&
                    !heavyRain
                   )
                {

                    status = "Safe 🟢";


                    reasons.Add($"Wave height is calm ({waves} m)");
                    reasons.Add($"Wind speed is low ({wind} m/s)");
                    reasons.Add($"Visibility is good ({visibility / 1000} km)");
                    reasons.Add("Conditions are suitable for swimming");


                }


                else if (
                    waves < 0.6 &&
                    wind < 8
                    )
                {

                    status = "Caution 🟡";


                    reasons.Add($"Moderate wave height ({waves} m)");
                    reasons.Add($"Moderate wind speed ({wind} m/s)");
                    reasons.Add("Swim near the shore and monitor conditions");


                }


                else
                {

                    status = "Danger 🔴";


                    reasons.Add("Unsafe swimming conditions");


                    if (waves >= 0.6)
                    {
                        reasons.Add("High waves");
                    }


                    if (wind >= 8)
                    {
                        reasons.Add("Strong wind");
                    }


                    if (visibility <= 5000)
                    {
                        reasons.Add("Poor visibility");
                    }


                    if (heavyRain)
                    {
                        reasons.Add("Heavy rain");
                    }


                    reasons.Add("Avoid entering the sea");

                }

            }


            else if (type == "fishing")
            {

                bool heavyRain = rain > 10;



                if (
                    wind < 10 &&
                    waves < 1.2 &&
                    visibility > 5000 &&
                    !heavyRain
                  )
                {

                    status = "Good 🟢";


                    reasons.Add($"Wind speed is good ({wind} m/s)");
                    reasons.Add($"Wave height is stable ({waves} m)");
                    reasons.Add("Good visibility");
                    reasons.Add("Good fishing conditions");
                    reasons.Add("Sea conditions are stable");

                }



                else if (
                    (wind >= 10 && wind < 15) ||
                    (waves >= 1.2 && waves < 2)
                    )
                {

                    status = "Average 🟡";


                    reasons.Add($"Windy conditions ({wind} m/s)");
                    reasons.Add($"Wave height ({waves} m)");
                    reasons.Add("Monitor weather changes before fishing");


                }



                else
                {

                    status = "Poor 🔴";


                    reasons.Add("Unsafe fishing conditions");


                    if (wind >= 15)
                    {
                        reasons.Add("Strong wind");
                    }


                    if (waves >= 2)
                    {
                        reasons.Add("High waves");
                    }


                    if (heavyRain)
                    {
                        reasons.Add("Storm or heavy rain");
                    }


                    reasons.Add("Avoid going offshore");


                }

            }
            else
            {
                return BadRequest("Invalid type.");
            }


            // ================= RESPONSE =================


            return Ok(new MarineWeatherDto
            {

                Temperature = temperature,

                WindSpeed = wind,

                WaveHeight = waves,

                WavePeriod = wavePeriod,

                Visibility = visibility,

                Rain = rain,


                Status = status,

                Reasons = reasons,

                WindHistory = windHistory,

                WaveHistory = waveHistory,
                WindDirection = windDirection,
                RainHistory = Enumerable.Repeat(rain, 24).ToList(),

                TemperatureHistory = temperatureHistory

            });
        }
    }
}