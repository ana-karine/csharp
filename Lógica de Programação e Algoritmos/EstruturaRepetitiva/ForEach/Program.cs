Console.WriteLine("Informe o tamanho do vetor: ");
int N = int.Parse(Console.ReadLine());

string[] nomes = new string[N];

Console.WriteLine("\nInforme os " + N + " nomes: ");
for (int i = 0; i < N; i++) {
    nomes[i] = Console.ReadLine();
}

/*Console.WriteLine("\Nomes lidos: ");
for (int i = 0; i < N; i++) {
    Console.WriteLine(nomes[i]);
}*/

Console.WriteLine("\nNomes lidos: ");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}