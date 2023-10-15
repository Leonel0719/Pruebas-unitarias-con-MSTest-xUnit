using Microsoft.VisualStudio.TestTools.UnitTesting;
using LADCH.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LADCH.Temperatura.Tests
{
    [TestClass()]
    public class TemperaturaConverterTests
    {
        [TestMethod]
        public void CelsiusToFahrenheit()
        {
            double celsius = 25;
            double expectedFahrenheit = 77;
            TemperaturaConverter converter = new TemperaturaConverter();

            double actualFahrenheit = converter.CelsiusToFahrenheit(celsius);

            Assert.AreEqual(expectedFahrenheit, actualFahrenheit, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius()
        {

            double fahrenheit = 68;
            double expectedCelsius = 20;
            TemperaturaConverter converter = new TemperaturaConverter();

            double actualCelsius = converter.FahrenheitToCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius, 0.001);
        }
    }
}