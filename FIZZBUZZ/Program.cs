using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FIZZBUZZ
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public string RetornaFizz(int numero)
        {
            if (numero == 2)
                return "Fizz";
            else
                return "Nao Fizz";
        }

        public string RetornaBuzz(int numero)
        {
            
            if (numero == 3)
                return "Buzz";
            else
                return "Nao Buzz";
        }

        public string RetornarFizzBuzz(int numero)
        {
            if (numero < 0)
                return "Erro";

            if (numero % 2 == 0)
                return "Fizz";
            else
                return "Buzz";
        }

    }
}
