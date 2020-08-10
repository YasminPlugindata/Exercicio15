
using System;

namespace Exercicio15 { 
    class Program { 
        static void Main(string[] args) {

            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) { 
                vet[1] = int.Parse(s[1]);
            }

            for (int i = 0; i < N; i++) { 
                if (vet[i] < 0) { 
                    Console.WriteLine(vet[1]);
                }
            }
            Console.ReadLine();
        }
    }
}
