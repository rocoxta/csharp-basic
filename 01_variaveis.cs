using System;

class variáveis
{
    static void Main(string[] args)
    {
        // Tipo Inteiro (int): Armazena números inteiros sem casas decimais.
        int idade = 25;

        // Tipo Ponto Flutuante (float): Armazena números de ponto flutuante com precisão simples.
        float altura = 1.75f;

        // Tipo Ponto Flutuante de Precisão Dupla (double):  Armazena números de ponto flutuante com precisão dupla.
        double preco = 19.99;

        // Tipo Caractere (char): Armazena um único caractere Unicode.
        char letra = 'A';

        // Tipo Booleano (bool): Armazena valores booleanos verdadeiro ou falso.
        bool estaChovendo = true;

        // Tipo String: Armazena uma sequência de caracteres.
        string nome = "João";

        // Tipo Decimal (decimal): Armazena números decimais de alta precisão, com uma faixa maior do que o tipo double.
        decimal precoProduto = 99.99m;

        // Tipo Byte (byte): Armazena números inteiros sem sinal na faixa de 0 a 255.
        byte nivelDeBrilho = 200;

        // Tipo SByte (sbyte): Armazena números inteiros com sinal na faixa de -128 a 127.
        sbyte temperatura = -10;

        // Tipo Short (short): Armazena números inteiros com sinal na faixa de -32.768 a 32.767.
        short quantidade = 1000;

        // Tipo UShort (ushort): Armazena números inteiros sem sinal na faixa de 0 a 65.535.
        ushort idadeU = 30;

        // Tipo Long (long): Armazena números inteiros com sinal em uma faixa muito ampla.
        long populacaoMundial = 7800000000;

        Console.WriteLine("Exemplos de variáveis em C#:");
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Preço: " + preco);
        Console.WriteLine("Letra: " + letra);
        Console.WriteLine("Está Chovendo? " + estaChovendo);
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Preço do Produto: " + precoProduto);
        Console.WriteLine("Nível de Brilho: " + nivelDeBrilho);
        Console.WriteLine("Temperatura: " + temperatura);
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Idade (UShort): " + idadeU);
        Console.WriteLine("População Mundial: " + populacaoMundial);

        // Aguarda o usuário pressionar uma tecla antes de sair
        Console.ReadKey();
    }
}
