using System;
using System.Globalization;

namespace SortSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, MAIOR, MEIO, MENOR;

            string[] valores = Console.ReadLine().Split(' ');

            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            if (A < B && A < C)
            {
                MENOR = A;
                if (B < C)
                {
                    MEIO = B;
                    MAIOR = C;
                }
                else
                {
                    MEIO = C;
                    MAIOR = B;
                }
            }
            else if (B < C)
            {
                MENOR = B;
                if (A < C)
                {
                    MEIO = A;
                    MAIOR = C;
                }
                else
                {
                    MEIO = C;
                    MAIOR = A;
                }
            }
            else
            {
                MENOR = C;
                if (A < B)
                {
                    MEIO = A;
                    MAIOR = B;
                }
                else
                {
                    MEIO = B;
                    MAIOR = A;
                }
            }

            Console.WriteLine(MENOR);
            Console.WriteLine(MEIO);
            Console.WriteLine(MAIOR);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
