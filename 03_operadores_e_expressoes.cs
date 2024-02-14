using System;

class Program
{
    static void Main(string[] args)
    {
        // Operadores Aritméticos: Adição (+), subtração (-), multiplicação (*), divisão (/) e operadores relacionais como maior que (>), menor que (<), igual a (==), etc.
        int a = 10;
        int b = 3;
        int soma = a + b; // 13
        int subtracao = a - b; // 7
        int multiplicacao = a * b; // 30
        int divisao = a / b; // 3
        int modulo = a % b; // 1, Resto da divisão.

        // Operadores de Atribuição: São usadas para atribuir valores a variáveis.
        int x = 5;
        x += 3; // x agora é 8
        x -= 2; // x agora é 6
        x *= 4; // x agora é 24
        x /= 3; // x agora é 8
        x %= 5; // x agora é 3

        // Operadores de Incremento e Decremento: Incrementar ou decrementar o valor de uma variável.
        int i = 5;
        i++; // i agora é 6
        i--; // i agora é 5 novamente

        // Operadores Relacionais: Comparar valores e produzir resultados booleanos.
        int y = 3;
        bool igual = (x == y); // falso
        bool diferente = (x != y); // verdadeiro
        bool maior = (x > y); // verdadeiro
        bool menor = (x < y); // falso

        // Operadores Lógicos: Avaliam condições lógicas. Exemplos incluem operadores lógicos como && (E), || (OU), ! (NÃO).
        bool p = true;
        bool q = false;
        bool resultadoAnd = p && q; // false, E lógico
        bool resultadoOr = p || q; // true, OU lógico
        bool resultadoNot = !p; // false, Negação lógica

        // Expressões Lógicas
        bool condicao1 = (5 > 3) && (4 < 6); // true
        bool condicao2 = (5 > 3) || (4 > 6); // true
        bool condicao3 = !(5 > 3); // false

        // Operadores de Comparação: Compara valores.
        int c = 5;
        int d = 7;
        bool igual = (c == d);      // Igualdade
        bool diferente = (c != d);  // Diferença
        bool maior = (c > d);       // Maior que
        bool menor = (c < d);       // Menor que
        bool maiorOuIgual = (c >= d);  // Maior ou igual
        bool menorOuIgual = (c <= d);  // Menor ou igual

        // Operadores Bitwise: Utilizados para operações bit a bit.
        int num1 = 5;  // 0000 0101
        int num2 = 3;  // 0000 0011

        int andBitwise = num1 & num2;  // 0000 0001 (AND bit a bit)
        int orBitwise = num1 | num2;   // 0000 0111 (OR bit a bit)
        int xorBitwise = num1 ^ num2;  // 0000 0110 (XOR bit a bit)
        int complementoBitwise = ~num1; // 1111 1010 (Complemento bit a bit)
        int shiftEsquerda = num1 << 1;  // 0000 1010 (Shift para a esquerda)
        int shiftDireita = num1 >> 1;   // 0000 0010 (Shift para a direita)

        // Operador de Concatenação de Strings:  Concatenar strings.
        string str1 = "Hello";
        string str2 = "World";
        string concat = str1 + " " + str2; // "Hello World"

        // Operadores de Incremento e Decremento:  Incrementar ou decrementar o valor de uma variável.
        int count = 5;
        count++;                // Incremento pós-fixado, count agora é 6
        int newCount = ++count; // Incremento pré-fixado, newCount agora é 7 e count é 7
        count--;                // Decremento pós-fixado, count agora é 6
        int newCount2 = --count; // Decremento pré-fixado, newCount2 agora é 5 e count é 5

        // Operador Ternário: Utilizado para fazer uma operação condicional.
        int idade = 20;
        string resultado = (idade >= 18) ? "Maior de idade" : "Menor de idade";

        // Expressões Lambda
        Func<int, int> quadrado = x => x * x;
        int resultadoLambda = quadrado(5); // resultadoLambda = 25

        // Expressões de Indexação
        int[] numeros = { 1, 2, 3, 4, 5 };
        int terceiroNumero = numeros[2]; // terceiroNumero = 3
    }
}
