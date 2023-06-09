// https://www.beecrowd.com.br/judge/pt/problems/view/1048
using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        double novoSalario = 0.0;
        double reajuste = 0.0;
        double percentual = 0.0;

        Console.WriteLine("Informe o valor do salário atual: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salario >= 0.0 && salario <= 400.00) {
            percentual = 15;
            
        } else if (salario >= 400.01 && salario <= 800.00) {
            percentual = 12;
            
        } else if (salario >= 800.01 && salario <= 1200.00) {
            percentual = 10;
            
        } else if (salario >= 1200.01 && salario <= 2000.00) {
            percentual = 7;
            
        } else if (salario > 2000.00) {
            percentual = 4;
            
        } else {
            Console.WriteLine("Valor inválido");
        }

        reajuste = salario * (percentual/100);
        novoSalario = salario + reajuste;

        Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Em percentual: " + percentual + " %");

    }

}