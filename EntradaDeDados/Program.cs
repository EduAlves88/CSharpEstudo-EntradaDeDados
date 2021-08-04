using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu Nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");

            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');
            string ulNome = vetor[0];
            int idade = int.Parse(vetor[1]);
            float altura = float.Parse(vetor[2]);
            Console.WriteLine(nome);
            Console.WriteLine(qtos);
            Console.WriteLine(preco.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(ulNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}
