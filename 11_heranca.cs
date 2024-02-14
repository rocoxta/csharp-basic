using System;
// Em C#, a herança é um conceito fundamental da programação orientada a objetos que permite que uma classe (chamada de classe derivada ou subclasse)
// herde atributos e métodos de outra classe (chamada de classe base ou superclasse). Isso permite reutilizar código e criar hierarquias de classes.

// Neste exemplo, a classe Cachorro herda da classe Animal.
// Isso significa que a classe Cachorro tem acesso ao método EmitSound() definido na classe Animal.
// Além disso, a classe Cachorro também define um método próprio chamado Latir().
// Quando você cria uma instância da classe Cachorro e chama seus métodos, tanto EmitSound() quanto Latir() podem ser chamados.
class Program
{
    // Classe base
    class Animal
    {
        public void EmitSound()
        {
            Console.WriteLine("Animal faz algum som...");
        }
    }

    // Classe derivada
    class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine("Au au!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cao = new Cachorro();
            cao.EmitSound(); // Método herdado da classe base
            cao.Latir();     // Método da classe derivada
        }
    }
}