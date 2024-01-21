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
    internal class Aritmetica
    {/// <summary>
    /// Operação Somar
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
        public int Somar(int x,int y) 
        { 
            return x + y; 
        }
        /// <summary>
        /// Operação Subtrair
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}
