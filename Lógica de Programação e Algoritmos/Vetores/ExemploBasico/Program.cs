using System.Globalization;

// http://www.linhadecodigo.com.br/artigo/3444/arrays-em-csharp-teoria-e-pratica.aspx

// Exemplo: utilizar um vetor para armazenar 10 números informados pelo usuário e, ao final, 
// exibir aqueles que estão abaixo da média do conjunto.

int[] valores = new int[10];
decimal soma = 0, media = 0;

for (int i = 0; i < 10; i++) {
    Console.WriteLine(String.Format("Informe o elemento de índice {0}:", i));
    valores[i] = int.Parse(Console.ReadLine());
    soma += valores[i];
}

media = soma / 10;

Console.WriteLine(String.Format("\nMédia do conjunto: {0}\n", media.ToString(CultureInfo.InvariantCulture)));

for (int i = 0; i < 10; i++) {
    if (valores[i] < media) 
        Console.WriteLine(String.Format("O elemento de índice {0}, cujo valor é {1}, está abaixo da média.", i, valores[i]));
}
