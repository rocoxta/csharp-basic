using System;
// Em C#, a palavra-chave protected é um modificador de acesso que define a visibilidade de membros de uma classe
// para a própria classe e suas subclasses (também conhecidas como classes derivadas).
// Isso significa que os membros marcados como protected podem ser acessados dentro da
// classe onde são definidos e também por qualquer classe derivada dessa classe, mas não por código externo.
class Program { 

    // Definição da classe base
    public class Animal
    {
        protected string nome; // Atributo protegido

        public Animal(string nome)
        {
            this.nome = nome;
        }

        protected void EmitirSom()
        {
            Console.WriteLine("Som emitido por um animal.");
        }
    }

    // Definição de uma classe derivada
    public class Cachorro : Animal
    {
        public Cachorro(string nome) : base(nome)
        {
        }

        public void Latir()
        {
            EmitirSom(); // Podemos chamar o método protegido da classe base
            Console.WriteLine($"{nome} está latindo...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro("Rex");
            cachorro.Latir(); // Isso imprimirá "Som emitido por um animal." seguido por "Rex está latindo..."
        }
    }

}
// Neste exemplo, a classe Animal possui um atributo nome e um método EmitirSom() marcados como protected.
// Isso significa que eles só podem ser acessados dentro da classe Animal ou em suas subclasses, como Cachorro.
// A classe Cachorro herda de Animal e pode acessar diretamente o atributo nome e o método EmitirSom().
// No método Latir() da classe Cachorro, podemos ver que ele chama o método EmitirSom() normalmente.
// No entanto, se tentássemos acessar nome diretamente fora das classes Animal e Cachorro, resultaria em um erro de compilação devido ao acesso protegido.