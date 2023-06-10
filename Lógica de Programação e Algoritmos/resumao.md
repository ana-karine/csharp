#### Namespace
```
using System.Globalization; // CultureInfo.InvariantCulture
```

#### Variáveis e Tipos Básicos (`<tipo> <nome> = <valor inicial>`)
```
double d = 6.0;
float f = 6f;
```

#### Casting: conversão explícita de um tipo para outro
```
<variavelA> = (double) <variavelB> / <variavelC>;
```

#### Saída de dados   
```
double number = 10.35784;

Console.WriteLine(number); // 10,35784
Console.WriteLine(number.ToString("F2")); // 10,36
Console.WriteLine(number.ToString("F2", CultureInfo.InvariantCulture)); // 10.36
```

#### Entrada de dados
```
string phrase;

phrase = Console.ReadLine(); // lê a string até apertar <Enter>
```

#### Split
```
string[] vector;

vector = phrase.Split(' ');

Console.WriteLine("vector[0] = " + vector[0]);
```

#### Parse
```
double numB; 
double numC; 

numB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // 2.65
numC = double.Parse(Console.ReadLine()); // 3,98

Console.WriteLine("numB = " + numB); // 2,65
Console.WriteLine("numC = " + numC.ToString(CultureInfo.InvariantCulture)); // 3.98
```

#### Funções Matemáticas
```
<result> = Math.Sqrt(<numberX>); // Sqrt - raiz quadrada
<result> = Math.Pow(<numberX>, <numberY>); // Pow - potenciação
<result> = Math.Abs(<numberX>); // Abs - valor absoluto ou módulo
```

#### [Arrays - declaração](http://www.linhadecodigo.com.br/artigo/3444/arrays-em-csharp-teoria-e-pratica.aspx)
1: Declaração de um vetor
Estrutura geral: `tipo[] nome`;
```
int[] numeros; // vetor de inteiros
string[] nomes; // vetor de strings
```
2: Declaração de uma matriz
Estrutura geral: `tipo[,] nome`;
```
int[,] matriz2dimensoes;
decimal[, ,] matriz3dimensoes;
```
3: Declaração de array jagged
Estrutura geral: `tipo[][] nome`;
```
int[][] vetorDeInteiros;
float[][] vetorDeDecimais;
```

#### [Arrays - inicialização](http://www.linhadecodigo.com.br/artigo/3444/arrays-em-csharp-teoria-e-pratica.aspx)
- **No momento da declaração**
1: inicialização de vetor junto com a declaração
```
int[] impares = new int[] { 1, 3, 5, 7, 9 };
// ou
int[] impares = { 1, 3, 5, 7, 9 };
```
2: inicialização de matriz junto com a declaração
```
int[,] matriz = new int[,] { { 1, 2 }, { 3, 4 } };
// ou
int[,] matriz = { { 1, 2 }, { 3, 4 } };
```
3: inicialização de jagged array junto com a declaração
```
int[][] jagged1 = new int[][] 
{
    new int[] {0,1,2,3},
    new int[] {4,5,6,7,8,9},
    new int[] {10,20,30,40}
};
// ou
int[][] jagged1 = 
{
    new int[] {0,1,2,3},
    new int[] {4,5,6,7,8,9},
    new int[] {10,20,30,40}
};
```

- **Após a declaração**
1: inicializando elementos de um vetor individualmente
```
int[] vetor = new int[3];
vetor[0] = 10;
vetor[1] = 25;
vetor[2] = 99;
```
2: inicializando elementos de uma matriz individualmente
```
string[,] matriz = new string[2, 2];
matriz[0, 0] = "C#";
matriz[0, 1] = "Delphi";
matriz[1, 0] = "Java";
matriz[1, 1] = "VB.NET";
```
3: inicialização dos elementos de um jagged array inividualmente
```
int[][] jagged = new int[3][];
jagged[0] = new int[] { 0, 1, 2, 3};
jagged[1] = new int[] { 4, 5, 6, 7, 8, 9 };
jagged[2] = new int[] { 10, 20};
```
