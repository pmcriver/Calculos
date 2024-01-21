using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{/// <summary>
/// Implementa operações aritméticas
/// </summary>
    internal static class Aritmetica
        /// <summary>
        /// Tipo de conversão de Temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        { 
            Nulo =0,
            CelsiusFahrenheit,
            FahernheitCelcius}
    {/// <summary>
    /// Operação Somar
    /// </summary>
    /// returnar a soma de dois inteiros.
    /// <returns></returns>
        public static int Somar(int x,int y) 
        { 
            return x + y; 
        }
        /// <summary>
        /// Operação Subtrair
        /// </summary>
        /// returnar a subtracao de dois inteiros.
        /// <returns></returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        
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
