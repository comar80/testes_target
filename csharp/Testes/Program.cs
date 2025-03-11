using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Teste 1:");
        Teste1.Somar();
        Console.WriteLine("--------------------");
        Console.WriteLine("Teste 2:");
        Teste2.Fibonacci(25);
        Console.WriteLine("--------------------");
        Console.WriteLine("Teste 3:");
        Teste3.CalcularFaturamento("Data/dados.json");
        Console.WriteLine("--------------------");
        Console.WriteLine("Teste 4:");
        Teste4.CalcularPercentualFaturamento();
        Console.WriteLine("--------------------");
        Console.WriteLine("Teste 5:");
        Teste5.InverterString("Teste");
    }
}
