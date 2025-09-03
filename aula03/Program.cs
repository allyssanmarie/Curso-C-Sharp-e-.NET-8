namespace Aula03;

public class Program
{
    public static void Main()
    {
        int number = 30;
        number = 20;

        Console.WriteLine($"O valor antigo da variável era: {number}");

        number = 10;

        Console.WriteLine($"O valor novo da variável é: {number}");

        const int number1 = 1000;  //Constante o valor nao pode ser redeclarado

        Console.WriteLine($"O valor da constante é: {number1}");

        //No var sempre considera a primeira declaração e no dinâmico o último  // var / dynamic
    }
}
