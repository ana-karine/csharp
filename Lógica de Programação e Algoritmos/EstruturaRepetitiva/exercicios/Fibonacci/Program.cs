// https://www.beecrowd.com.br/judge/pt/problems/view/1151

using System;

namespace URI {

    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine()); // 5

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i = i + 1) {
                if (i == n - 1) {
                    Console.WriteLine(a);
                }
                else {
                    Console.Write(a + " ");
                }
                int aux = b;
                b = a;
                a = aux + b;
            }

            // 0 1 1 2 3
        }
    }
}