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

Console.WriteLine("Informe o tamanho do vetor: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Informe os " + N + " números reais do vetor: ");
string[] stringVector = Console.ReadLine().Split(' ');

double[] doubleVector = new double[N];

for (int i = 0; i < N; i++ ) {
    doubleVector[i] = double.Parse(stringVector[i], CultureInfo.InvariantCulture);
}

for (int i = 0; i < N; i++ ) {
    Console.Write(doubleVector[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}