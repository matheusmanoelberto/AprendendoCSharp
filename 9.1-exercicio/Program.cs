using System;
class Programa
{    
    static void Main(string[] args)
    {
        double salario;
        bool foiPromovido = true;
        if (foiPromovido)
        {
            salario = 4200.0;
        }
        else
        {
            salario = 3800.0;
        }
        Console.WriteLine("Seu almento de salario foi de "+salario);
        Console.WriteLine("Para ecerra a aplicação precione ENTER...");
        Console.ReadLine();
    }
}
