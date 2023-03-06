using System;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Digite um cep");
                string cep = Console.ReadLine();

                var va = ValidaCEP(cep);

                if (va)
                {
                    Console.WriteLine("Cep Valido");
                }
                else
                {
                    Console.WriteLine("Cep invalido");
                }
            } while (true);

        }

        public static bool ValidaCEP(string cep)
        {
            if (string.IsNullOrEmpty(cep) || cep == "00000-000" || cep == "00000000" || cep.Length < 8)
                return false;

            if (cep.Length.Equals(8) && !cep.Contains("-"))
                cep = cep.Insert(5, "-"); 

            Regex Rgx = new Regex(@"^\d{5}-\d{3}$");
            return Rgx.IsMatch(cep);
        }
    }
}
