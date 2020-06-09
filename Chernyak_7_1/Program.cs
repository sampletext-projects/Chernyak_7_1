using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernyak_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выполнила Черняк Оксана Александровна, АЭМ-111");
            string debug = "i am as awesome as my ass";

            Console.WriteLine("Введите строку для анализа, либо 'debug': ");
            string text = Console.ReadLine();
            if (text == "debug")
            {
                text = debug;
                Console.WriteLine("Обработка ввода: \n" + debug);
            }

            Console.WriteLine("Введите символ для поиска: ");
            char c = Console.ReadLine()[0];

            int count = 0;
            string[] tokens = text.Split(' ');
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i][0] == c)
                {
                    count++;
                }
            }

            Console.WriteLine("{0} слов начинается с символа '{1}'", count, c);

            Console.ReadKey();
        }
    }
}