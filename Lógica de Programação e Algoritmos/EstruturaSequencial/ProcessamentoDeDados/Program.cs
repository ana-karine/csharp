using System.Globalization;


// Saída de dados
double number = 10.35784;

Console.WriteLine(number); // 10,35784
Console.WriteLine(number.ToString("F2")); // 10,36
Console.WriteLine(number.ToString("F2", CultureInfo.InvariantCulture)); // 10.36


// Entrada de dados
string phrase;
string[] vector;

Console.WriteLine("Escreva uma frase com três palavras: ");
phrase = Console.ReadLine(); // lê a string até apertar <Enter>

vector = phrase.Split(' ');

Console.WriteLine("vector[0] = " + vector[0]);
Console.WriteLine("vector[1] = " + vector[1]);
Console.WriteLine("vector[2] = " + vector[2]);


// Parse
int numA; 
double numB; 
double numC; 
char character; 

numA = int.Parse(Console.ReadLine()); // 2
numB = double.Parse(Console.ReadLine()); // 2.65
numC = double.Parse(Console.ReadLine()); // 3,98
character = char.Parse(Console.ReadLine()); // 'k'

Console.WriteLine("numA = " + numA); // 2
Console.WriteLine("numB = " + numB); // 265
Console.WriteLine("numC = " + numC); // 3,98
Console.WriteLine("character = " + character); // k

numB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // 2.65
numC = double.Parse(Console.ReadLine()); // 3,98

Console.WriteLine("numB = " + numB); // 2,65
Console.WriteLine("numC = " + numC.ToString(CultureInfo.InvariantCulture)); // 3.98