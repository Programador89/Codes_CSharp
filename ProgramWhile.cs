using System;
using System.Globalization;

namespace projectWhile
{
    class ProgramWhile
    {
        static void Main(string[] args)
        {
            
            //Exercicio 01 - Validador de senha! Senha: 2022.
            int password = 2022;
            System.Console.Write("Digite a senha: ");
            password = int.Parse(Console.ReadLine());


            while (password != 2022)
            {
                System.Console.WriteLine("Senha incorreta!");
                System.Console.Write("Digite a senha: ");
                password = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Senha correta!");
            

            /*Exercicio 02 - usuário informa o tipo de combustível desejado e programa realiza contagens dos tipos mais usados. Programa termina quando opção 4 selecionada, nesse momento mensagem de agradecimento é exibida junto com os dados do programa. */

            int alcool   = 0;
            int gasolina = 0; 
            int diesel   = 0;

            System.Console.WriteLine("Selecione o tipode combustível desejado:");
            System.Console.Write("1.Álcool 2.Gasolina 3.Diesel 4.Fim: ");

            int option = int.Parse(Console.ReadLine());

            while (option != 4)
            {
                if(option == 1) {
                    alcool ++;
                }else if(option == 2) {
                    gasolina ++;
                }else if(option == 3) {
                    diesel ++;
                }
                System.Console.WriteLine("Selecione o tipode combustível desejado:");
                System.Console.Write("1.Álcool 2.Gasolina 3.Diesel 4.Fim: ");

                option = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Muito Obrigado!");

            System.Console.WriteLine($"Alcool   = {alcool}");
            System.Console.WriteLine($"Gasolina = {gasolina}");
            System.Console.WriteLine($"Diesel   = {diesel}");
        }
    }
}
