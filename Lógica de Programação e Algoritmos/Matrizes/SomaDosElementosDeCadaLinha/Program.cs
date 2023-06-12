// Fazer um programa para ler dois números inteiros MxN e uma matriz de 
// ordem MxN contendo números inteiros. Em seguida, mostrar:
// - a soma dos elementos de cada linha

int M, N;
int[,] numbers;
int[] sum;

int count = 0;

Console.WriteLine("Informe a quantidade de linhas e colunas da matriz MxN: ");
string[] linhas_colunas = Console.ReadLine().Split(' ');
M = int.Parse(linhas_colunas[0]);
N = int.Parse(linhas_colunas[1]);

numbers = new int[M,N];
sum = new int[M];

for (int i = 0; i < M; i++)
{
    Console.WriteLine("Informe os números da linha " + i);
    string[] str = Console.ReadLine().Split(' ');

    for (int j = 0; j < N; j++)
    {
        numbers[i,j] = int.Parse(str[j]);
    }
}

Console.WriteLine("\nSoma dos elementos de cada linha: ");
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        sum[i] += numbers[i,j];   
    }
    Console.WriteLine(sum[i]);
}
