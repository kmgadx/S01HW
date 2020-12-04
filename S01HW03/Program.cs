using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01HW03
{
    class Program
    {
        #region
        /*4. Написать программу обмена значениями двух переменных.
        а) с использованием третьей переменной;
        б) *без использования третьей переменной.
        */
        #endregion

        static void Main(string[] args)
        {
            // вариант а
            int a = 7;
            int b = 15;
            int c = a;
            a = b;
            b = c;

            // вариарт б
            int d = 2;
            int e = 3;
            d = d + e;
            e = d - e;
            d = d - e;
        }
    }
}
