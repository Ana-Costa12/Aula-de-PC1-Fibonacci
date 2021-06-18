using System;

namespace Aula_de_PC1_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int Termos, soma, valor1 = 0, valor2 = 1;
            bool decide;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vamos fazer a sequência FIBONACCI!");
            Console.WriteLine("Nesta sequência, os dois primeiros números são 0 e 1.\nOs próximos números são a soma dos dois números anteriores.");
            Console.WriteLine("///////////////////////////////////////////////////////////");
            Console.ResetColor();
            Console.WriteLine("Digite a quantidade de termos:"); 
            Termos = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            soma = valor1 + valor2;
            Console.Write(0 + " " + 1 + " ");
            for (int i = 3; i <= Termos; i++)
            {
                Console.Write(soma + " ");
                valor1 = valor2;
                valor2 = soma;
                soma = valor1 + valor2;
            }
        }
    }
}
