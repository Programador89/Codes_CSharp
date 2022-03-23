using System;
using System.Globalization;

namespace Program
{

    class Program
    {
        static void Main(String[] args)
        {
            //Para identar o código use Alt + Shift + F
            sbyte age = 32;
            byte number = 255;
            float numberFloat = 4.8f;
            string name = "Larissa Sather, minha esposa maravilhosa.";
            object myName = "Rafael Dantas";
            int maxNumber = int.MaxValue;
            int minNumber = int.MinValue;

            System.Console.WriteLine($"Minha idade {age} anos. Matrícula {number}\n");
            System.Console.WriteLine("Caracteres especiais podem ser inseridos no programa através da tabela Unicode.\n");
            System.Console.WriteLine($"Exibindo um numero float {numberFloat}\n");
            System.Console.WriteLine($"{name} \n");
            System.Console.WriteLine($"{myName}\n");
            System.Console.WriteLine($"Exibindo o valor máximo de um número inteiro: {maxNumber}\n");
            System.Console.WriteLine($"Exibindo o valor mínumo de um numero inteiro: {minNumber}\n");

            double saldo = 10.5678;
            Console.WriteLine($"Saldo atual: {saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            
           /* //Exercicio 02 -> Calculando a area do círculo || area = π . raio2*/

            double area;
            double TT = 3.14159;
            int raio = 2;

            area = Math.Pow(raio, 2) * TT;

            System.Console.WriteLine($"A area do círculo: {area.ToString("F4", CultureInfo.InvariantCulture)}");
            
            
            /* //Exercicio 03 -> Ler 4 valores inteiros e calcula a diferença entre eles. Formula => (A * B - C * D).*/

            System.Console.Write("Digite o primeiro número inteiro: ");
            int numberOne = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o segundo número inteiro: ");
            int numberTwo = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o terceiro número inteiro: ");
            int numberTree = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o quarto número inteiro: ");
            int numberFour = int.Parse(Console.ReadLine());

            int differenceNumbers = (numberOne*numberTwo)-(numberTree*numberFour);

            System.Console.WriteLine($"A diferença entre os números inoformados é {differenceNumbers}");
            

            /* //Exercicio 04 -> Calculo de horas trabalhadas. Colete => numero do funcionario, horas trab., valor hora, calcula e exibe resultado.*/

            System.Console.Write("Informe sua matricula: ");
            int matricula = int.Parse(Console.ReadLine());

            System.Console.Write("Informe número de horas trabalhadas: ");
            double horasTrab = double.Parse(Console.ReadLine());

            System.Console.Write("Informe o valor da hora trabalhada: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcSalario = horasTrab * valorHora;

            System.Console.WriteLine($"Matricula = {matricula}");
            System.Console.WriteLine($"Salário = {calcSalario.ToString("F2", CultureInfo.InvariantCulture)}");
            

            /* // Exercicio 05 -> Calculo de peças :: ler código peça 01, quantidade de peças 01, valor peça 01 // peça 02, quantidade de peças 02, valor peça 02 // Calcule e mostre o valor a ser pago.*/

            System.Console.WriteLine("Informe o código da primeira peça, a quantidade e o valor unitário (Na mesma linha): ");
            string[] vetDadosPeca = Console.ReadLine().Split(' ');

            System.Console.WriteLine("Informe o código da segunda peça, a quantidade e o valor unitário (Na mesma linha): ");
            string[] vetDadosPeca2 = Console.ReadLine().Split(' ');
            
            int codPeca      = int.Parse(vetDadosPeca[0]);
            int quantPeca    = int.Parse(vetDadosPeca[1]);
            double valorPeca = double.Parse(vetDadosPeca[2], CultureInfo.InvariantCulture);
            double valorTotal = quantPeca * valorPeca;

            int codPeca2      = int.Parse(vetDadosPeca2[0]);
            int quantPeca2    = int.Parse(vetDadosPeca2[1]);
            double valorPeca2 = double.Parse(vetDadosPeca2[2], CultureInfo.InvariantCulture);
            double valorTotal2 = quantPeca2 * valorPeca2;

            double totalCompra = valorTotal + valorTotal2;

            System.Console.WriteLine($"Total a pagar: {totalCompra.ToString("F2", CultureInfo.InvariantCulture)}");
            

            /* 
                Exercicio 06 -> Calculo de áreas:: 
                Circulo => area = TT * R²
                Triangulo retangulo = (base * altura) / 2 
                Trapézio => A=(a+b)/2 x h
                Quadrado => lado * lado
                retangulo => base * altura
            */

            System.Console.Write("Informe três valores de ponto flutuante de dupla precisão: ");
            string[] vetDados = Console.ReadLine().Split(' ');

            double firstEntry   = double.Parse(vetDados[0], CultureInfo.InvariantCulture);
            double secoundEntry = double.Parse(vetDados[1], CultureInfo.InvariantCulture);
            double thirdEntry   = double.Parse(vetDados[2], CultureInfo.InvariantCulture);
            double pi = 3.14159; 

            //Calculos: 
            double triangulo = (firstEntry * thirdEntry) / 2;
            double circulo = Math.Pow(thirdEntry, 2) * pi;
            double trapezio = ((firstEntry + secoundEntry)/2) * thirdEntry;
            double quadrado = Math.Pow(secoundEntry, 2);
            double retangulo = firstEntry * secoundEntry;

            //Impressões: 
            System.Console.WriteLine($"Triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Trapézio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Retangulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");




        }
    }
}
