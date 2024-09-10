using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário um número
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número pertence à sequência de Fibonacci
        bool pertence = VerificarFibonacci(numero);

        // Exibe a mensagem com o resultado
        if (pertence)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }
    static bool VerificarFibonacci(int num)
    {
        if (num < 0) return false;

        int a = 0, b = 1, c = 0;

        if (num == 0 || num == 1) return true;

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c == num;
    }
}
