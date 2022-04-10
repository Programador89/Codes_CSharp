using System.Globalization;

System.Console.Write("Informe o numero de pessoas da pesquisa: ");
int quantity = int.Parse(Console.ReadLine());

double[] height = new double[quantity];

for (int i = 0; i < height.Length; i++)
{   
    System.Console.Write("Informe a altura: ");
    height[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0.0;
for (int i = 0; i < quantity; i++)
{
    sum += height[i];
}

double media = sum / quantity;
System.Console.WriteLine($"A média da altura é: {media.ToString("F2", CultureInfo.InvariantCulture)}");
