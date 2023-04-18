using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executado o projeto 7 - Consicionais");

        int idadeJoao = 15;
        int quantidadeDePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entra!");
        }
        else
        {
            if (quantidadeDePessoas > 0)
            {
                Console.WriteLine("Ele está acopanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Entrada permitida so para maiores de 18 anos");
            }
        }

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}