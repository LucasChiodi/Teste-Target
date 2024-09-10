using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json; // Certifique-se de ter o pacote Newtonsoft.Json instalado

class FaturamentoDiario
{
    public string Dia { get; set; }
    public decimal ValorFaturamento { get; set; } // Renomeado para evitar conflito
}

class Program
{
    static void Main()
    {
        // Caminho para o arquivo JSON (certifique-se de que o caminho está correto)
        string caminhoArquivo = "faturamento.json";

        // Verifica se o arquivo existe
        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine("Arquivo de faturamento não encontrado.");
            return;
        }

        // Lê o conteúdo do arquivo JSON
        string json = File.ReadAllText(caminhoArquivo);
        List<FaturamentoDiario> faturamentos = JsonConvert.DeserializeObject<List<FaturamentoDiario>>(json);

        // Remove os dias com faturamento 0
        var diasComFaturamento = faturamentos.Where(f => f.ValorFaturamento > 0).ToList();

        // Verifica se há dias com faturamento
        if (!diasComFaturamento.Any())
        {
            Console.WriteLine("Não há dias com faturamento para calcular.");
            return;
        }

        // Calcula o menor e maior valor de faturamento
        decimal menorFaturamento = diasComFaturamento.Min(f => f.ValorFaturamento);
        decimal maiorFaturamento = diasComFaturamento.Max(f => f.ValorFaturamento);

        // Calcula a média mensal, considerando apenas os dias com faturamento
        decimal mediaMensal = diasComFaturamento.Average(f => f.ValorFaturamento);

        // Conta o número de dias com faturamento acima da média
        int diasAcimaDaMedia = diasComFaturamento.Count(f => f.ValorFaturamento > mediaMensal);

        // Exibe os resultados
        Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:C}");
        Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:C}");
        Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
