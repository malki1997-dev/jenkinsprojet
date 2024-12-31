namespace projetjenkinse
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC * 1.8);

        public string? Summary { get; set; }
    }
}
