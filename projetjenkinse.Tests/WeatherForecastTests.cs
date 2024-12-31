using Microsoft.VisualStudio.TestTools.UnitTesting;
using projetjenkinse;

namespace projetjenkinse.Tests
{
    [TestClass]
    public class WeatherForecastTests
    {
        [TestMethod]
        public void TemperatureF_ReturnsCorrectConversion()
        {
            // Arrange
            var forecast = new WeatherForecast
            {
                TemperatureC = 0
            };

            // Act
            int fahrenheit = forecast.TemperatureF;

            // Assert
            Assert.AreEqual(32, fahrenheit, "0°C should equal 32°F");
        }

        [TestMethod]
        public void TemperatureF_WithPositiveTemperature_ReturnsCorrectConversion()
        {
            // Arrange
            var forecast = new WeatherForecast
            {
                TemperatureC = 20
            };

            // Act
            int fahrenheit = forecast.TemperatureF;

            // Assert
            Assert.AreEqual(68, fahrenheit, "20°C should equal 68°F");
        }

        [TestMethod]
        public void TemperatureF_WithNegativeTemperature_ReturnsCorrectConversion()
        {
            // Arrange
            var forecast = new WeatherForecast
            {
                TemperatureC = -10
            };

            // Act
            int fahrenheit = forecast.TemperatureF;

            // Assert
            Assert.AreEqual(14, fahrenheit, "-10°C should equal 14°F");
        }
    }
}
