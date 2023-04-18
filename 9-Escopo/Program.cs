using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo");

        int idadeMatheus = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "Matheus Nnão está acompanhado";
        }

        if (idadeMatheus >= 18 || acompanhado)// esse  dois traços "||" siguinifica "or"//Esse dois "&&" seguinfica o e
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode entra!");
        }
        else
        {
            Console.WriteLine("Entrada permitida so para maiores de 18 anos");
        }


        Console.WriteLine("Para finalizar a aplicação precione ENTER...");
        Console.ReadLine();
    }
}