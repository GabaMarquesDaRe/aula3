using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
           a = int.Parse(Console.ReadLine());
           b = int.Parse(Console.ReadLine());
           c = int.Parse(Console.ReadLine());
            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("não compõem o triângulo");
            }
            else if (a == b && a == c) 
            {
                Console.WriteLine("triangulo equilatero");
            }
            else if (a != b && a != c)
            {
                Console.WriteLine("triangulo escaleno");
            }
            else if (a == b && a != c)
            {
                Console.WriteLine("triangulo isoceles");
            }
           Console.ReadKey();   
        }
    }
}
