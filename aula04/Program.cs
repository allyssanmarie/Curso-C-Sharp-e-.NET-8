namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------CADASTRO DE USUÁRIO------");

        //Solicitar o nome do Usuário
        Console.WriteLine("Digite o seu nome: ");
        string name = Console.ReadLine();

        //Solicitar a idade do usuário
        Console.WriteLine("Digite a sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());  //tbm tem o int.Parse()

        Console.WriteLine("--------------------------");

        Console.WriteLine($"Nome do Usuário: {name}\nIdade do Usuário: {age}");

    }
}