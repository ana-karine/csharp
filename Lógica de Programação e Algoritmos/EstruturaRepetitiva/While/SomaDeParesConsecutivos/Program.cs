// https://www.beecrowd.com.br/judge/pt/problems/view/1159

using System; 

class URI {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());
        int sum = 0;

        while (x != 0) {

            if (x % 2 == 0) {
                sum = x + (x + 2) + (x + 4) + (x + 6) + (x + 8);
                sum = (5 * x) + 20;
            } else {
                sum = (x + 1) + (x + 1 + 2) + (x + 1 + 4) + (x + 1 + 6) + (x + 1 + 8);
                sum = (5 * x) + 25;
            }

            Console.WriteLine(sum);

            x = int.Parse(Console.ReadLine());
            sum = 0;
       }

    }

}
