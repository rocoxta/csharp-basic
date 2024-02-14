using System;
// Em C#, um namespace é uma maneira de organizar e controlar o escopo dos nomes de classes, estruturas, interfaces, enumeradores e outros elementos dentro de um programa.
// Ele ajuda a evitar conflitos de nomeação e facilita a organização e a reutilização de código.
// Um namespace pode conter outros namespaces, permitindo assim uma estrutura hierárquica de organização. Ele é declarado usando a palavra-chave namespace.

    namespace ExemploNamespace
{
    // Definição de uma classe dentro do namespace ExemploNamespace
    class MinhaClasse
    {
        public void ExibirMensagem()
        {
            Console.WriteLine("Esta é uma mensagem da classe MinhaClasse dentro do namespace ExemploNamespace");
        }

    }

    namespace OutroNamespace
    {
        // Definição de uma classe em outro namespace
        class OutraClasse
        {
            public void ExibirMensagem()
            {
                Console.WriteLine("Esta é uma mensagem da classe OutraClasse dentro do namespace OutroNamespace");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de utilização das classes definidas nos namespaces
            ExemploNamespace.MinhaClasse minhaInstancia = new ExemploNamespace.MinhaClasse();
            minhaInstancia.ExibirMensagem();

            OutroNamespace.OutraClasse outraInstancia = new OutroNamespace.OutraClasse();
            outraInstancia.ExibirMensagem();
        }
    }
    // Neste exemplo, duas classes (MinhaClasse e OutraClasse) estão definidas em dois namespaces diferentes (ExemploNamespace e OutroNamespace).
    // Esses namespaces ajudam a evitar conflitos de nomeação, mesmo que as classes tenham o mesmo nome.
    // Usando a palavra-chave using, você pode importar namespaces para o escopo atual,
    // o que permite que você use classes e outros tipos definidos nesses namespaces sem ter que digitar o nome completo toda vez. Por exemplo:
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasse minhaInstancia = new MinhaClasse();
            minhaInstancia.ExibirMensagem();
        }
    }
}