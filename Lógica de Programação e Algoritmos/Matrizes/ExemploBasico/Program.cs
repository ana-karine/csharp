// http://www.linhadecodigo.com.br/artigo/3444/arrays-em-csharp-teoria-e-pratica.aspx

// Exemplo: utilizar uma matriz para montar uma “cartela de bingo”, onde as casas são informadas pelo usuário.

int[,] bingo = new int[2,2];

for (int l = 0; l < 2; l++) 
{
    for (int c = 0; c < 2; c++)
    {
        Console.WriteLine(String.Format("Informe o elemento ({0},{1})", l, c));
        bingo[l,c] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();

for (int l = 0; l < 2; l++) 
{
    for (int c = 0; c < 2; c++)
    {
        Console.Write(bingo[l,c] + " ");
    }
    Console.WriteLine();
}
