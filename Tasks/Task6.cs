using System;
using System.Collections.Generic;

namespace Tasks
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers) {
            decimal positive = 0, negative = 0, zero = 0;
            List<decimal> GetProportion = new List<decimal>();
            foreach (var i in numbers)
            {
                if (i == 0)
                    zero++;
                else if (i > 0)
                    positive++;
                else
                    negative++;
            }
            decimal prop_Pos = Math.Round(positive / numbers.Count,6);
            decimal prop_Neg = Math.Round(negative / numbers.Count,6);
            decimal prop_Zero = Math.Round(zero / numbers.Count,6);

            GetProportion.Add(prop_Pos);
            GetProportion.Add(prop_Neg);
            GetProportion.Add(prop_Zero);
            return GetProportion;
        }
    }
}
