// https://www.beecrowd.com.br/judge/pt/problems/view/1074

using System; 

class URI {

    static void Main(string[] args) { 

        int number = 0;
        string pairOrOdd = "";
        string PositiveOrNegative = "";
        // int pair = 0;
        // int odd = 0;
        // int positive = 0;
        // int negative = 0;

        // Console.WriteLine("Informe a quantidade de valores que serão lidos em seguida: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++) {
            // Console.WriteLine("Informe um número inteiro: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) {
                // pair += 1;
                pairOrOdd = "EVEN";
                
            } else {
                // odd += 1;
                pairOrOdd = "ODD";
            }

            if (number > 0) {
                // positive += 1;
                PositiveOrNegative = "POSITIVE";
            } else if (number < 0) {
                // negative += 1;
                PositiveOrNegative = "NEGATIVE";
            }

            if (number == 0) {
                Console.WriteLine("NULL");
            } else {
                Console.WriteLine(pairOrOdd + " " + PositiveOrNegative);
            }
   
        }

        // Console.WriteLine();
        // Console.WriteLine(pair + " valor(es) par(es)");
        // Console.WriteLine(odd + " valor(es) impar(es)");
        // Console.WriteLine(positive + " valor(es) positivo(s)");
        // Console.WriteLine(negative + " valor(es) negativo(s)");
    }
}
