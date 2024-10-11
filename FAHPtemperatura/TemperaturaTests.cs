using Microsoft.VisualStudio.TestTools.UnitTesting;
using FAHP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAHP.Tests
{
    [TestClass()]
    public class TemperaturaTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            var temperatura = new Temperatura();
            double celsius = 0;

            // Act
            double result = temperatura.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(32, result, 0.001, "La conversión de Celsius a Fahrenheit falló para 0°C");
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            var temperatura = new Temperatura();
            double fahrenheit = 32;

            // Act
            double result = temperatura.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(0, result, 0.001, "La conversión de Fahrenheit a Celsius falló para 32°F");
        }
    }
}