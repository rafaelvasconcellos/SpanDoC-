using System;

namespace TestandoSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayMemory = new double[10] { 10.56768,
                                                    5.376936,
                                                    8.61,
                                                    7.29,
                                                    6.728,
                                                    7.7251,
                                                    10.593,
                                                    20.7769,
                                                    2.57874,
                                                    3.589 };

            var arraySpan = new Span<double>(arrayMemory);

            Console.WriteLine("Exibindo o array original: ");
            ExibirValores(arraySpan);

            Console.WriteLine("Arredondando os primeiros 5 números para duas casas decimais: ");
            Arredondar(arraySpan.Slice(0, 5));
            ExibirValores(arraySpan);

            Console.WriteLine("Arredondando os últimos 5 números que faltavam para duas casas decimais: ");
            Arredondar(arraySpan.Slice(5));
            ExibirValores(arraySpan);


            Console.WriteLine("Preenchendo o array todo com 1's");
            arraySpan.Fill(1);
            ExibirValores(arraySpan);


            Console.ReadKey();
        }

        private static void Arredondar(Span<double> valores)
        {
            for (int i = 0; i < valores.Length; i++)
                valores[i] = Math.Round(valores[i], 2);
        }

        private static void ExibirValores(Span<double> valores)
        {
            Console.Write("{ ");

            for (int i = 0; i < valores.Length; i++)
            {
                if (i > 0) Console.Write(", ");

                Console.Write(valores[i]);
            }

            Console.WriteLine(" }");


            Console.WriteLine("--------------------");
        }
    }
}
