using System;

class Program
{
    // Em C#, funções são blocos de código reutilizável que realizam uma tarefa específica. Elas são usadas para dividir o código em partes menores e mais gerenciáveis, o que torna o código mais legível, modular e fácil de dar manutenção.
    // Definindo uma função chamada Soma que recebe dois inteiros como parâmetros
    static int Soma(int a, int b)
    {
        return a + b; // Retorna a soma dos dois números
    }

    static void Main(string[] args)
    {
        // Chamando a função Soma e atribuindo o resultado a uma variável
        int resultado = Soma(5, 3);

        // Imprimindo o resultado
        Console.WriteLine("Resultado da soma: " + resultado);
    }
}
