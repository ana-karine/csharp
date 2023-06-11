using System.Globalization;

// Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
// do vetor (supor não haver empates). Mostrar também a posição do maior elemento.

double maxNumber = 0.0;
int positionNumber = 0;

Console.WriteLine("Informe a quantidade de números do vetor: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Informe os " + N + " de números do vetor: ");
string[] str  = Console.ReadLine().Split(' ');

double[] numbers = new double[N];

for (int i = 0; i < N; i++) 
{
    numbers[i] = double.Parse(str[i], CultureInfo.InvariantCulture);
}

for (int i = 0; i < N; i++) 
{
    if (numbers[i] > maxNumber) {
        maxNumber = numbers[i];
        positionNumber = i;
    }    
}

Console.WriteLine("Maior número do vetor: " + maxNumber.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine("Posição do maior elemento: " + positionNumber);