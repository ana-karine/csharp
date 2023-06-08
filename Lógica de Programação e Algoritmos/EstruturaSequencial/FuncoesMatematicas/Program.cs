namespace FuncoesMatematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberX;
            int numberY;
            double result;

            // sqrt - raiz quadrada
            Console.WriteLine("Informe o radicando: ");
            numberX = int.Parse(Console.ReadLine());

            result = Math.Sqrt(numberX);

            Console.WriteLine("A raiz quadrada é: " + result);

            // pow - potenciação
            Console.WriteLine("Informe a base: ");
            numberX = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o expoente: ");
            numberY = int.Parse(Console.ReadLine());

            result = Math.Pow(numberX, numberY);

            Console.WriteLine("A potência é: " + result);    

            // abs - valor absoluto ou módulo
            Console.WriteLine("Informe um número inteiro: ");
            numberX = int.Parse(Console.ReadLine());

            result = Math.Abs(numberX);

            Console.WriteLine("O valor absoluto é: " + result);

        }
    }
}
