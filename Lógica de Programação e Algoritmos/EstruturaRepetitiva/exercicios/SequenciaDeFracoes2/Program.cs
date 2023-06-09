// https://www.beecrowd.com.br/judge/pt/problems/view/1156

using System;

using System.Globalization;

class URI {
    static void Main(string[] args) {

        int num;
        double den = 1.0, soma = 0.0;

        // S = 1 + 3/2 + 5/4 + 7/8 + ... + 39/?
        for (num = 1; num <= 39; num += 2) {
            soma = soma + num / den;
            den = den * 2.0;
        }
        Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));

        Console.ReadLine();
    }
}
