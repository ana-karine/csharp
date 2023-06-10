using System.Globalization;

// Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida:
// - imprimir todos os elementos do vetor;
// - mostrar na tela a soma e a média dos elementos do vetor.

/*
Entrada: 
4
8.0 4.0 10.0 14.0

Saída:
8.0 4.0 10.0 14.0
36.00
9.00
*/

double soma = 0.0;
double media = 0.0;

Console.WriteLine("Informe o tamanho do vetor: ");
int N = int.Parse(Console.ReadLine());
double[] doubleVector = new double[N];

Console.WriteLine("Informe os " + N + " números reais do vetor: ");
string[] stringVector = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++ ) {
    doubleVector[i] = double.Parse(stringVector[i], CultureInfo.InvariantCulture);
    soma += doubleVector[i];
}

media = soma / N;

Console.WriteLine();

for (int i = 0; i < N; i++ ) {
    Console.Write(doubleVector[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

Console.WriteLine();

Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));