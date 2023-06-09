using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        float temp = 0.0f;

        Console.WriteLine("Informe 3 valores de ponto flutuante: "); // 3.0 2.0 1.0
        string[] numbers = Console.ReadLine().Split(' '); 

        float A = float.Parse(numbers[0], CultureInfo.InvariantCulture); 
        float B = float.Parse(numbers[1], CultureInfo.InvariantCulture); 
        float C = float.Parse(numbers[2], CultureInfo.InvariantCulture); 

        if (B < A) {
            temp = A;
            A = B;
            B = temp;
        } 
        if (C < A) {
            temp = A;
            A = C;
            C = temp;
        } 
        if (C < B) {
            temp = B;
            B = C;
            C = temp;
        }

        Console.WriteLine("A: " + A.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("B: " + B.ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("C: " + C.ToString("F1", CultureInfo.InvariantCulture));

    }
}
