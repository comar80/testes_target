using System;
using System.Collections.Generic;

class Teste4
{
    public static void CalcularPercentualFaturamento()
    {
        var faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double totalFaturamento = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            totalFaturamento += valor;
        }

        Console.WriteLine("Percentual de representação por estado:");
        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / totalFaturamento) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}