// Fazer um programa para ler dois números inteiros MxN e uma matriz de 
// ordem MxN contendo números inteiros. Em seguida, mostrar:
// - a diagonal principal; 
// - os números négativos;
// - a quantidade de valores negativos.

int M, N;
int[,] numbers;

int count = 0;

Console.WriteLine("Informe a quantidade de linhas e colunas da matriz MxN: ");
string[] linhas_colunas = Console.ReadLine().Split(' ');
M = int.Parse(linhas_colunas[0]);
N = int.Parse(linhas_colunas[1]);

numbers = new int[M,N];

for (int i = 0; i < M; i++)
{
    Console.WriteLine("Informe os números da linha " + i);
    string[] str = Console.ReadLine().Split(' ');

    for (int j = 0; j < N; j++)
    {
        numbers[i,j] = int.Parse(str[j]);
    }
}

Console.WriteLine("\nDiagonal principal: "); // M == N
for (int i = 0; i < M; i++)
{
    Console.Write(numbers[i,i] + " ");
}

Console.WriteLine("\nNúmeros negativos: ");
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (numbers[i,j] < 0)
        {
            Console.Write(numbers[i,j] + " ");
            count++;
        }    
    }
}
Console.WriteLine("\nQuantidade de números negativos: " + count);