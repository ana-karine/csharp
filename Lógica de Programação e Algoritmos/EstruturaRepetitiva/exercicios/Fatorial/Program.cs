// https://www.beecrowd.com.br/judge/pt/problems/view/1153

using System;

namespace URI {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
