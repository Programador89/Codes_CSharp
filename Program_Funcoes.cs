using System;
using System.Globalization;

class Program_Funcoes {
    static void Main(string[] args){
        // Definir qual é o maior número.   

        System.Console.WriteLine("Digite 3 numeros: ");
        int numberOne = int.Parse(Console.ReadLine());
        int numberTwo = int.Parse(Console.ReadLine());
        int numberTree = int.Parse(Console.ReadLine());

        double higherNumber = Higher(numberOne, numberTwo, numberTree);

        System.Console.WriteLine($"Maior número: {higherNumber}");
    }

    static int Higher(int firstNumber, int secoundNUmber, int thirdNumber) {
        int bigNumber = 0;

        if(firstNumber > secoundNUmber && firstNumber > thirdNumber){
            bigNumber = firstNumber;
        }else if(secoundNUmber > thirdNumber){
            bigNumber = secoundNUmber;
        }else {
            bigNumber = thirdNumber;
        }
        return bigNumber;
    }
}
