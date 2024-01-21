using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{/// <summary>
/// Implementa as conversoes de temperatura
/// </summary>
    internal static class Conversoes
    {/// <summary>
    /// Conversões de temperaturas
    /// </summary>
    /// <param name="conversao"> Conversão a efetuar</param>
    /// <param name="temperatura"> temperatura a converter</param>
    /// <returns>Retorna o resultado da conversão </returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura + 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahernheitCelcius)
            {
                return ((temperatura - 32) / 1.8000);

            }
            return -1;
        }
    }
}
