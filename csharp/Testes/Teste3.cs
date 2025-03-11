using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}

class Teste3
{
    public static void CalcularFaturamento(string caminhoArquivo)
    {
        var json = File.ReadAllText(caminhoArquivo);
        var faturamento = JsonConvert.DeserializeObject<List<Faturamento>>(json);
        
        var faturamentoValido = faturamento.Where(f => f.Valor > 0).ToList();
        
        double menorValor = faturamentoValido.Min(f => f.Valor);
        double maiorValor = faturamentoValido.Max(f => f.Valor);
        double mediaMensal = faturamentoValido.Average(f => f.Valor);
        int diasAcimaDaMedia = faturamentoValido.Count(f => f.Valor > mediaMensal);
        
        Console.WriteLine($"Menor faturamento diário: {menorValor:C}");
        Console.WriteLine($"Maior faturamento diário: {maiorValor:C}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
