using System.Globalization;

// Fazer um programa para ler um número N, depois nome (apenas um), idade e altura de N pessoas.
// Exibir na tela a altura média das pessoas e a porcentagem de pessoas com menos de 16 anos.

Console.WriteLine("Informe a quantidade de pessoas a serem cadastradas: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade de campos no formulário: ");
int M = int.Parse(Console.ReadLine());
int[] idades = new int[M];
double[] alturas = new double[M];

string[] formulario;

int somaIdades = 0;
double porcentagemIdades = 0.0;
double somaAlturas = 0.0;
double mediaAlturas = 0.0;

for (int i = 1; i <= N; i++) 
{
    Console.WriteLine("Informe o nome (apenas um), a idade e a altura da pessoa " + i + ": ");
    formulario = Console.ReadLine().Split(' ');
    idades[1] = int.Parse(formulario[1]);
    alturas[2] = double.Parse(formulario[2], CultureInfo.InvariantCulture);

    if (idades[1] < 16) {
        somaIdades = somaIdades + 1;
    } 

    somaAlturas += alturas[2];
}

porcentagemIdades = (100 * somaIdades) / N;
mediaAlturas = somaAlturas / N;

Console.WriteLine("Altura média: " + mediaAlturas.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagemIdades + "%");
