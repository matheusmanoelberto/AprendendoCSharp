using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupaça");

        double investimento = 1000;

        // rendimento de 0.5% (0.005) ao mês

        // mês 1
        //investimento = investimento + investimento * 0.005;
        // mês 2
        //investimento = investimento + investimento * 0.005;
        //mês 3
        //investimento = investimento + investimento * 0.005;
       //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês "+ mes + " você tera R$ " + investimento);
            
            //mes = mes + 1;
            mes += 1;
        }

        Console.WriteLine("Tecla enter para fechar...");
        Console.ReadLine(); 
    }
}