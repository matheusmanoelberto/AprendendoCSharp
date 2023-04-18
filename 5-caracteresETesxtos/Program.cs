using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executanto o projeto 5 - Caracteres e Textos");

        char letra= 'A';
        Console.WriteLine(letra);

        letra = (char)65;//COnvertendo numero inteiro para char
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Matheus Manoel Berto da Silva ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia= "";
        Console.WriteLine(vazia);

        letra = ' ';//No char nao tem como salvar vazio so se tiver no minimo um espaço 

        string curso = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java"; // o "@" serve para deixa um intem abaixo do outro
        Console.WriteLine(curso);

        string saudacao = "Olá, meu nome é ";
        string nome = "Rômulo ";
        string continuacao = "e minha idade é ";
        int idade = 100;
        Console.WriteLine(saudacao + nome + continuacao + idade);



        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}