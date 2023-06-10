// Fazer um programa para ler um número N, depois nome (apenas um), idade e altura de N pessoas.
// Exibir na tela a altura média das pessoas e a porcentagem de pessoas com menos de 16 anos.

Console.WriteLine("Informe a quantidade de cadastros (N): ");
int N = int.Parse(Console.ReadLine());

string[] person = new string[3];

for (int i = 1; i <= N; i++) {
    Console.WriteLine("Informe os nome (apenas um), idade e altura da pessoa " + i + ": ");
    person[i] = Console.ReadLine();
}
