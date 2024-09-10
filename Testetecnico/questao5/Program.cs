using System;

class Program
{
    static void Main()
    {
        // Recebe a string do usuário
        Console.Write("Digite uma string para inverter: ");
        string entrada = Console.ReadLine();

        // Inverte a string
        string invertida = InverterString(entrada);

        // Exibe a string invertida
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string str)
    {
        // Converte a string em um array de caracteres
        char[] caracteres = str.ToCharArray();
        
        // Inicializa índices para percorrer o array
        int inicio = 0;
        int fim = caracteres.Length - 1;

        // Inverte os caracteres do array
        while (inicio < fim)
        {
            // Troca os caracteres nas posições inicio e fim
            char temp = caracteres[inicio];
            caracteres[inicio] = caracteres[fim];
            caracteres[fim] = temp;

            // Move os índices em direção ao centro
            inicio++;
            fim--;
        }

        // Converte o array de volta para string e retorna
        return new string(caracteres);
    }
}
