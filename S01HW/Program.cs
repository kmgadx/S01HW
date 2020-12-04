using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S01HW
{
    #region
    /*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
        В результате вся информация выводится в одну строчку.
        а) используя склеивание;
        б) используя форматированный вывод;
        в) *используя вывод со знаком $.
    */
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Введите свое имя");
            string Name = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию");
            string Surname = Console.ReadLine();

            Console.WriteLine("Введите свой возраст");
            string Age = Console.ReadLine();

            Console.WriteLine("Введите свой рост");
            string Height = Console.ReadLine();

            Console.WriteLine("Введите свой вес");
            string Weight = Console.ReadLine();

            Console.Write("Вас зовут " + Name + " " + Surname + ", Вам " + Age + " лет, Ваш рост " + Height + " см. и вес " + Weight + " кг");

            Console.ReadLine();
            #endregion
        }
    }
}
