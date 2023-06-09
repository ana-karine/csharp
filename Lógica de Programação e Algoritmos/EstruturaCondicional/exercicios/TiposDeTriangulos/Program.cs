// https://www.beecrowd.com.br/judge/pt/problems/view/1045

using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        float temp = 0.0f;

        Console.WriteLine("Informe 3 valores de ponto flutuante: "); // 7.0 5.0 7.0
        string[] numbers = Console.ReadLine().Split(' ');

        float A = float.Parse(numbers[0], CultureInfo.InvariantCulture); 
        float B = float.Parse(numbers[1], CultureInfo.InvariantCulture); 
        float C = float.Parse(numbers[2], CultureInfo.InvariantCulture); 

        if (B >= A) {
            temp = A;
            A = B;
            B = temp;
        } 
        if (C >= A) {
            temp = A;
            A = C;
            C = temp;
        } 
        if (C >= B) {
            temp = B;
            B = C;
            C = temp;
        }

        if (A >= B + C) {
            Console.WriteLine("NAO FORMA TRIANGULO");
        } else if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)) {
            Console.WriteLine("TRIANGULO RETANGULO");
        } else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)) {
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        } else if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2)) {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        } else if (Math.Pow(A, 2) < Math.Pow(B, 2) + Math.Pow(C, 2)) {
            Console.WriteLine("TRIANGULO ACUTANGULO");
        } 
        
        if (A == B && A == C) {
            Console.WriteLine("TRIANGULO EQUILATERO");
        } else if (A == B || A == C || B == C) {
            Console.WriteLine("TRIANGULO ISOSCELES");
        }

        // TRIANGULO ACUTANGULO
        // TRIANGULO ISOSCELES
    }
}
