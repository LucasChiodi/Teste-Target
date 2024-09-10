using System;
 class Program{
     static void Main()
    {
        int indice = 13, Soma = 0, K = 0;
        while (K < indice)
        {
            K = K + 1;
            Soma = Soma + K;
        }
        Console.WriteLine("o valor de Soma é : " + Soma);
    }
}

