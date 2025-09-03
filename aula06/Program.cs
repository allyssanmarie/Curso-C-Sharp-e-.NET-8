namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------Verificador de Números Pares ou Ímpares------");
        Console.WriteLine("Digite um numero: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = number % 2;  //Se o resto for 0 é par, senão ímpar

        if (result == 0)
        {
            Console.WriteLine($"\nO numero digitado é par ");
        }

        else
        {
            Console.WriteLine("\nO numero digitado é ímpar");
        }
    }
}