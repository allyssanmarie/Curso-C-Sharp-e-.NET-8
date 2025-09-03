namespace Aula05;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------Calculadora Bem Simples------");

        Console.WriteLine("Digite o número 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o número 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());


        int sum = number1 + number2;
        int subtraction = number1 - number2;
        int multiplication = number1 * number2;
        int division = number1/ number2;
        int module = number1 % number2; //resto da divisão

        Console.WriteLine($"O valor da soma: {sum}");
        Console.WriteLine($"O valor da subtração: {subtraction}");
        Console.WriteLine($"O valor da multiplicação: {multiplication}");
        Console.WriteLine($"O valor da divisão: {division}");
        Console.WriteLine($"O valor do resto: {module}");

    }

}
