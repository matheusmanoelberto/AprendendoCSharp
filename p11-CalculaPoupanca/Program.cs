using System;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

        double investimento = 1000;
            //variavel - condição - computador  
        for(int mes = 1; mes <= 12; mes = mes + 1)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + "você tem R$ " + investimento);
        }
        
        Console.WriteLine("Para finalizar a aplicação precione ENTER....");
        Console.ReadLine();
    }
}