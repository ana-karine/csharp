// https://www.beecrowd.com.br/judge/pt/problems/view/1051

using System;
using System.Globalization;

namespace URI {

    class Program {
        static void Main(string[] args) {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            // renda: de 0.00 a R$ 2000.00
            // imposto de renda: isento 
            if (salario <= 2000.0) {
                imposto = 0.0;
            }
            // renda: de R$ 2000.01 a R$ 3000.00
            // imposto de renda: 8% 
            else if (salario <= 3000.0) {
                imposto = (salario - 2000.0) * 0.08;
            }
            // renda: de R$ 3000.01 a R$ 4500.00
            // imposto de renda: 18% 
            else if (salario <= 4500.0) {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            // renda: acima de R$ 4500.00
            // imposto de renda: 28% 
            else {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}