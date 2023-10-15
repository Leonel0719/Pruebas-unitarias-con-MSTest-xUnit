using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LADCH.Temperatura
{
    public class TemperaturaConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            //implementa la conversion de celsius a Fahrenheit
            return (celsius * 9 / 5) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            //implementa la conversion de Fahrenheit a celsius
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
