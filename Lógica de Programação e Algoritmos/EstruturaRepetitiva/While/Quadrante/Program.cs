// https://www.beecrowd.com.br/judge/pt/problems/view/1115

using System; 

class URI {

    static void Main(string[] args) { 

        string quadrante = "";
        
        string[] numbers = Console.ReadLine().Split(' ');

        int X = int.Parse(numbers[0]);
        int Y = int.Parse(numbers[1]);

        while (X != 0 && Y != 0) {

            if (X > 0 && Y > 0) {
                quadrante = "primeiro";
            } else if (X < 0 && Y > 0) {
                quadrante = "segundo";
            } else if (X < 0 && Y < 0) {
                quadrante = "terceiro";
            } else if (X > 0 && Y < 0) {
                quadrante = "quarto";
            }

            Console.WriteLine(quadrante);

            numbers = Console.ReadLine().Split(' ');

            X = int.Parse(numbers[0]);
            Y = int.Parse(numbers[1]);
        }

    }

}
