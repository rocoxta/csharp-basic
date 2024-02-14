using System;

class condicionais
{
    static void Main(string[] args)
    {
        // if-else: Usado para executar um bloco de código se a condição especificada for verdadeira e outro bloco de código se a condição for falsa.
        int idade = 18;

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }

        // if-else aninhado: Você pode colocar um if-else dentro de outro if ou else para fazer verificações mais detalhadas.
        int idade = 18;
        string nacionalidade = "brasileiro";

        if (idade >= 18)
        {
            if (nacionalidade == "brasileiro")
            {
                Console.WriteLine("Você é brasileiro e maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é estrangeiro, mas maior de idade.");
            }
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }

        // switch-case: é usado quando você tem uma expressão que pode ter vários valores e deseja executar blocos de código diferentes com base nesses valores.
        int diaDaSemana = 3;
        string nomeDia;

        switch (diaDaSemana)
        {
            case 1:
                nomeDia = "Segunda-feira";
                break;
            case 2:
                nomeDia = "Terça-feira";
                break;
            case 3:
                nomeDia = "Quarta-feira";
                break;
            case 4:
                nomeDia = "Quinta-feira";
                break;
            case 5:
                nomeDia = "Sexta-feira";
                break;
            case 6:
                nomeDia = "Sábado";
                break;
            case 7:
                nomeDia = "Domingo";
                break;
            default:
                nomeDia = "Dia inválido";
                break;
        }

        Console.WriteLine($"Hoje é {nomeDia}.");

        // Operador ternário: É uma forma concisa de escrever uma estrutura if-else de uma linha.
        int idade = 20;
        string status = (idade >= 18) ? "Maior de idade" : "Menor de idade";
        Console.WriteLine(status);
    }
}
