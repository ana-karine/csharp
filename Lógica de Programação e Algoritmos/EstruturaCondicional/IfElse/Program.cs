int numX, numY, numZ;
string numbersString;
string[] numbersVector; 

Console.WriteLine("Escreva 3 números inteiros: ");
numbersString = Console.ReadLine();

numbersVector = numbersString.Split(' ');

numX = int.Parse(numbersVector[0]);
numY = int.Parse(numbersVector[1]);
numZ = int.Parse(numbersVector[2]);

if (numX < numY && numX < numZ) {
    Console.WriteLine("O menor dos números é o " + numX);
} else if (numY < numX && numY < numZ) {
    Console.WriteLine("O menor dos números é o " + numY);
} else {
    Console.WriteLine("O menor dos números é o " + numZ);
}
