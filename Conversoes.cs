using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos


{/// <summary>
 /// Implementa as conversoes de distancia
 /// /// </summary>
 /// <summary>
 /// Tipo de conversão de distância a executar
 /// </summary>
    public enum ConversaoDistancia
    {
        Nulo = 0,
        MetrosMilhas,
        MilhasMetros
    }

    /// <summary>
    /// Implementa as conversoes de temperatura
    /// </summary>
    /// <summary>
    /// Tipo de conversão de Temperatura a executar
    /// </summary>
    public enum ConversaoTemperatura
    {
        Nulo = 0,
        CelsiusFahrenheit,
        FahernheitCelcius
    }


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


        /// <summary>
        /// Conversões de distancias
        /// </summary>
        /// <param name="conversao"> Conversão a efetuar</param>
        /// <param name="distancia"> distancia a converter</param>
        /// <returns>Retorna o resultado da conversão </returns>
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213712;
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;

            }
            return -1;
        }
    }
}
