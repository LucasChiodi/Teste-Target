using System;

class Program
{
    static void Main()
    {
        // Valores de faturamento por estado
        decimal faturamentoSP = 67836.43m;
        decimal faturamentoRJ = 36678.66m;
        decimal faturamentoMG = 29229.88m;
        decimal faturamentoES = 27165.48m;
        decimal faturamentoOutros = 19849.53m;

        // Calcula o valor total de faturamento
        decimal valorTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

        // Calcula o percentual de representação de cada estado
        decimal percentualSP = (faturamentoSP / valorTotal) * 100;
        decimal percentualRJ = (faturamentoRJ / valorTotal) * 100;
        decimal percentualMG = (faturamentoMG / valorTotal) * 100;
        decimal percentualES = (faturamentoES / valorTotal) * 100;
        decimal percentualOutros = (faturamentoOutros / valorTotal) * 100;

        // Exibe os resultados
        Console.WriteLine($"Percentual de representação do faturamento em SP: {percentualSP:F2}%");
        Console.WriteLine($"Percentual de representação do faturamento em RJ: {percentualRJ:F2}%");
        Console.WriteLine($"Percentual de representação do faturamento em MG: {percentualMG:F2}%");
        Console.WriteLine($"Percentual de representação do faturamento em ES: {percentualES:F2}%");
        Console.WriteLine($"Percentual de representação do faturamento em Outros: {percentualOutros:F2}%");
    }
}
