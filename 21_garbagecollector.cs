using System;
class Program
{
    // Em C#, o gerenciamento de memória refere-se ao controle automático da alocação e liberação de memória pelo ambiente de execução do Common Language Runtime (CLR).
    // O CLR é responsável por gerenciar a memória alocada para os objetos durante a execução de um programa C#.
    // Ele utiliza um coletor de lixo (garbage collector) para determinar quando a memória de um objeto não está mais em uso e liberá-la automaticamente para ser reutilizada.

    // O principal objetivo do gerenciamento de memória em C# é evitar vazamentos de memória e corrupção de memória,
    // garantindo que os recursos sejam liberados quando não são mais necessários, sem a necessidade de intervenção explícita do programador.

    // Exemplos de como o gerenciamento de memória funciona em C#:
    // 1- Alocação de memória para objetos: Quando um objeto é criado usando a palavra-chave new, o CLR aloca espaço de memória suficiente para armazenar o objeto.

    MinhaClasse obj = new MinhaClasse();

    // Liberação de memória: Quando um objeto não é mais referenciado por nenhum código, ele se torna elegível para ser coletado pelo garbage collector.
    // O garbage collector determina quais objetos não estão mais em uso e libera a memória que ocupam.

    MinhaClasse obj = new MinhaClasse();
    obj = null; // O objeto anteriormente referenciado por 'obj' não é mais acessível

    // Em algum momento, o garbage collector irá liberar a memória ocupada por 'obj'

    MinhaClasse obj = new MinhaClasse();
    obj = null; // O objeto anteriormente referenciado por 'obj' não é mais acessível

    // Em algum momento, o garbage collector irá liberar a memória ocupada por 'obj'
    // Gerenciamento automático de memória: O programador não precisa se preocupar com a liberação explícita de memória.
    // O garbage collector é responsável por identificar e liberar objetos não utilizados, permitindo que o programador se concentre na lógica do programa.
    // Não é necessário liberar a memória manualmente

    MinhaClasse obj = new MinhaClasse();

    // O garbage collector cuidará da liberação de memória quando 'obj' não for mais necessário
    // Esses são exemplos básicos de como o gerenciamento de memória funciona em C#.
    // É importante entender como ele opera para escrever código eficiente e evitar problemas de vazamento de memória.
}