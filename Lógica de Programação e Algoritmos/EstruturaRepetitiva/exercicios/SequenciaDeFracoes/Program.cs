// https://www.beecrowd.com.br/judge/pt/problems/view/1155

using System;
using System.Globalization;

namespace URI {

    class Program {

        static void Main(string[] args) {
            
            double soma = 0;
            
            // S = 1 + 1/2 + 1/3 + … + 1/100
            for (int i = 1; i <= 100; i++) {
                soma = soma + 1.0 / i;
            }

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
