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
<result> = Math.Sqrt(<numberX>); // sqrt - raiz quadrada
<result> = Math.Pow(<numberX>, <numberY>); // pow - potenciação
<result> = Math.Abs(<numberX>); // abs - valor absoluto ou módulo
```