using System;

namespace URI {
    class Program {
        static void Main(string[] args) {

            // vamos considerar o primeiro valor como sendo inicialmente o menor
            int menor = int.Parse(Console.ReadLine());
            int posicao = 1;

            // agora vamos ler o segundo até o centésimo 
            for (int i = 2; i <= 100; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x < menor) {
                    menor = x;
                    posicao = i;
                }
            }

            Console.WriteLine(menor);
            Console.WriteLine(posicao);
        }
    }
}
