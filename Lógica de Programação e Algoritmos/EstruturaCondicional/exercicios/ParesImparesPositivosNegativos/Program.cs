// https://www.beecrowd.com.br/judge/pt/problems/view/1066

using System; 

class URI {

    static void Main(string[] args) { 

        int pair = 0;
        int odd = 0;
        int positive = 0;
        int negative = 0;

        Console.WriteLine("Informe 5 valores Inteiros: ");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        int D = int.Parse(Console.ReadLine());
        int E = int.Parse(Console.ReadLine());

        if (A % 2 == 0) {
            pair += 1;
        } else {
            odd += 1;
        }
        if (A > 0) {
            positive += 1;
        } else if (A < 0) {
            negative += 1;
        }

        if (B % 2 == 0) {
            pair += 1;
        } else {
            odd += 1;
        }
        if (B > 0) {
            positive += 1;
        } else if (B < 0) {
            negative += 1;
        }

        if (C % 2 == 0) {
            pair += 1;
        } else {
            odd += 1;
        }
        if (C > 0) {
            positive += 1;
        } else if (C < 0) {
            negative += 1;
        }

        if (D % 2 == 0) {
            pair += 1;
        } else {
            odd += 1;
        }
        if (D > 0) {
            positive += 1;
        } else if (D < 0) {
            negative += 1;
        }

        if (E % 2 == 0) {
            pair += 1;
        } else {
            odd += 1;
        }
        if (E > 0) {
            positive += 1;
        } else if (E < 0) {
            negative += 1;
        }

        Console.WriteLine(pair + " valor(es) par(es)");
        Console.WriteLine(odd + " valor(es) impar(es)");
        Console.WriteLine(positive + " valor(es) positivo(s)");
        Console.WriteLine(negative + " valor(es) negativo(s)");
    }

}
