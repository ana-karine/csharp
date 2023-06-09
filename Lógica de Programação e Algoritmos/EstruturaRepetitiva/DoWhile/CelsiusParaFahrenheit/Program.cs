using System.Globalization;

char repetir;
double C = 0.0;
double F = 0.0;

do {
    Console.WriteLine("Digite a temperatura em Celsius: ");
    C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    F = 1.8 * C + 32;

    Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));

    Console.WriteLine("Deseja repetir (s/n)?");
    repetir = char.Parse(Console.ReadLine());
} while (repetir == 's');
