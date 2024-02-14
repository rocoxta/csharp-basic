using System;
// Em C#, estruturas de repetição são usadas para executar um bloco de código repetidamente com base em uma condição específica. Existem três principais estruturas de repetição em C#: for, while e do-while. Aqui estão exemplos de cada uma delas:
class Program
{
    static void Main(string[] args)
    {
        // Exemplo de for: Neste exemplo, o bloco de código dentro do for será executado enquanto a condição i < 5 for verdadeira. A cada iteração, o valor de i será incrementado em 1.
        Console.WriteLine("Exemplo de for:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("O valor de i é: " + i);
        }
        Console.WriteLine();

        // Exemplo de while: Neste exemplo, o bloco de código dentro do while será executado enquanto a condição j < 5 for verdadeira. O valor de j é incrementado dentro do loop.
        Console.WriteLine("Exemplo de while:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("O valor de j é: " + j);
            j++;
        }
        Console.WriteLine();

        // Exemplo de do-while: Neste exemplo, o bloco de código dentro do do será executado pelo menos uma vez, mesmo que a condição k < 5 seja falsa desde o início. Depois disso, o bloco de código será repetido enquanto a condição k < 5 for verdadeira.
        Console.WriteLine("Exemplo de do-while:");
        int k = 0;
        do
        {
            Console.WriteLine("O valor de k é: " + k);
            k++;
        } while (k < 5);
    }
}

