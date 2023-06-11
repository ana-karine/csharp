using System.Globalization;

// Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
// - todos os números pares, ímpares, positivos e negativos 
// - a quantidade de números pares, ímpares, positivos e negativos

int amountPairs = 0;
int amountOdds = 0;
int amountPositives = 0;
int amountNegatives = 0;

int pairIndex = 0;
int oddIndex = 0;
int positiveIndex = 0;
int negativeIndex = 0;

Console.WriteLine("Informe a quantidade de números no vetor: ");
int N = int.Parse(Console.ReadLine());

int[] numbers = new int[N];

string[] pairs = new string[N];
string[] odds = new string[N];
string[] positives = new string[N];
string[] negatives = new string[N];

Console.WriteLine("Informe os " + N + " números no vetor: ");
string[] str = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++) 
{
    numbers[i] = int.Parse(str[i], CultureInfo.InvariantCulture);

    if (numbers[i] % 2 == 0 && numbers[i] != 0)
    {
        pairs[pairIndex] = numbers[i].ToString();
        pairIndex++;
        amountPairs++;
    } else if (numbers[i] % 2 != 0 && numbers[i] != 0)
    {
        odds[oddIndex] = numbers[i].ToString();;
        oddIndex++;
        amountOdds++;
    }

    if (numbers[i] > 0 && numbers[i] != 0)
    {
        positives[positiveIndex] = numbers[i].ToString();;
        positiveIndex++;
        amountPositives++;
    } else if (numbers[i] < 0 && numbers[i] != 0)
    {
        negatives[negativeIndex] = numbers[i].ToString();;
        negativeIndex++;
        amountNegatives++;
    }
}

Console.WriteLine("Números pares: ");
foreach (string pair in pairs) {
    Console.Write(pair + " ");
}
Console.WriteLine();
Console.WriteLine("Quantidade de números pares: " + amountPairs);

Console.WriteLine("Números ímpares: ");
foreach (string odd in odds) {
    Console.Write(odd + " ");
}
Console.WriteLine();
Console.WriteLine("Quantidade de números ímpares: " + amountOdds);

Console.WriteLine("Números positivos: ");
foreach (string positive in positives) {
    Console.Write(positive + " ");
}
Console.WriteLine();
Console.WriteLine("Quantidade de números positivos: " + amountPositives);

Console.WriteLine("Números negativos: ");
foreach (string negative in negatives) {
    Console.Write(negative + " ");
}
Console.WriteLine();
Console.WriteLine("Quantidade de números negativos: " + amountNegatives);
