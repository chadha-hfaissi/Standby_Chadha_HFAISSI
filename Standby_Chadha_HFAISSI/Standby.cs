using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standby_Chadha_HFAISSI
{
    public class Standby
    {
        public static long Factoriel(int n )
        {
            return n > 1 ? n * Factoriel(n - 1) : 1;
        }

        public static double calcule (double t, double lamda , int k)
        {
            return (Math.Exp(-lamda * t) * Math.Pow(lamda * t, k) / Factoriel(k));
        }
       
    }
}
