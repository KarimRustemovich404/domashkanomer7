using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace да_ты_что_седьмая_домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = new byte[1024];

            Random number0 = new Random();

            number0.NextBytes(bytes);

            int a = number0.Next();
            int b= number0.Next();
            int c = number0.Next();
            int d = number0.Next();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
