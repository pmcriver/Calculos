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
    /// <summary>
    /// Operação Multipilicar
    /// </summary>
    /// <returns>returnar a multiplicação de dois inteiros.</returns>
    public static int Multiplicar(int x, int y)
    {
        return x * y;
    }

}
}
