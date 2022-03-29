using System;
using System.Globalization;

namespace ConsultaSalario {
    class Program {
        static void Main(string[] args) {

            var FirstEmployee = new Funcionario();
            var SecoundEmployee = new Funcionario();

            System.Console.WriteLine("Informe nome e salário de dois funcionários.");
            System.Console.WriteLine("Funcionário 01: ");
            System.Console.Write("Nome: ");
            FirstEmployee.Name = Console.ReadLine();
            System.Console.Write("Salário: ");
            SecoundEmployee.WageFirst = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Funcionário 02: ");
            System.Console.Write("Nome: ");
            SecoundEmployee.Name = Console.ReadLine();
            System.Console.Write("Salário: ");
            SecoundEmployee.WageSecound = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine($"Média salarial: {SecoundEmployee.SalaryCalculation().ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
