using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01HW2
{
    class Program
    {
        #region
        /* 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
         * по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
        */
        #endregion

        static void Main(string[] args)
        {
            double m;
            double h;

            Console.WriteLine("Введите вес в килограммах");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите рост в метрах");
            h = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);

            Console.Write("Индекс массы тела составляет: " + I);

            Console.ReadLine();

        }
    }
}
