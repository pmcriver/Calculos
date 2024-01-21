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
        
        
    }
}
