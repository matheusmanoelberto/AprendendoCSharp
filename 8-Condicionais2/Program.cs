using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais");

        int idadeJoao = 18;
        int quantidadeDePessoas = 0;

        bool acompanhado = quantidadeDePessoas > 1;
        bool grupo = true;

        if (idadeJoao >= 18 || acompanhado)// esse  dois traços "||" siguinifica "or"//Esse dois "&&" seguinfica o e
        {
            Console.WriteLine("Pode entra!");
        }
        else
        {
            Console.WriteLine("Entrada permitida so para maiores de 18 anos");
        }

        Console.WriteLine("Para finalizar a aplicacao precione ENTER...");
        Console.ReadLine();
    }
}