using System;

namespace TesteSequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o numero para saber se ele faz parte da sequência de Fibonacci: ");
            int numeroASertestado = int.Parse(Console.ReadLine());

            long num1 = 0;
            long num2 = 1;
            long aux;
            string resultado = "";

            for (int i = 0; i​​​​​​​ < numeroASertestado; i++)
            {
                aux = num1;
                num1 = num2;
                num2 = num1 + aux;
                Console.Write(num2 + ", ");
                if (numeroASertestado == num2)
                {
                    resultado = $"{numeroASertestado} Pertence a sequência Fibonacci";
                    break;
                }
                else
                {
                    resultado = $"{numeroASertestado} Não pertence a sequência Fibonacci";
                }

            }
            Console.WriteLine();
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
