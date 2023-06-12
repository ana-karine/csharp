// Fazer um programa para ler dois números inteiros MxN e uma matriz de 
// ordem MxN contendo números inteiros. Em seguida, mostrar:
// - a soma dos elementos acima da diagonal principal;
// - a soma dos elementos abaixo da diagonal principal.

int M, N;
int[,] numbers;
int aboveSum = 0;
int belowSum = 0;

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

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (i < j)   
        {
            aboveSum += numbers[i,j];
        }

        if (i > j)   
        {
            belowSum += numbers[i,j];
        }
    }
}
Console.WriteLine("Soma dos elementos acima da diagonal principal: " + aboveSum);
Console.WriteLine("Soma dos elementos abaixo da diagonal principal: " + belowSum);
