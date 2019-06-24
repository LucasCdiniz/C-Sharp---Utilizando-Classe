using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UdemyPrimeirosProjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa_Funcionario p1, p2;
            p1 = new Pessoa_Funcionario();
            p2 = new Pessoa_Funcionario();

            Console.WriteLine("Infome o nome da Primeira Pessoa");
            p1.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe a sua Idade");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe o seu Salário");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Infome o nome da Segunda Pessoa");
            p2.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Informe a sua Idade");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Informe o seu Salário");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " +p1.Nome + " com "+ p1.Idade + " anos de idade");
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é " +p2.Nome + " com " + p2.Idade + " anos de idade");
            }

            double media = (p1.salario+p2.salario) / 2;
            Console.WriteLine();
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
