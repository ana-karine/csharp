// http://www.linhadecodigo.com.br/artigo/3444/arrays-em-csharp-teoria-e-pratica.aspx

// Exemplo: utilizar um array jagged para armazenar turmas com vários alunos cada uma

Console.Write("Informe o número de turmas: ");
int num_turmas = int.Parse(Console.ReadLine());

string[][] turmas = new string[num_turmas][];

for (int i = 0; i < num_turmas; i++) 
{
    Console.Write("Informe a quantidade de alunos da turma {0}: ", i);
    int num_alunos = int.Parse(Console.ReadLine());

    turmas[i] = new string[num_alunos];

    for (int j = 0; j < num_alunos; j++)
    {
        Console.Write("Informe o nome do aluno {0}: ", j);
        turmas[i][j] = Console.ReadLine();
    }
}

Console.WriteLine();

for (int i = 0; i < num_turmas; i++) 
{
    Console.WriteLine("Nome dos alunos da Turma {0}:", i);

    for (int j = 0; j < turmas[i].Length; j++)
    {
        Console.Write("{0} ", turmas[i][j]);
    }
    
    Console.WriteLine();
}
